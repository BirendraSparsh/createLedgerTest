namespace LedgerCreation
{
    partial class frmODBC_Conn
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
            this.button1 = new System.Windows.Forms.Button();
            this.TallyGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TallyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ConnectTally by ODBC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TallyGridView
            // 
            this.TallyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TallyGridView.Location = new System.Drawing.Point(12, 61);
            this.TallyGridView.Name = "TallyGridView";
            this.TallyGridView.Size = new System.Drawing.Size(828, 150);
            this.TallyGridView.TabIndex = 1;
            this.TallyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TallyGridView_CellContentClick);
            // 
            // frmODBC_Conn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 261);
            this.Controls.Add(this.TallyGridView);
            this.Controls.Add(this.button1);
            this.Name = "frmODBC_Conn";
            this.Text = "frmODBC_Conn";
            ((System.ComponentModel.ISupportInitialize)(this.TallyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TallyGridView;
    }
}