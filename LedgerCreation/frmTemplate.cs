using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LedgerCreation
{
    public partial class frmTemplate : Form
    {
        public frmTemplate()
        {
            InitializeComponent();
        }

        private void radioLedger_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTemplate_Load(object sender, EventArgs e)
        {
            if (clsMenu.MenuID == enmMenu.TemplateMaster.ToString())  // for Template-Master
            {
                lblTemplateTitle.Text = "Template - Master";
                lblCombobox1.Text = "Masters";

                comboBox1.Items.Add("Ledger");
                comboBox1.Items.Add("Group");
                comboBox1.Items.Add("Stock Item");
                comboBox1.Items.Add("Stock Group");
            }
            else if (clsMenu.MenuID == enmMenu.TemplateVoucher.ToString()) // for Template-Voucher
            {
                lblTemplateTitle.Text = "Template - Voucher";
                lblCombobox1.Text = "Vouchers";

                comboBox1.Items.Add("Sales");
                comboBox1.Items.Add("Purchase");
                comboBox1.Items.Add("Receipt");
            }



          /*  lblTemplateTitle.Text = clsMenu.templateTitle;

            if (lblTemplateTitle.Text=="")

            lblCombobox1.Text = clsMenu.templateCombobox1Title;*/


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string day, day1 = "";
            string connStr = "";
            int i = 0;
            int oItem = 0;

            if (txtFile.Text != "")
            {
                // string filename = "Ledger Master.xlsx"; //Path.GetFileName((txtFile.Text).FileName).ToString(); //
                string fileExtension = ".xlsx"; //Path.GetExtension(file1.PostedFile.FileName);
                // string filelocation = @"C:\Users\Birendra Kumar\Desktop\Tally Integration Doc-23Mar-21\" + filename;
                string filelocation = txtFile.Text;
                if (fileExtension == ".xls" || fileExtension == ".XLS")
                {
                    connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filelocation + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";

                }
                else if (fileExtension == ".xlsx" || fileExtension == ".XLSX")
                {
                    connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filelocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                }

                OleDbConnection conn = new OleDbConnection(connStr);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = dtSheet.Rows[0]["table_name"].ToString();
                cmd.CommandText = "select * from [" + sheetName + "]";
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
                dataGridView1.DataSource = dt;



                // grdExcel.DataBind();

                //------fetching column name of datatables in combobox
                List<string> colNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
                comboExcel.DataSource = colNames;

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                oItem = dt.Rows.Count;
                oItem -= 1;


                XmlDocument doc = new XmlDocument();
                XmlDeclaration declaire = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                // -----------------------create root-----------------------------  
                XmlElement rootnode = doc.CreateElement("root");
                doc.InsertBefore(declaire, doc.DocumentElement);
                doc.AppendChild(rootnode);

               
            }


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xls",
                Filter = "Excel files (*.xls)|*.xlsx",
                
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void radioSalesVoucher_CheckedChanged(object sender, EventArgs e)
        {
           /*List<string> listSaleTallyElement = new List<string>();
            listSaleTallyElement.Add("DATE");
            listSaleTallyElement.Add("PARTYNAME");
            listSaleTallyElement.Add("VOUCHERTYPENAME");
            listSaleTallyElement.Add("REFERENCE");
            listSaleTallyElement.Add("VOUCHERNUMBER");
            listSaleTallyElement.Add("PARTYLEDGERNAME");
            listSaleTallyElement.Add("PERSISTEDVIEW");
            listSaleTallyElement.Add("BASICBUYERNAME");
            listSaleTallyElement.Add("ISINVOICE");

            ////<LEDGERENTRIES.LIST>------///
            listSaleTallyElement.Add("LEDGERNAME");
            listSaleTallyElement.Add("ISDEEMEDPOSITIVE");
            listSaleTallyElement.Add("AMOUNT");

            /////<BILLALLOCATIONS.LIST>  -----///
            listSaleTallyElement.Add("NAME");
            listSaleTallyElement.Add("BILLTYPE");
            listSaleTallyElement.Add("AMOUNT");

            //// <ALLINVENTORYENTRIES.LIST>
            listSaleTallyElement.Add("STOCKITEMNAME");
            listSaleTallyElement.Add("ISDEEMEDPOSITIVE");
            listSaleTallyElement.Add("RATE");
            listSaleTallyElement.Add("AMOUNT");
            listSaleTallyElement.Add("ACTUALQTY");
            listSaleTallyElement.Add("BILLEDQTY");

            //// <BATCHALLOCATIONS.LIST>
            listSaleTallyElement.Add("GODOWNNAME");
            listSaleTallyElement.Add("BATCHNAME");

            foreach (string item in listSaleTallyElement)
            {
                comboTally.Items.Add(item);
            }  */

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adding column and rows in datagridview from combo
            string[] str1 = new string[2];
            str1[0] = comboTally.GetItemText(comboTally.SelectedItem);
            str1[1] = comboExcel.GetItemText(comboExcel.SelectedItem);

            dataGridView2.ColumnCount = 2;
            // dataGridView2.Columns[0].Name = "Tally";
            dataGridView2.Columns[0].Name = "Sales";
            dataGridView2.Columns[1].Name = "Excel";

            dataGridView2.Rows.Add(str1);

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            //validation
          /*  if (txtFilePath.Text == "")
            {
                lblMessage.Text = "Select Path for file";
                txtFilePath.Focus();
            }

            if(txtFileName.Text=="")
            {
                lblMessage.Text = "Enter file name without extension";
                txtFileName.Focus();
            } */

            //------Adding column to data table and row-------//
            DataTable dt = new DataTable("Raport");
            //Genetating column to datatable
            foreach (DataGridViewColumn col in dataGridView2.Columns)
                dt.Columns.Add(col.Name, typeof(string));

            int grid2_row_count = dataGridView2.Rows.Count - 1;

            for (int i = 0; i < grid2_row_count; i++)
            {
                dt.Rows.Add();
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    dt.Rows[i][j] = dataGridView2[j, i].Value;
                }

            }

            // converting to json string
            string JsonResult;
            JsonResult = JsonConvert.SerializeObject(dt);
            //Console.WriteLine(JsonResult);

            //save diolog box----------//

            // string json string inti json file
            if (txtFilePath.Text != string.Empty && txtFileName.Text != string.Empty)
            {
                string strPath = txtFilePath.Text + "\\" + txtFileName.Text + ".json";
                File.WriteAllText(strPath, JsonResult);
                // File.WriteAllText(@"C:\Users\Birendra Kumar\Desktop\Tally Integration Doc-23Mar-21\"+ txtJsonFile.Text + ".json" , JsonResult);
                lblMessage.Text = "Json File has been saved";
            }
            else
            {
                txtFilePath.Focus();
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   Template Master -------------//
            if (clsMenu.MenuID == enmMenu.TemplateMaster.ToString())
            {
                ///Ledger Tally Element  --///
                List<string> listOfTallyLedger = new List<string>();
                listOfTallyLedger.Add("NAME");
                listOfTallyLedger.Add("PARENT");
                listOfTallyLedger.Add("OPENINGBALANCE");
                listOfTallyLedger.Add("ISBILLWISEON");
                ////----------------------------------------///////
                comboTally.Items.Clear();
                if (comboBox1.SelectedItem == "Ledgers")
                {
                    
                    foreach (string item in listOfTallyLedger)
                    {
                        comboTally.Items.Add(item);
                    }

                }


            }
            


            if (clsMenu.MenuID == enmMenu.TemplateVoucher.ToString())
            {
                //// VOUCHER TALLY ELEMENT///
                List<string> listSaleTallyElement = new List<string>();
                listSaleTallyElement.Add("DATE");
                listSaleTallyElement.Add("PARTYNAME");
                listSaleTallyElement.Add("VOUCHERTYPENAME");
                listSaleTallyElement.Add("REFERENCE");
                listSaleTallyElement.Add("VOUCHERNUMBER");
                listSaleTallyElement.Add("PARTYLEDGERNAME");
                listSaleTallyElement.Add("PERSISTEDVIEW");
                listSaleTallyElement.Add("BASICBUYERNAME");
                listSaleTallyElement.Add("ISINVOICE");

                ////<LEDGERENTRIES.LIST>------///
                listSaleTallyElement.Add("LEDGERNAME");
                listSaleTallyElement.Add("ISDEEMEDPOSITIVE");
                listSaleTallyElement.Add("AMOUNT");

                /////<BILLALLOCATIONS.LIST>  -----///
                listSaleTallyElement.Add("NAME");
                listSaleTallyElement.Add("BILLTYPE");
                listSaleTallyElement.Add("AMOUNT");

                //// <ALLINVENTORYENTRIES.LIST>
                listSaleTallyElement.Add("STOCKITEMNAME");
                listSaleTallyElement.Add("ISDEEMEDPOSITIVE");
                listSaleTallyElement.Add("RATE");
                listSaleTallyElement.Add("AMOUNT");
                listSaleTallyElement.Add("ACTUALQTY");
                listSaleTallyElement.Add("BILLEDQTY");

                //// <BATCHALLOCATIONS.LIST>
                listSaleTallyElement.Add("GODOWNNAME");
                listSaleTallyElement.Add("BATCHNAME");

                comboTally.Items.Clear();
                if (comboBox1.SelectedItem == "Sales")
                {
                    
                    foreach (string item in listSaleTallyElement)
                    {
                        comboTally.Items.Add(item);
                    }

                }
            }
           

        



            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
