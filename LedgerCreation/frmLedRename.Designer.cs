namespace LedgerCreation
{
    partial class frmLedRename
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
            this.btnAlter = new System.Windows.Forms.Button();
            this.txtNewLedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.txtNewLedName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLedName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 269);
            this.panel1.TabIndex = 5;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(234, 161);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 9;
            this.btnAlter.Text = "Alter";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // txtNewLedName
            // 
            this.txtNewLedName.Location = new System.Drawing.Point(204, 104);
            this.txtNewLedName.Name = "txtNewLedName";
            this.txtNewLedName.Size = new System.Drawing.Size(159, 20);
            this.txtNewLedName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(71, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Ledger Name";
            // 
            // txtLedName
            // 
            this.txtLedName.Location = new System.Drawing.Point(204, 69);
            this.txtLedName.Name = "txtLedName";
            this.txtLedName.Size = new System.Drawing.Size(159, 20);
            this.txtLedName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(74, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ledger Name";
            // 
            // frmLedRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLedRename";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.TextBox txtNewLedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLedName;
        private System.Windows.Forms.Label label1;

    }
}