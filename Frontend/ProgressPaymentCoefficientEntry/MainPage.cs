using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Staj2Proje
{
    public partial class MainPage : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonFile.Checked = true;
            AddProgressToCombobox();
            comboBoxProgressPayment.SelectedItem = "B2B";
            AddTableColumnNames();
        }

        public void AddProgressToCombobox()
        {
            comboBoxProgressPayment.Items.Clear();
            SqlDataReader dr;
            //conn = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                { 
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Select * from ProgressType", conn);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBoxProgressPayment.Items.Add(dr["ProgressType"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            } 
        }

        public void AddTableColumnNames()
        {
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "Progress Type";
            dataGridView1.Columns[1].Name = "Type";
            dataGridView1.Columns[2].Name = "Min Value";
            dataGridView1.Columns[3].Name = "Max Value";
            dataGridView1.Columns[4].Name = "Coefficient";

        }

        private void comboBoxHakedisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProgressPayment.SelectedItem.ToString() == "INDIVIDUAL" || comboBoxProgressPayment.SelectedItem.ToString() == "PRODUCT")
            {
                radioButtonFile.Enabled = false;
                radioButtonParcel.Enabled = false;
                textBoxMinValue.Enabled = false;
                textBoxMaxValue.Enabled = false;
                textBoxCoefficient.Enabled = true;
            }
            else
            {
                radioButtonFile.Enabled = true;
                radioButtonParcel.Enabled = true;
                textBoxMinValue.Enabled = true;
                textBoxMaxValue.Enabled = true;
                textBoxCoefficient.Enabled = true;
            }
        }

        private void SaveInfoToDatabase()
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var val1 = dataGridView1.Rows[i].Cells[0].Value; // 1. kolon
                var val2 = dataGridView1.Rows[i].Cells[1].Value; // 2. kolon
                var val3 = dataGridView1.Rows[i].Cells[2].Value; // 3. kolon
                var val4 = dataGridView1.Rows[i].Cells[3].Value; // 3. kolon
                var val5 = dataGridView1.Rows[i].Cells[4].Value; // 3. kolon

                string add = "insert into Product(progress_type,type,min_value,max_value,coefficient) values ('" + val1 + "' , '" + val2 + "' , '" + val3 + "' , '" + val4 + "' , '" + val5 + "')";
                SqlCommand command = new SqlCommand(add, conn);

                command.ExecuteNonQuery();
            }

            conn.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            if (comboBoxProgressPayment.SelectedItem.ToString() == "INDIVIDUAL" || comboBoxProgressPayment.SelectedItem.ToString() == "PRODUCT")
            {
                if(textBoxCoefficient.Text.ToString().Length == 0)
                {
                    MessageBox.Show("‘Please complete all progress payment type 'B2B', 'B2C', 'LFU', 'AUTOMOTIVE', 'INDIVIDUAL' and 'PRODUCT entries.", "Error");
                }
                else
                {
                    SaveInfoToDatabase();
                }
            }
            else
            {
                if(radioButtonFile.Checked == true || radioButtonParcel.Checked == true)
                {
                    if(textBoxMinValue.Text.ToString().Length == 0 || textBoxMaxValue.Text.ToString().Length == 0 || textBoxCoefficient.Text.ToString().Length == 0)
                    {
                        MessageBox.Show("Please complete all progress payment type 'B2B', 'B2C', 'LFU', 'AUTOMOTIVE', 'INDIVIDUAL' and 'PRODUCT entries.", "Error");
                    }
                    else
                    {
                        SaveInfoToDatabase();
                    }
                }
                else
                {
                    MessageBox.Show("Please complete the 'B2B', 'B2C', 'LFU', 'AUTOMOTIVE' entries.", "Error");
                }
            }
            
        }

        public void SaveInfoToDatagridview()
        {
            string progress_type = comboBoxProgressPayment.SelectedItem.ToString();
            int minValue = 0;
            int maxValue = 999;
            int coefficient = int.Parse(textBoxCoefficient.Text);

            string type = "";
            bool isChecked = radioButtonFile.Checked;
            if (isChecked)
                type = radioButtonFile.Text;
            else
                type = radioButtonParcel.Text;


            if (progress_type == "INDIVIDUAL" || progress_type == "PRODUCT")
            {
                minValue = 0;
                maxValue = 999;
                
            }
            else
            {
                if(System.Text.RegularExpressions.Regex.IsMatch(textBoxMinValue.Text, "[^0-9]"))
                {
                    minValue = int.Parse(textBoxMinValue.Text.Replace("+", ""));
                    maxValue = 999;
                }
                else
                {
                    minValue = int.Parse(textBoxMinValue.Text);
                    maxValue = int.Parse(textBoxMaxValue.Text);
                }
                
            }


            dataGridView1.Rows.Add(progress_type, type, minValue, maxValue, coefficient);
        }

        private void PrintDatagridviewRecordNumber()
        {
            string dataGridViewRecordNumber = (dataGridView1.RowCount - 1).ToString();
            labelRowCount.Text = "Count: " + dataGridViewRecordNumber;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxProgressPayment.SelectedItem.ToString() == "INDIVIDUAL" || comboBoxProgressPayment.SelectedItem.ToString() == "PRODUCT")
            {
                if(textBoxCoefficient.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Please fill in the Coefficient(%) field.", "Error");
                }
                else
                {
                    SaveInfoToDatagridview();
                    PrintDatagridviewRecordNumber();
                    
                }
            }
            else
            {
                if(textBoxMinValue.Text.ToString().Length == 0 || textBoxMaxValue.Text.ToString().Length == 0 || textBoxCoefficient.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Please complete all.", "Error");
                }
                else
                {
                    SaveInfoToDatagridview();
                    PrintDatagridviewRecordNumber();
                    
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {        
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                PrintDatagridviewRecordNumber();
            }
            else
            {
                MessageBox.Show("Select the progress payment values you want to delete.", "Error");
            }
        }

        public void AddExcell()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                int StartCol = 1;
                int StartRow = 1;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.StackTrace);
            }
        }


        private void buttonExceleAktar_Click(object sender, EventArgs e)
        {
           AddExcell();
        }

        private void checkBoxTümünüSeç_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
            {
                dataGridView1.SelectAll();
            }
            else
            {
                dataGridView1.ClearSelection();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            comboBoxProgressPayment.SelectedItem = selectedRow.Cells[0].Value.ToString();
            textBoxMinValue.Text = selectedRow.Cells[2].Value.ToString();
            textBoxMaxValue.Text = selectedRow.Cells[3].Value.ToString();
            textBoxCoefficient.Text = selectedRow.Cells[4].Value.ToString();
        }

        //private void compare()
        //{
        //    try
        //    {
        //        string htipi = comboBoxHakedisTipi.SelectedItem.ToString();
        //        string minDeger = textBoxMinDeger.Text;
        //        string maxDeger = textBoxMaxDeger.Text;
        //        string katsayi = textBoxKatsayi.Text;

        //        for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //        {
        //            if ((dataGridView1.Rows[i].Cells["HTipi"].Value.ToString() == htipi) && (dataGridView1.Rows[i].Cells["Min"].Value.ToString() == minDeger))
        //            {
        //                if ((dataGridView1.Rows[i].Cells[2].Value.ToString() == maxDeger) && (dataGridView1.Rows[3].Cells[5].Value.ToString() == katsayi))
        //                {
        //                    MessageBox.Show("you cannot put same value", "error");
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
