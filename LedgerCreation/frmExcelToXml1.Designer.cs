namespace LedgerCreation
{
    partial class frmExcelToXml1
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboTally = new System.Windows.Forms.ComboBox();
            this.comboExcel = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnLoadJsonFile = new System.Windows.Forms.Button();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtJsonFile1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnConvertToXml = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(33, 13);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(220, 20);
            this.txtFile.TabIndex = 0;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(277, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(623, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(370, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Excel data to Grid";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // comboTally
            // 
            this.comboTally.FormattingEnabled = true;
            this.comboTally.Items.AddRange(new object[] {
            "NAME",
            "PARENT",
            "OPENINGBALANCE",
            "ISBILLWISEON"});
            this.comboTally.Location = new System.Drawing.Point(115, 211);
            this.comboTally.Name = "comboTally";
            this.comboTally.Size = new System.Drawing.Size(121, 21);
            this.comboTally.TabIndex = 4;
            // 
            // comboExcel
            // 
            this.comboExcel.FormattingEnabled = true;
            this.comboExcel.Location = new System.Drawing.Point(347, 211);
            this.comboExcel.Name = "comboExcel";
            this.comboExcel.Size = new System.Drawing.Size(121, 21);
            this.comboExcel.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(495, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 248);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(619, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Template file path ";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(109, 413);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(188, 20);
            this.txtFilePath.TabIndex = 9;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(513, 410);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(98, 23);
            this.btnSaveTemplate.TabIndex = 10;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnLoadJsonFile
            // 
            this.btnLoadJsonFile.Location = new System.Drawing.Point(486, 445);
            this.btnLoadJsonFile.Name = "btnLoadJsonFile";
            this.btnLoadJsonFile.Size = new System.Drawing.Size(130, 23);
            this.btnLoadJsonFile.TabIndex = 11;
            this.btnLoadJsonFile.Text = "Load Template";
            this.btnLoadJsonFile.UseVisualStyleBackColor = true;
            this.btnLoadJsonFile.Click += new System.EventHandler(this.btnLoadJsonFile_Click);
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Location = new System.Drawing.Point(340, 446);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(130, 23);
            this.btnBrowseTemplate.TabIndex = 13;
            this.btnBrowseTemplate.Text = "Browse Template";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.btnBrowseTemplate_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(306, 411);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(25, 23);
            this.btnPath.TabIndex = 14;
            this.btnPath.Text = "...";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtJsonFile1
            // 
            this.txtJsonFile1.Location = new System.Drawing.Point(109, 447);
            this.txtJsonFile1.Name = "txtJsonFile1";
            this.txtJsonFile1.Size = new System.Drawing.Size(188, 20);
            this.txtJsonFile1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "FechColumnDataOfgrid2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(653, 71);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(325, 289);
            this.dgv.TabIndex = 17;
            // 
            // btnConvertToXml
            // 
            this.btnConvertToXml.Location = new System.Drawing.Point(341, 484);
            this.btnConvertToXml.Name = "btnConvertToXml";
            this.btnConvertToXml.Size = new System.Drawing.Size(130, 23);
            this.btnConvertToXml.TabIndex = 18;
            this.btnConvertToXml.Text = "Create Ledger";
            this.btnConvertToXml.UseVisualStyleBackColor = true;
            this.btnConvertToXml.Click += new System.EventHandler(this.btnConvertToXml_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "file Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(398, 412);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(101, 20);
            this.txtFileName.TabIndex = 21;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 514);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 22;
            this.lblMessage.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tally Element";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Excel Header";
            // 
            // frmExcelToXml1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvertToXml);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJsonFile1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.btnLoadJsonFile);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboExcel);
            this.Controls.Add(this.comboTally);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcelToXml1";
            this.Text = "Create Ledger from Excel File";
            this.Load += new System.EventHandler(this.frmExcelToXml1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboTally;
        private System.Windows.Forms.ComboBox comboExcel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnLoadJsonFile;
        private System.Windows.Forms.Button btnBrowseTemplate;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtJsonFile1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnConvertToXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}