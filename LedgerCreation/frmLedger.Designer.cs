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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboParent = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGetLedger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboParent);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnGetLedger);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtOpeningBalance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtParentName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLedgerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 253);
            this.panel1.TabIndex = 10;
            // 
            // comboParent
            // 
            this.comboParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParent.FormattingEnabled = true;
            this.comboParent.Location = new System.Drawing.Point(173, 101);
            this.comboParent.Name = "comboParent";
            this.comboParent.Size = new System.Drawing.Size(145, 21);
            this.comboParent.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(377, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 18;
            // 
            // btnGetLedger
            // 
            this.btnGetLedger.Location = new System.Drawing.Point(377, 35);
            this.btnGetLedger.Name = "btnGetLedger";
            this.btnGetLedger.Size = new System.Drawing.Size(120, 23);
            this.btnGetLedger.TabIndex = 17;
            this.btnGetLedger.Text = "Get Ledgers";
            this.btnGetLedger.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "CREATE LEDGER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Location = new System.Drawing.Point(173, 146);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(145, 20);
            this.txtOpeningBalance.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Opening Balance";
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(58, 24);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(26, 20);
            this.txtParentName.TabIndex = 13;
            this.txtParentName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parent";
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.Location = new System.Drawing.Point(173, 56);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(145, 20);
            this.txtLedgerName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ledger Name";
            // 
            // frmLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ledger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboParent;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGetLedger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.Label label1;

    }
}

