using System;
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

        private void btnDayBook_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmDayBook f = new frmDayBook();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void btnExcelToXml_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmExcelToXml1 f = new frmExcelToXml1();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void createLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmLedger f = new frmLedger();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void alterLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmLedRename f = new frmLedRename();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void deleteLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmLedDel f = new frmLedDel();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void createReceiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmRecVoucher f = new frmRecVoucher();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void alterVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmVoucherAlter f = new frmVoucherAlter();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void stockItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmStockItem f = new frmStockItem();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void dayBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmDayBook f = new frmDayBook();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
            
        }

        private void templateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void templateVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMenu.MenuID = enmMenu.TemplateVoucher.ToString();
         
            panel2.Controls.Clear();
            frmTemplate f = new frmTemplate();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void templateMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            clsMenu.MenuID= enmMenu.TemplateMaster.ToString(); // set menu id
      
           // clsMenu.
            panel2.Controls.Clear();
            frmTemplate f = new frmTemplate();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
             
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMenu.MenuID = enmMenu.Master.ToString();  // set menuId value to Master

            // set menu
            panel2.Controls.Clear();
            frmExcelToXml f = new frmExcelToXml();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();

        }

        private void voucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMenu.MenuID = enmMenu.Voucher.ToString(); // set menu id  value
            // set menu
            panel2.Controls.Clear();
            frmExcelToXml f = new frmExcelToXml();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

       

       

      

      


    }
}
