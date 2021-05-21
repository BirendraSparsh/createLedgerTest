namespace LedgerCreation
{
    partial class frmLedger
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
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboParent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ledger Name";
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.Location = new System.Drawing.Point(127, 44);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(145, 20);
            this.txtLedgerName.TabIndex = 1;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(12, 12);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(26, 20);
            this.txtParentName.TabIndex = 3;
            this.txtParentName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parent";
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Location = new System.Drawing.Point(127, 134);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(145, 20);
            this.txtOpeningBalance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opening Balance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREATE LEDGER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Get Ledgers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(351, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 8;
            // 
            // comboParent
            // 
            this.comboParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParent.FormattingEnabled = true;
            this.comboParent.Location = new System.Drawing.Point(127, 89);
            this.comboParent.Name = "comboParent";
            this.comboParent.Size = new System.Drawing.Size(145, 21);
            this.comboParent.TabIndex = 9;
            // 
            // frmLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 300);
            this.Controls.Add(this.comboParent);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOpeningBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLedgerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ledger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboParent;
    }
}

