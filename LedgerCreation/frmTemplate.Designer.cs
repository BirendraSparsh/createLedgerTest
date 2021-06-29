namespace LedgerCreation
{
    partial class frmTemplate
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboExcel = new System.Windows.Forms.ComboBox();
            this.comboTally = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTemplateTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCombobox1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboTally1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Excel Header";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tally Element";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(839, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboExcel
            // 
            this.comboExcel.FormattingEnabled = true;
            this.comboExcel.Location = new System.Drawing.Point(698, 255);
            this.comboExcel.Name = "comboExcel";
            this.comboExcel.Size = new System.Drawing.Size(121, 21);
            this.comboExcel.TabIndex = 30;
            // 
            // comboTally
            // 
            this.comboTally.FormattingEnabled = true;
            this.comboTally.Location = new System.Drawing.Point(203, 260);
            this.comboTally.Name = "comboTally";
            this.comboTally.Size = new System.Drawing.Size(121, 21);
            this.comboTally.TabIndex = 29;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(444, 64);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 23);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Load Excel data to Grid";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(830, 139);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(363, 65);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 26;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(91, 67);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(240, 20);
            this.txtFile.TabIndex = 25;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(468, 458);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(101, 20);
            this.txtFileName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "file Name";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(376, 457);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(25, 23);
            this.btnPath.TabIndex = 38;
            this.btnPath.Text = "...";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(583, 456);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(98, 23);
            this.btnSaveTemplate.TabIndex = 37;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(179, 459);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(188, 20);
            this.txtFilePath.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Template file path ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(86, 294);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(828, 150);
            this.dataGridView2.TabIndex = 34;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(79, 520);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 43;
            this.lblMessage.Text = "Message";
            // 
            // lblTemplateTitle
            // 
            this.lblTemplateTitle.AutoSize = true;
            this.lblTemplateTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTemplateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplateTitle.Location = new System.Drawing.Point(438, 5);
            this.lblTemplateTitle.Name = "lblTemplateTitle";
            this.lblTemplateTitle.Size = new System.Drawing.Size(69, 18);
            this.lblTemplateTitle.TabIndex = 44;
            this.lblTemplateTitle.Text = "Template";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCombobox1
            // 
            this.lblCombobox1.AutoSize = true;
            this.lblCombobox1.Location = new System.Drawing.Point(89, 42);
            this.lblCombobox1.Name = "lblCombobox1";
            this.lblCombobox1.Size = new System.Drawing.Size(83, 13);
            this.lblCombobox1.TabIndex = 46;
            this.lblCombobox1.Text = "Vouchers Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(790, 503);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboTally1
            // 
            this.comboTally1.FormattingEnabled = true;
            this.comboTally1.Location = new System.Drawing.Point(363, 260);
            this.comboTally1.Name = "comboTally1";
            this.comboTally1.Size = new System.Drawing.Size(154, 21);
            this.comboTally1.TabIndex = 48;
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 559);
            this.Controls.Add(this.comboTally1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCombobox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTemplateTitle);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboExcel);
            this.Controls.Add(this.comboTally);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTemplate";
            this.Text = "Template";
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboExcel;
        private System.Windows.Forms.ComboBox comboTally;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTemplateTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCombobox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboTally1;
    }
}