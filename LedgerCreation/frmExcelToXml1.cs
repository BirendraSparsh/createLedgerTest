using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LedgerCreation
{
    public partial class frmExcelToXml1 : Form
    {
        public frmExcelToXml1()
        {
            InitializeComponent();
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

               /* while (i < oItem)
                {

                    day = dt.Rows[i].ItemArray[0].ToString();

                    if (day != day1)
                    {
                        day1 = day;
                        DateTime d = Convert.ToDateTime(dt.Rows[i].ItemArray[4]);

                        string str = Convert.ToDateTime(d.ToString("dd-MMMM-yyyy")).ToString("MMMM-dd-yyyy");

                        string finaldate = str.Replace(d.Year.ToString(), DateTime.Now.ToString("yyyy"));

                        XmlElement dobEle = doc.CreateElement("DOB");

                        dobEle.SetAttribute("date", finaldate);


                        do
                        {
                            XmlElement emp = doc.CreateElement("EmpDetails");
                            XmlElement name = doc.CreateElement("Name");
                            XmlElement desig = doc.CreateElement("Designation");
                            XmlElement dept = doc.CreateElement("Dept");
                            XmlElement loc = doc.CreateElement("Location");

                            name.InnerText = dt.Rows[i].ItemArray[1].ToString();
                            desig.InnerText = dt.Rows[i].ItemArray[2].ToString();
                            dept.InnerText = desig.InnerText;
                            loc.InnerText = dt.Rows[i].ItemArray[3].ToString();

                            emp.AppendChild(name);
                            emp.AppendChild(desig);
                            emp.AppendChild(dept);
                            emp.AppendChild(loc);

                            dobEle.AppendChild(emp);
                            i++;
                        } while (day1 == dt.Rows[i].ItemArray[0].ToString() && i < oItem);


                        doc.DocumentElement.AppendChild(dobEle);

                    }
                }
                doc.Save("C:/Users/Birendra Kumar/Desktop/Tally Integration Doc-23Mar-21/Output.xml");  */
              //  Response.Write("Created");
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

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmExcelToXml1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {  
            //adding column and rows in datagridview from combo
            string[] str1 = new string[2];
            str1[0] = comboTally.GetItemText(comboTally.SelectedItem);
            str1[1] = comboExcel.GetItemText(comboExcel.SelectedItem);

            dataGridView2.ColumnCount = 2;
           // dataGridView2.Columns[0].Name = "Tally";
            dataGridView2.Columns[0].Name = "Ledger";
            dataGridView2.Columns[1].Name = "Excel";

            dataGridView2.Rows.Add(str1);




            
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            //------Adding column to data table and row-------//
            DataTable dt = new DataTable("Raport");
            //Genetating column to datatable
            foreach(DataGridViewColumn  col in dataGridView2.Columns)
               dt.Columns.Add(col.Name,typeof(string));

           int grid2_row_count = dataGridView2.Rows.Count-1;

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
            if(txtFilePath.Text != string.Empty && txtFileName.Text !=string.Empty)
            {
                string strPath = txtFilePath.Text +"\\" + txtFileName.Text  + ".json";
                File.WriteAllText(strPath , JsonResult);
                // File.WriteAllText(@"C:\Users\Birendra Kumar\Desktop\Tally Integration Doc-23Mar-21\"+ txtJsonFile.Text + ".json" , JsonResult);
                lblMessage.Text = "Json File has been saved";
            }
            else
            {
                txtFilePath.Focus();
            } 
            
       
        
        }

        private void btnLoadJsonFile_Click(object sender, EventArgs e)  
        { 
            // read json file 
            string JsonText="";
            if (txtJsonFile1.Text != string.Empty)
            {
                JsonText = File.ReadAllText((txtJsonFile1.Text).ToString());
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(JsonText, (typeof(DataTable)));
                dataGridView2.DataSource = dt;
            }
            else
            {
                txtJsonFile1.Focus();
            }
        }

       

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
             {
                txtFilePath.Text = folderBrowserDialog1.SelectedPath;
             }
        }

        private void btnBrowseTemplate_Click(object sender, EventArgs e)
        {
            //  browse json file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Json Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "Json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtJsonFile1.Text = openFileDialog1.FileName;
            }  

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // showing selected excel data according to json template file  in datagrid dgv
          //  DataGridView dgv = new DataGridView();
            int cntDGV2 = dataGridView2.Rows.Count - 1;
           // string[] arrTallyHeader = new string[cntDGV2];
            string[] arrTallyLedgerElement = new string[cntDGV2];
            string[] arrExcelHeader = new string[cntDGV2];

            for (int j = 0; j < cntDGV2; j++)
            {
  
                arrTallyLedgerElement[j] = dataGridView2.Rows[j].Cells[0].Value.ToString(); // fetching column header
                arrExcelHeader[j] = dataGridView2.Rows[j].Cells[1].Value.ToString(); // fetching column header
            }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {   // fetch grid2 header maching Column data from grid1(Excel data)
                    string[] arrGrid1MachingColData = new string[arrExcelHeader.Length];

                    for (int k = 0; k < arrExcelHeader.Length; k++)
                    {
                        string strExcel = arrExcelHeader[k];
                        arrGrid1MachingColData[k] = (dataGridView1.Rows[i].Cells[strExcel].Value.ToString());
                    }
                        
                   // arrGrid1MachingcolData[1] = (dataGridView1.Rows[i].Cells["Department"].Value.ToString());

                    for (int m = 0; m < arrTallyLedgerElement.Length; m++)
                    {
                        dgv.ColumnCount = arrTallyLedgerElement.Length;
                        dgv.Columns[m].Name = arrTallyLedgerElement[m];  // set column name of dgv
                    }

                   /* dgv.ColumnCount = 2;
                    dgv.Columns[0].Name = "Ledger";
                    dgv.Columns[1].Name = "Group"; */

                    dgv.Rows.Add(arrGrid1MachingColData);
                }
        }

        private void btnConvertToXml_Click(object sender, EventArgs e)
        {

              //------Adding column to data table and row-------//
            int i = 0;  
            int row_Count = 0;  
            DataTable dt = new DataTable("Report1");
            //Genetating column to datatable
            foreach(DataGridViewColumn  col in dgv.Columns)
               dt.Columns.Add(col.Name,typeof(string));

           int grid2_row_count = dgv.Rows.Count-1;

           for (int l = 0; l < grid2_row_count; l++)
           {
               dt.Rows.Add();
               for (int j = 0; j < dgv.Columns.Count; j++)
               {
                   dt.Rows[l][j] = dgv[j, l].Value;
               }

           }
            
            row_Count = dt.Rows.Count;  
            //oItem -= 1;  
            
                XmlDocument doc = new XmlDocument();
                XmlDeclaration declaire = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                // -----------------------create root-----------------------------  
                XmlElement rootnode = doc.CreateElement("ENVELOPE");
                doc.InsertBefore(declaire, doc.DocumentElement);
                doc.AppendChild(rootnode);
                XmlElement header = doc.CreateElement("HEADER");
                XmlElement tallyRequest = doc.CreateElement("TALLYREQUEST");
                XmlElement body = doc.CreateElement("BODY");
                XmlElement importData = doc.CreateElement("IMPORTDATA");
                XmlElement requestDesc = doc.CreateElement("REQUESTDESC");
                XmlElement reportName = doc.CreateElement("REPORTNAME");
                XmlElement requestData = doc.CreateElement("REQUESTDATA");

                rootnode.AppendChild(header);
                header.AppendChild(tallyRequest);
                tallyRequest.InnerText = "Import Data";
                rootnode.AppendChild(body);
                body.AppendChild(importData);
                importData.AppendChild(requestDesc);
                requestDesc.AppendChild(reportName);
                reportName.InnerText = "All Masters";
                importData.AppendChild(requestData);

             while (i < row_Count)
               {
                  


                       // create element of xml
                        XmlElement tallyMesssage = doc.CreateElement("TALLYMESSAGE");
                        XmlElement ledger = doc.CreateElement("LEDGER");
                    /*  XmlElement name = doc.CreateElement("NAME");
                        XmlElement parent = doc.CreateElement("PARENT");
                        XmlElement openingBalance = doc.CreateElement("OPENINGBALANCE");
                        XmlElement isBillWiseOn = doc.CreateElement("ISBILLWISEON"); */

                       
                       ////assing value 
                      /*  name.InnerText = dt.Rows[i].ItemArray[0].ToString();
                        parent.InnerText = dt.Rows[i].ItemArray[1].ToString();
                        openingBalance.InnerText = dt.Rows[i].ItemArray[2].ToString();
                        isBillWiseOn.InnerText = "Yes"; */

                        

                        // add cheld element 
                        tallyMesssage.AppendChild(ledger);
                      /*  ledger.AppendChild(name);
                        ledger.AppendChild(parent);
                        ledger.AppendChild(openingBalance);
                        ledger.AppendChild(isBillWiseOn);*/

                        // assign properties to element
                        tallyMesssage.SetAttribute("xmlns:UDF", "TallyUDF");
                       /////// ledger.SetAttribute("NAME", name.InnerText);
                        ledger.SetAttribute("Action", "Create"); 


                        /////Fetching column name of data table dgv 
                        string[] columnNames = dt.Columns.Cast<DataColumn>()
                                                  .Select(x => x.ColumnName)
                                                  .ToArray();

                        List<XmlElement> colList = new List<XmlElement>();

                        for (int k = 0; k < columnNames.Length; k++)
                        {

                            string col = columnNames[k];
                            XmlElement x = doc.CreateElement(col);

                            colList.Add(x);

                        }

                        for (int j = 0; j < colList.Count; j++ )
                        {
                            var y = colList[j];
                            y.InnerText = dt.Rows[i].ItemArray[j].ToString();

                            ledger.AppendChild(y);

                            if (y.Name == "NAME")
                           ledger.SetAttribute("NAME", y.InnerText);
                           
                        }


                        requestData.AppendChild(tallyMesssage);
                        i++;
                       

                   // doc.DocumentElement.AppendChild(rootnode);

                }

             string strXml = doc.InnerXml.ToString();
             Console.WriteLine(strXml);
              doc.Save("C:/Users/Birendra Kumar/Desktop/Tally Integration Doc-23Mar-21/Output1.xml");
              lblMessage.Text = "XMl file has been created";  

            // sending request to tally to create ledger according to xml document
                string IRespose = SendReqst(strXml);  
                lblMessage.Text = "Created Ledger in Tally"; 
            }

        private void btnPost_Click(object sender, EventArgs e)
        {
             

        }

        public string SendReqst(string pWebRequstStr)
        {
            String lResponseStr = "";
            String lResult = "";

            try
            {
                String lTallyLocalHost = "http://localhost:9000";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(lTallyLocalHost);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentLength = (long)pWebRequstStr.Length;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                StreamWriter lStrmWritr = new StreamWriter(httpWebRequest.GetRequestStream());
                lStrmWritr.Write(pWebRequstStr);
                lStrmWritr.Close();
                HttpWebResponse lhttpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream lreceiveStream = lhttpResponse.GetResponseStream();
                StreamReader lStreamReader = new StreamReader(lreceiveStream, Encoding.UTF8);
                lResponseStr = lStreamReader.ReadToEnd();
                lhttpResponse.Close();
                lStreamReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            lResult = lResponseStr;
            return lResult;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        }

    
    }

