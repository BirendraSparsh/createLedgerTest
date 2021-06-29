namespace LedgerCreation
{
    partial class frmExcelToXml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtJsonFile1 = new System.Windows.Forms.TextBox();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.btnLoadJsonFile = new System.Windows.Forms.Button();
            this.btnConvertToXml = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnMapRecord = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblCombobox1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(411, 56);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load Excel data to Grid";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(970, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(300, 56);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(40, 58);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(220, 20);
            this.txtFile.TabIndex = 4;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 292);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(552, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // txtJsonFile1
            // 
            this.txtJsonFile1.Location = new System.Drawing.Point(35, 256);
            this.txtJsonFile1.Name = "txtJsonFile1";
            this.txtJsonFile1.Size = new System.Drawing.Size(189, 20);
            this.txtJsonFile1.TabIndex = 18;
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Location = new System.Drawing.Point(258, 254);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(130, 23);
            this.btnBrowseTemplate.TabIndex = 17;
            this.btnBrowseTemplate.Text = "Browse Template";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.btnBrowseTemplate_Click);
            // 
            // btnLoadJsonFile
            // 
            this.btnLoadJsonFile.Location = new System.Drawing.Point(420, 254);
            this.btnLoadJsonFile.Name = "btnLoadJsonFile";
            this.btnLoadJsonFile.Size = new System.Drawing.Size(130, 23);
            this.btnLoadJsonFile.TabIndex = 16;
            this.btnLoadJsonFile.Text = "Load Template";
            this.btnLoadJsonFile.UseVisualStyleBackColor = true;
            this.btnLoadJsonFile.Click += new System.EventHandler(this.btnLoadJsonFile_Click);
            // 
            // btnConvertToXml
            // 
            this.btnConvertToXml.Location = new System.Drawing.Point(855, 449);
            this.btnConvertToXml.Name = "btnConvertToXml";
            this.btnConvertToXml.Size = new System.Drawing.Size(81, 23);
            this.btnConvertToXml.TabIndex = 19;
            this.btnConvertToXml.Text = "Create";
            this.btnConvertToXml.UseVisualStyleBackColor = true;
            this.btnConvertToXml.Click += new System.EventHandler(this.btnConvertToXml_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(618, 292);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(387, 150);
            this.dgv.TabIndex = 20;
            // 
            // btnMapRecord
            // 
            this.btnMapRecord.Location = new System.Drawing.Point(618, 448);
            this.btnMapRecord.Name = "btnMapRecord";
            this.btnMapRecord.Size = new System.Drawing.Size(173, 23);
            this.btnMapRecord.TabIndex = 21;
            this.btnMapRecord.Text = "Show record in the Grid";
            this.btnMapRecord.UseVisualStyleBackColor = true;
            this.btnMapRecord.Click += new System.EventHandler(this.btnMapRecord_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(32, 484);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 23;
            this.lblMessage.Text = "Message";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(878, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(489, 5);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(140, 23);
            this.lblFormTitle.TabIndex = 49;
            this.lblFormTitle.Text = "Master-Ledger";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombobox1
            // 
            this.lblCombobox1.AutoSize = true;
            this.lblCombobox1.Location = new System.Drawing.Point(45, 31);
            this.lblCombobox1.Name = "lblCombobox1";
            this.lblCombobox1.Size = new System.Drawing.Size(71, 13);
            this.lblCombobox1.TabIndex = 51;
            this.lblCombobox1.Text = "Ledger Name";
            this.lblCombobox1.Click += new System.EventHandler(this.lblCombobox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmExcelToXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 506);
            this.Controls.Add(this.lblCombobox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnMapRecord);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnConvertToXml);
            this.Controls.Add(this.txtJsonFile1);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.btnLoadJsonFile);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcelToXml";
            this.Text = "ExcelToXmlToTally";
            this.Load += new System.EventHandler(this.frmExcelToXmlSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtJsonFile1;
        private System.Windows.Forms.Button btnBrowseTemplate;
        private System.Windows.Forms.Button btnLoadJsonFile;
        private System.Windows.Forms.Button btnConvertToXml;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnMapRecord;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblCombobox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}