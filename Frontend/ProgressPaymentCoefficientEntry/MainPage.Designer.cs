namespace Staj2Proje
{
    partial class MainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProgressType = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.labelCoefficient = new System.Windows.Forms.Label();
            this.comboBoxProgressPayment = new System.Windows.Forms.ComboBox();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.textBoxCoefficient = new System.Windows.Forms.TextBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonParcel = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExportToExcel = new System.Windows.Forms.Button();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProgressType
            // 
            this.labelProgressType.AutoSize = true;
            this.labelProgressType.Location = new System.Drawing.Point(30, 48);
            this.labelProgressType.Name = "labelProgressType";
            this.labelProgressType.Size = new System.Drawing.Size(199, 20);
            this.labelProgressType.TabIndex = 0;
            this.labelProgressType.Text = "Choose progress payment:";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(246, 48);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(107, 20);
            this.labelMinValue.TabIndex = 1;
            this.labelMinValue.Text = "Min Value (%)";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(442, 48);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(111, 20);
            this.labelMaxValue.TabIndex = 2;
            this.labelMaxValue.Text = "Max Value (%)";
            // 
            // labelCoefficient
            // 
            this.labelCoefficient.AutoSize = true;
            this.labelCoefficient.Location = new System.Drawing.Point(658, 48);
            this.labelCoefficient.Name = "labelCoefficient";
            this.labelCoefficient.Size = new System.Drawing.Size(113, 20);
            this.labelCoefficient.TabIndex = 3;
            this.labelCoefficient.Text = "Coefficient (%)";
            // 
            // comboBoxProgressPayment
            // 
            this.comboBoxProgressPayment.FormattingEnabled = true;
            this.comboBoxProgressPayment.Location = new System.Drawing.Point(34, 85);
            this.comboBoxProgressPayment.Name = "comboBoxProgressPayment";
            this.comboBoxProgressPayment.Size = new System.Drawing.Size(164, 28);
            this.comboBoxProgressPayment.TabIndex = 4;
            this.comboBoxProgressPayment.SelectedIndexChanged += new System.EventHandler(this.comboBoxHakedisTipi_SelectedIndexChanged);
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Location = new System.Drawing.Point(264, 87);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(64, 26);
            this.textBoxMinValue.TabIndex = 5;
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Location = new System.Drawing.Point(463, 85);
            this.textBoxMaxValue.MaxLength = 999;
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(64, 26);
            this.textBoxMaxValue.TabIndex = 6;
            // 
            // textBoxCoefficient
            // 
            this.textBoxCoefficient.Location = new System.Drawing.Point(673, 85);
            this.textBoxCoefficient.Name = "textBoxCoefficient";
            this.textBoxCoefficient.Size = new System.Drawing.Size(47, 26);
            this.textBoxCoefficient.TabIndex = 7;
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(34, 150);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(59, 24);
            this.radioButtonFile.TabIndex = 8;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonParcel
            // 
            this.radioButtonParcel.AutoSize = true;
            this.radioButtonParcel.Location = new System.Drawing.Point(119, 150);
            this.radioButtonParcel.Name = "radioButtonParcel";
            this.radioButtonParcel.Size = new System.Drawing.Size(78, 24);
            this.radioButtonParcel.TabIndex = 9;
            this.radioButtonParcel.TabStop = true;
            this.radioButtonParcel.Text = "Parcel";
            this.radioButtonParcel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(664, 196);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 34);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(662, 488);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 33);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(753, 220);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(350, 488);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 33);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonExportToExcel
            // 
            this.buttonExportToExcel.Location = new System.Drawing.Point(470, 488);
            this.buttonExportToExcel.Name = "buttonExportToExcel";
            this.buttonExportToExcel.Size = new System.Drawing.Size(188, 33);
            this.buttonExportToExcel.TabIndex = 14;
            this.buttonExportToExcel.Text = "Export to Excel";
            this.buttonExportToExcel.UseVisualStyleBackColor = true;
            this.buttonExportToExcel.Click += new System.EventHandler(this.buttonExceleAktar_Click);
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.Location = new System.Drawing.Point(30, 501);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(60, 20);
            this.labelRowCount.TabIndex = 15;
            this.labelRowCount.Text = "Count: ";
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(34, 206);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(99, 24);
            this.checkBoxSelectAll.TabIndex = 16;
            this.checkBoxSelectAll.Text = "Select all";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxTümünüSeç_CheckedChanged);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(535, 196);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(123, 34);
            this.buttonSort.TabIndex = 17;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 584);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.labelRowCount);
            this.Controls.Add(this.buttonExportToExcel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.radioButtonParcel);
            this.Controls.Add(this.radioButtonFile);
            this.Controls.Add(this.textBoxCoefficient);
            this.Controls.Add(this.textBoxMaxValue);
            this.Controls.Add(this.textBoxMinValue);
            this.Controls.Add(this.comboBoxProgressPayment);
            this.Controls.Add(this.labelCoefficient);
            this.Controls.Add(this.labelMaxValue);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.labelProgressType);
            this.Name = "Form1";
            this.Text = "Progress Payment Coefficient Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgressType;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.Label labelCoefficient;
        private System.Windows.Forms.ComboBox comboBoxProgressPayment;
        private System.Windows.Forms.TextBox textBoxMinValue;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.TextBox textBoxCoefficient;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonParcel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExportToExcel;
        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Button buttonSort;
    }
}

