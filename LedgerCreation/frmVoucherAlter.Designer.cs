namespace LedgerCreation
{
    partial class frmVoucherAlter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNewNarr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVCHType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVCHNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNewDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.txtNewNarr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVCHType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVCHNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(73, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 309);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDate.Location = new System.Drawing.Point(208, 188);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(158, 20);
            this.dtpNewDate.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(102, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "New Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(208, 103);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(158, 20);
            this.dtpDate.TabIndex = 17;
            // 
            // txtNewNarr
            // 
            this.txtNewNarr.Location = new System.Drawing.Point(208, 159);
            this.txtNewNarr.Name = "txtNewNarr";
            this.txtNewNarr.Size = new System.Drawing.Size(158, 20);
            this.txtNewNarr.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(102, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Naration";
            // 
            // txtVCHType
            // 
            this.txtVCHType.Location = new System.Drawing.Point(208, 131);
            this.txtVCHType.Name = "txtVCHType";
            this.txtVCHType.Size = new System.Drawing.Size(158, 20);
            this.txtVCHType.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(102, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "VCH Type";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(102, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date";
            // 
            // txtVCHNo
            // 
            this.txtVCHNo.Location = new System.Drawing.Point(208, 78);
            this.txtVCHNo.Name = "txtVCHNo";
            this.txtVCHNo.Size = new System.Drawing.Size(158, 20);
            this.txtVCHNo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(102, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "VCH No.";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(243, 236);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 13;
            this.btnAlter.Text = "Alter";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Voucher Alteration";
            // 
            // frmVoucherAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 333);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVoucherAlter";
            this.Text = "Voucher alteration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNewNarr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVCHType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVCHNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label label1;

    }
}