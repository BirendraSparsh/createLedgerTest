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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcelToTally = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBrows2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            //this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Excel to XML";
            // 
            // btnExcelToTally
            // 
            this.btnExcelToTally.Location = new System.Drawing.Point(477, 7);
            this.btnExcelToTally.Name = "btnExcelToTally";
            this.btnExcelToTally.Size = new System.Drawing.Size(173, 23);
            this.btnExcelToTally.TabIndex = 1;
            this.btnExcelToTally.Text = "Convert Excel to Tally";
            this.btnExcelToTally.UseVisualStyleBackColor = true;
            //this.btnExcelToTally.Click += new System.EventHandler(this.btnExcelToTally_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 135);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(334, 10);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(98, 23);
            this.btnBrows.TabIndex = 4;
            this.btnBrows.Text = "Browse";
            this.btnBrows.UseVisualStyleBackColor = true;
           // this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ledger",
            "Groups",
            "Openning Balance"});
            this.comboBox1.Location = new System.Drawing.Point(102, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
           // this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(257, 241);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(421, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
         //   this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(409, 121);
            this.dataGridView2.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save as json file";
            this.btnSave.UseVisualStyleBackColor = true;
            //this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(106, 150);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(184, 20);
            this.txtFileName.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnBrows);
            this.panel1.Controls.Add(this.btnExcelToTally);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 202);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnXML);
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btnBrows2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Location = new System.Drawing.Point(12, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 266);
            this.panel2.TabIndex = 19;
            //this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(301, 225);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(131, 23);
            this.btnXML.TabIndex = 22;
            this.btnXML.Text = "Convert To XML";
            this.btnXML.UseVisualStyleBackColor = true;
           // this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(370, 185);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(63, 23);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Load";
            this.btnUpload.UseVisualStyleBackColor = true;
            //this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 19;
            //this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnBrows2
            // 
            this.btnBrows2.Location = new System.Drawing.Point(301, 184);
            this.btnBrows2.Name = "btnBrows2";
            this.btnBrows2.Size = new System.Drawing.Size(63, 23);
            this.btnBrows2.TabIndex = 20;
            this.btnBrows2.Text = "Browse";
            this.btnBrows2.UseVisualStyleBackColor = true;
            //this.btnBrows2.Click += new System.EventHandler(this.btnBrows2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select Template";
            // 
            // frmExcelToXml
            // 
           // this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          //  this.ClientSize = new System.Drawing.Size(1030, 542);
          //  this.Controls.Add(this.panel2);
           // this.Controls.Add(this.panel1);
           // this.Controls.Add(this.button1);
           // this.Controls.Add(this.btnAdd);
           // this.Controls.Add(this.comboBox2);
           // this.Controls.Add(this.comboBox1);
           // this.Controls.Add(this.label1);
           // this.Name = "frmExcelToXml";
           // this.Text = "Convert Excel Data To XML";
           // this.Load += new System.EventHandler(this.frmExcelToXml_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
           // this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcelToTally;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBrows2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Label label3;
    }
}