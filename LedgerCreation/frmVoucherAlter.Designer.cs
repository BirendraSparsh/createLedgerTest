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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVCHNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVCHType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewNarr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voucher Alteration";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(186, 202);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 1;
            this.btnAlter.Text = "Alter";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "VCH No.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtVCHNo
            // 
            this.txtVCHNo.Location = new System.Drawing.Point(163, 44);
            this.txtVCHNo.Name = "txtVCHNo";
            this.txtVCHNo.Size = new System.Drawing.Size(158, 20);
            this.txtVCHNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(57, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // txtVCHType
            // 
            this.txtVCHType.Location = new System.Drawing.Point(163, 97);
            this.txtVCHType.Name = "txtVCHType";
            this.txtVCHType.Size = new System.Drawing.Size(158, 20);
            this.txtVCHType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(57, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "VCH Type";
            // 
            // txtNewNarr
            // 
            this.txtNewNarr.Location = new System.Drawing.Point(163, 125);
            this.txtNewNarr.Name = "txtNewNarr";
            this.txtNewNarr.Size = new System.Drawing.Size(158, 20);
            this.txtNewNarr.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(57, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Naration";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(163, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(158, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(57, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "New Date";
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDate.Location = new System.Drawing.Point(163, 154);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(158, 20);
            this.dtpNewDate.TabIndex = 11;
            // 
            // frmVoucherAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtNewNarr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVCHType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVCHNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVoucherAlter";
            this.Text = "Voucher alteration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVCHNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVCHType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewNarr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
    }
}