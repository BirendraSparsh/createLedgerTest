﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedgerCreation
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        
       
        private void btnAlter_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmLedRename f = new frmLedRename();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

      

        private void btnCreate_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmLedger f = new frmLedger();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmLedDel f = new frmLedDel();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();

        }

        private void btnStockItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmStockItem f = new frmStockItem();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void btnRecVoucher_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmRecVoucher f = new frmRecVoucher();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void bkpAlter_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmVoucherAlter f = new frmVoucherAlter();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();

        }

      


    }
}
