namespace LedgerCreation
{
    partial class frmLedDel
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
            this.txtLedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.txtLedName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(102, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 223);
            this.panel1.TabIndex = 6;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(215, 130);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 8;
            this.btnAlter.Text = "Delete";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // txtLedName
            // 
            this.txtLedName.Location = new System.Drawing.Point(190, 70);
            this.txtLedName.Name = "txtLedName";
            this.txtLedName.Size = new System.Drawing.Size(159, 20);
            this.txtLedName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ledger Name";
            // 
            // frmLedDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 258);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLedDel";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.TextBox txtLedName;
        private System.Windows.Forms.Label label1;

    }
}