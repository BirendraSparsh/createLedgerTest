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
            this.txtLedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLedName
            // 
            this.txtLedName.Location = new System.Drawing.Point(252, 38);
            this.txtLedName.Name = "txtLedName";
            this.txtLedName.Size = new System.Drawing.Size(159, 20);
            this.txtLedName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(127, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ledger Name";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(277, 98);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 5;
            this.btnAlter.Text = "Delete";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 258);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.txtLedName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlter;
    }
}