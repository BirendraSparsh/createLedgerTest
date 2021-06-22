namespace LedgerCreation
{
    partial class frmDashBoard
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
            this.btnVoucherAlter = new System.Windows.Forms.Button();
            this.btnRecVoucher = new System.Windows.Forms.Button();
            this.btnStockItem = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDayBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDayBook);
            this.panel1.Controls.Add(this.btnVoucherAlter);
            this.panel1.Controls.Add(this.btnRecVoucher);
            this.panel1.Controls.Add(this.btnStockItem);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 418);
            this.panel1.TabIndex = 0;
            // 
            // btnVoucherAlter
            // 
            this.btnVoucherAlter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVoucherAlter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVoucherAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucherAlter.ForeColor = System.Drawing.Color.White;
            this.btnVoucherAlter.Location = new System.Drawing.Point(11, 207);
            this.btnVoucherAlter.Name = "btnVoucherAlter";
            this.btnVoucherAlter.Size = new System.Drawing.Size(164, 23);
            this.btnVoucherAlter.TabIndex = 6;
            this.btnVoucherAlter.Text = "Alter Voucher";
            this.btnVoucherAlter.UseVisualStyleBackColor = false;
            this.btnVoucherAlter.Click += new System.EventHandler(this.bkpAlter_Click);
            // 
            // btnRecVoucher
            // 
            this.btnRecVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecVoucher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecVoucher.ForeColor = System.Drawing.Color.White;
            this.btnRecVoucher.Location = new System.Drawing.Point(11, 170);
            this.btnRecVoucher.Name = "btnRecVoucher";
            this.btnRecVoucher.Size = new System.Drawing.Size(164, 23);
            this.btnRecVoucher.TabIndex = 5;
            this.btnRecVoucher.Text = "Receipt Voucher";
            this.btnRecVoucher.UseVisualStyleBackColor = false;
            this.btnRecVoucher.Click += new System.EventHandler(this.btnRecVoucher_Click);
            // 
            // btnStockItem
            // 
            this.btnStockItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStockItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStockItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockItem.ForeColor = System.Drawing.Color.White;
            this.btnStockItem.Location = new System.Drawing.Point(11, 132);
            this.btnStockItem.Name = "btnStockItem";
            this.btnStockItem.Size = new System.Drawing.Size(164, 23);
            this.btnStockItem.TabIndex = 4;
            this.btnStockItem.Text = "Stock Items";
            this.btnStockItem.UseVisualStyleBackColor = false;
            this.btnStockItem.Click += new System.EventHandler(this.btnStockItem_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(11, 91);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(164, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete Ledger";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.ForeColor = System.Drawing.Color.White;
            this.btnAlter.Location = new System.Drawing.Point(11, 51);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(164, 23);
            this.btnAlter.TabIndex = 2;
            this.btnAlter.Text = "Alter Ledger";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(11, 11);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(164, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Ledger";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 418);
            this.panel2.TabIndex = 1;
            // 
            // btnDayBook
            // 
            this.btnDayBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDayBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDayBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDayBook.ForeColor = System.Drawing.Color.White;
            this.btnDayBook.Location = new System.Drawing.Point(5, 240);
            this.btnDayBook.Name = "btnDayBook";
            this.btnDayBook.Size = new System.Drawing.Size(164, 23);
            this.btnDayBook.TabIndex = 7;
            this.btnDayBook.Text = "Day Book";
            this.btnDayBook.UseVisualStyleBackColor = false;
            this.btnDayBook.Click += new System.EventHandler(this.btnDayBook_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash Board";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnStockItem;
        private System.Windows.Forms.Button btnRecVoucher;
        private System.Windows.Forms.Button btnVoucherAlter;
        private System.Windows.Forms.Button btnDayBook;
    }
}