using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LedgerCreation
{
    public partial class frmDayBook : Form
    {
        public frmDayBook()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            
            //fiter data gridview according to date
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            DataView dv = new DataView(dt);
            string s = cmbVoucherTypeName.GetItemText(cmbVoucherTypeName.SelectedItem);
            dv.RowFilter = "(Date >= #" + Convert.ToDateTime(dtpFromDate.Text).ToString("MM/dd/yyyy") + "# And Date <= #" + Convert.ToDateTime(dtpToDate.Text).ToString("MM/dd/yyyy") + "#  And VOUCHERTYPENAME = '" + s + "')";
            var source = new BindingSource();

            source.DataSource = dv;

            dataGridView2.DataSource = source;  
           
        }

        public void daybookXmlPost()
        {
            // <!--This XML document contains tags to fetch SALES-type Vouchers of from Tally-->
            //<!--It is equivalent to using the following option in Tally Software manually-->
            //<!--Option: Gateway of Tally @Display @Daybook  @F4  @Sales-->
            dayBookSales daybooksales = new dayBookSales();
            daybooksales.vouchertypename = cmbVoucherTypeName.GetItemText(cmbVoucherTypeName.SelectedItem);
            /* daybooksales.fromDate = dtpFromDate.Value;
             string strFromDate = daybooksales.fromDate.ToString("yyyyMMdd");
             daybooksales.toDate = dtpToDate.Value;
             string strToDate = daybooksales.toDate.ToString("yyyyMMdd"); */

            string RequestXML = "<ENVELOPE>" +
                                "<HEADER>" +
                                "<TALLYREQUEST>Export Data</TALLYREQUEST>" +
                                "</HEADER>" +
                                "<BODY>" +
                                "<EXPORTDATA>" +
                                "<REQUESTDESC>" +
                                "<STATICVARIABLES>" +
                                "<!--Specify the Period here-->" +
                                "<SVFROMDATE>20210616</SVFROMDATE>" +  //+ strFromDate +
                                "<SVTODATE>20210616</SVTODATE>" +   //+ strToDate +
                                "<!--Specify the Voucher-type here-->" +
                                "<VOUCHERTYPENAME>" + daybooksales.vouchertypename + "</VOUCHERTYPENAME>" +
                                "</STATICVARIABLES>" +
                                "<!--Specify the Report Name here-->" +
                                "<REPORTNAME>Voucher Register</REPORTNAME>" +
                                "</REQUESTDESC>" +
                                "</EXPORTDATA>" +
                                "</BODY>" +
                                "</ENVELOPE>";

            ////////////// passing this xml to tally for requesting All Inventory Masters
            //////////////string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>All Inventory Masters</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            ////////////// passing this xml to tally for requesting list of ledger name
            //////////////string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>Ledgers</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            ////////////// passing this xml to tally for requesting All Inventory Masters
            //////////////string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>Stock Summary</REPORTNAME><STATICVARIABLES></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            string TallyResponse = TallyXml.ConnectToTally(RequestXML);

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(TallyResponse);
            //show list of leadger name
            XmlNodeList xmlNodeList = xml.SelectNodes("//BODY/IMPORTDATA/REQUESTDATA/TALLYMESSAGE");
            //// XmlNodeList nodes = xml.GetElementsByTagName("NAME");


            List<string> listOfName = new List<string>();  // list of xml element Name
            List<string> listOfValue = new List<string>();  // list of xml element Value
            foreach (XmlNode xmlNode in xmlNodeList)
            {

                foreach (XmlNode xmlNodeChild in xmlNode)
                {

                    foreach (XmlNode xmlNodeChildChild in xmlNodeChild)
                    {

                        string xmlElementName = xmlNodeChildChild.Name;
                        string xmlElementValue = xmlNodeChildChild.InnerText;

                        // if (xmlElementName == "DATE" || xmlElementName == "PARTYNAME" || xmlElementName == "VOUCHERTYPENAME" || xmlElementName == "VOUCHERNUMBER" || xmlElementName == "PARTYLEDGERNAME")
                        if (xmlElementName == "DATE")
                        {
                            string strDate = ConvertStringToDate(xmlElementValue);
                            DateTime d = Convert.ToDateTime(strDate);

                            listOfName.Add(xmlElementName);
                            //CultureInfo culture = new CultureInfo("en-US");
                            //DateTime dtDate = Convert.ToDateTime(strDate, culture);
                            listOfValue.Add(strDate);
                        }
                        else if (xmlElementName == "PARTYNAME")
                        {
                            listOfName.Add(xmlElementName);
                            listOfValue.Add(xmlElementValue);
                        }
                        else if (xmlElementName == "VOUCHERTYPENAME")
                        {
                            listOfName.Add(xmlElementName);
                            listOfValue.Add(xmlElementValue);
                        }
                        else if (xmlElementName == "VOUCHERNUMBER")
                        {
                            listOfName.Add(xmlElementName);
                            listOfValue.Add(xmlElementValue);
                        }
                        else if (xmlElementName == "PARTYLEDGERNAME")
                        {
                            listOfName.Add(xmlElementName);
                            listOfValue.Add(xmlElementValue);

                        }

                    }

                }


            }

            //remove all rows from datagridview
            dataGridView1.Rows.Clear();

            //remove duplicate element
            IEnumerable<string> uniqueListOfName = listOfName.Distinct();
            //add datagridview column name
            int m = 0;
            dataGridView1.ColumnCount = uniqueListOfName.Count();
            foreach (var item in uniqueListOfName)
            {
                dataGridView1.ColumnCount = uniqueListOfName.Count();
                dataGridView1.Columns[m].Name = item;  // set column name of dataGridView1
                m++;
            }
            //add row to datagridview1 - filiing datagridview1
            List<List<string>> SplitOfList2 = class1.Split(listOfValue, uniqueListOfName.Count()); //spliting the list according to column no.
            foreach (List<string> items in SplitOfList2)
            {

                string[] array1 = new string[2];
                array1 = items.ToArray();
                dataGridView1.Rows.Add(array1);

            }

            //get the all value of column VOUCHERTUPENAME conbobox
            List<string> listOfVoucherTypeName = new List<string>();
            int i = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (i < dataGridView1.Rows.Count - 1)
                    listOfVoucherTypeName.Add(item.Cells[2].Value.ToString());
                i++;
            }
            i = 0;


            IEnumerable<string> UniquelistOfVoucherTypeName = listOfVoucherTypeName.Distinct();
            // put list item into combobox
            foreach (string item in UniquelistOfVoucherTypeName)
            {
                cmbVoucherTypeName.Items.Add(item);
            }

            
         /*   //fiter data gridview according to date
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            DataView dv = new DataView(dt);

            dv.RowFilter = "(Date >= #" + Convert.ToDateTime(dtpFromDate.Text).ToString("MM/dd/yyyy") + "# And Date <= #" + Convert.ToDateTime(dtpToDate.Text).ToString("MM/dd/yyyy") + "# )";

            var source = new BindingSource();

            source.DataSource = dv;

            dataGridView2.DataSource = source;  */



            //---------------------------//
            /*foreach (var item1 in uniqueListOfName)
            {
                listBox1.Items.Add(item1);
            }

            foreach (var item2 in listOfValue)
            {
                listBox2.Items.Add(item2);
            } */
   

        }
        public string ConvertStringToDate(string strDate)
        {
            string strYear = strDate.Substring(0, 4);
            string strMonth = strDate.Substring(4, 2);
            string strDay = strDate.Substring(6, 2);
            string strDateConbine = strDay + "/" + strMonth + "/" + strYear;
            return strDateConbine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // List<string> listOfVoucherTypeName = new List<string>();

                // int i = 0;
                // foreach (DataGridViewRow item in dataGridView1.Rows)
                // {
                     
                //     if (  i < dataGridView1.Rows.Count-1 )
                //         listOfVoucherTypeName.Add(item.Cells[2].Value.ToString());
                //     i++;
                // }
                // i = 0;
                //// put list item into combobox
                //foreach (string item in listOfVoucherTypeName)
                //{
                //    cmbVoucherTypeName.Items.Add(item);
                //}
           
        }

        private void frmDayBookSales_Load(object sender, EventArgs e)
        {
            daybookXmlPost();
        }


 
       
    }

   public static class class1
    {
        public static List<List<T>> Split<T>(this List<T> items, int sliceSize = 1)
        {
            List<List<T>> list = new List<List<T>>();
            for (int i = 0; i < items.Count; i += sliceSize)
                list.Add(items.GetRange(i, Math.Min(sliceSize, items.Count - i)));
            return list;
        } 
    }

    public class dayBookSales
    {
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }

        public string vouchertypename { get; set; }

    }
   
}
