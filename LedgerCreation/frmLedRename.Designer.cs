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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLedName = new System.Windows.Forms.TextBox();
            this.txtNewLedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ledger Name";
            // 
            // txtLedName
            // 
            this.txtLedName.Location = new System.Drawing.Point(221, 61);
            this.txtLedName.Name = "txtLedName";
            this.txtLedName.Size = new System.Drawing.Size(159, 20);
            this.txtLedName.TabIndex = 1;
            // 
            // txtNewLedName
            // 
            this.txtNewLedName.Location = new System.Drawing.Point(221, 96);
            this.txtNewLedName.Name = "txtNewLedName";
            this.txtNewLedName.Size = new System.Drawing.Size(159, 20);
            this.txtNewLedName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(88, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Ledger Name";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(251, 153);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "Alter";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 285);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.txtNewLedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLedName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLedName;
        private System.Windows.Forms.TextBox txtNewLedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlter;
    }
}