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
            this.btnExcelToXml = new System.Windows.Forms.Button();
            this.btnDayBook = new System.Windows.Forms.Button();
            this.btnVoucherAlter = new System.Windows.Forms.Button();
            this.btnRecVoucher = new System.Windows.Forms.Button();
            this.btnStockItem = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.integrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangaeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReceiptVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncronisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExcelToXml);
            this.panel1.Controls.Add(this.btnDayBook);
            this.panel1.Controls.Add(this.btnVoucherAlter);
            this.panel1.Controls.Add(this.btnRecVoucher);
            this.panel1.Controls.Add(this.btnStockItem);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(7, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 177);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // btnExcelToXml
            // 
            this.btnExcelToXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcelToXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcelToXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelToXml.ForeColor = System.Drawing.Color.White;
            this.btnExcelToXml.Location = new System.Drawing.Point(5, 242);
            this.btnExcelToXml.Name = "btnExcelToXml";
            this.btnExcelToXml.Size = new System.Drawing.Size(164, 23);
            this.btnExcelToXml.TabIndex = 8;
            this.btnExcelToXml.Text = "Create Ledger by Excel file";
            this.btnExcelToXml.UseVisualStyleBackColor = false;
            this.btnExcelToXml.Click += new System.EventHandler(this.btnExcelToXml_Click);
            // 
            // btnDayBook
            // 
            this.btnDayBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDayBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDayBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDayBook.ForeColor = System.Drawing.Color.White;
            this.btnDayBook.Location = new System.Drawing.Point(3, 283);
            this.btnDayBook.Name = "btnDayBook";
            this.btnDayBook.Size = new System.Drawing.Size(164, 23);
            this.btnDayBook.TabIndex = 7;
            this.btnDayBook.Text = "Day Book";
            this.btnDayBook.UseVisualStyleBackColor = false;
            this.btnDayBook.Click += new System.EventHandler(this.btnDayBook_Click);
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
            this.btnRecVoucher.Text = "Create Receipt Voucher";
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
            this.btnStockItem.Text = "Stock Items Display";
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
            this.panel2.Location = new System.Drawing.Point(7, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 560);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrateToolStripMenuItem,
            this.mangaeToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.syncronisationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // integrateToolStripMenuItem
            // 
            this.integrateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.integrateToolStripMenuItem.Name = "integrateToolStripMenuItem";
            this.integrateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.integrateToolStripMenuItem.Text = "Integrate";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterToolStripMenuItem,
            this.voucherToolStripMenuItem,
            this.templateMasterToolStripMenuItem,
            this.templateVoucherToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // MasterToolStripMenuItem
            // 
            this.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem";
            this.MasterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.MasterToolStripMenuItem.Text = "Master";
            this.MasterToolStripMenuItem.Click += new System.EventHandler(this.MasterToolStripMenuItem_Click);
            // 
            // voucherToolStripMenuItem
            // 
            this.voucherToolStripMenuItem.Name = "voucherToolStripMenuItem";
            this.voucherToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.voucherToolStripMenuItem.Text = "Voucher";
            this.voucherToolStripMenuItem.Click += new System.EventHandler(this.voucherToolStripMenuItem_Click);
            // 
            // templateMasterToolStripMenuItem
            // 
            this.templateMasterToolStripMenuItem.Name = "templateMasterToolStripMenuItem";
            this.templateMasterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.templateMasterToolStripMenuItem.Text = "Template - Master";
            this.templateMasterToolStripMenuItem.Click += new System.EventHandler(this.templateMasterToolStripMenuItem_Click);
            // 
            // templateVoucherToolStripMenuItem
            // 
            this.templateVoucherToolStripMenuItem.Name = "templateVoucherToolStripMenuItem";
            this.templateVoucherToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.templateVoucherToolStripMenuItem.Text = "Template - Voucher";
            this.templateVoucherToolStripMenuItem.Click += new System.EventHandler(this.templateVoucherToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // mangaeToolStripMenuItem
            // 
            this.mangaeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLedgerToolStripMenuItem,
            this.alterLedgerToolStripMenuItem,
            this.deleteLedgerToolStripMenuItem,
            this.createReceiptVoucherToolStripMenuItem,
            this.alterVoucherToolStripMenuItem});
            this.mangaeToolStripMenuItem.Name = "mangaeToolStripMenuItem";
            this.mangaeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.mangaeToolStripMenuItem.Text = "Mangae";
            // 
            // createLedgerToolStripMenuItem
            // 
            this.createLedgerToolStripMenuItem.Name = "createLedgerToolStripMenuItem";
            this.createLedgerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createLedgerToolStripMenuItem.Text = "Create Ledger";
            this.createLedgerToolStripMenuItem.Click += new System.EventHandler(this.createLedgerToolStripMenuItem_Click);
            // 
            // alterLedgerToolStripMenuItem
            // 
            this.alterLedgerToolStripMenuItem.Name = "alterLedgerToolStripMenuItem";
            this.alterLedgerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.alterLedgerToolStripMenuItem.Text = "Alter Ledger";
            this.alterLedgerToolStripMenuItem.Click += new System.EventHandler(this.alterLedgerToolStripMenuItem_Click);
            // 
            // deleteLedgerToolStripMenuItem
            // 
            this.deleteLedgerToolStripMenuItem.Name = "deleteLedgerToolStripMenuItem";
            this.deleteLedgerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.deleteLedgerToolStripMenuItem.Text = "Delete Ledger";
            this.deleteLedgerToolStripMenuItem.Click += new System.EventHandler(this.deleteLedgerToolStripMenuItem_Click);
            // 
            // createReceiptVoucherToolStripMenuItem
            // 
            this.createReceiptVoucherToolStripMenuItem.Name = "createReceiptVoucherToolStripMenuItem";
            this.createReceiptVoucherToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createReceiptVoucherToolStripMenuItem.Text = "Create Receipt Voucher";
            this.createReceiptVoucherToolStripMenuItem.Click += new System.EventHandler(this.createReceiptVoucherToolStripMenuItem_Click);
            // 
            // alterVoucherToolStripMenuItem
            // 
            this.alterVoucherToolStripMenuItem.Name = "alterVoucherToolStripMenuItem";
            this.alterVoucherToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.alterVoucherToolStripMenuItem.Text = "Alter Voucher";
            this.alterVoucherToolStripMenuItem.Click += new System.EventHandler(this.alterVoucherToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockItemToolStripMenuItem,
            this.dayBooksToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // stockItemToolStripMenuItem
            // 
            this.stockItemToolStripMenuItem.Name = "stockItemToolStripMenuItem";
            this.stockItemToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.stockItemToolStripMenuItem.Text = "Stock Items";
            this.stockItemToolStripMenuItem.Click += new System.EventHandler(this.stockItemToolStripMenuItem_Click);
            // 
            // dayBooksToolStripMenuItem
            // 
            this.dayBooksToolStripMenuItem.Name = "dayBooksToolStripMenuItem";
            this.dayBooksToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dayBooksToolStripMenuItem.Text = "Day Books";
            this.dayBooksToolStripMenuItem.Click += new System.EventHandler(this.dayBooksToolStripMenuItem_Click);
            // 
            // syncronisationToolStripMenuItem
            // 
            this.syncronisationToolStripMenuItem.Name = "syncronisationToolStripMenuItem";
            this.syncronisationToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.syncronisationToolStripMenuItem.Text = "Sync";
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash Board";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnExcelToXml;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem integrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangaeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReceiptVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncronisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateVoucherToolStripMenuItem;
    }
}