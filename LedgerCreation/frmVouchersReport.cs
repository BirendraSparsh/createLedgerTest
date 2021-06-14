using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LedgerCreation
{
    public partial class frmVouchersReport : Form
    {
        public frmVouchersReport()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
           // <!--This XML document contains tags to fetch SALES-type Vouchers of from Tally-->
           //<!--It is equivalent to using the following option in Tally Software manually-->
           //<!--Option: Gateway of Tally @Display @Daybook  @F4  @Sales-->

            string RequestXML = "<ENVELOPE>" +
                                "<HEADER>" +
                                "<TALLYREQUEST>Export Data</TALLYREQUEST>" +
                                "</HEADER>" +
                                "<BODY>" +
                                "<EXPORTDATA>" +
                                "<REQUESTDESC>" +
                                "<STATICVARIABLES>" +
                                "<!--Specify the Period here-->" +
                                "<SVFROMDATE>20210401</SVFROMDATE>" +
                                "<SVTODATE>20220331</SVTODATE>" +
                                "<!--Specify the Voucher-type here-->" +
                                "<VOUCHERTYPENAME>SALES</VOUCHERTYPENAME>" +
                                "</STATICVARIABLES>" +
                                "<!--Specify the Report Name here-->" +
                                "<REPORTNAME>Voucher Register</REPORTNAME>" +
                                "</REQUESTDESC>" +
                                "</EXPORTDATA>" +
                                "</BODY>" +
                                "</ENVELOPE>";
            // passing this xml to tally for requesting All Inventory Masters
            //string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>All Inventory Masters</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            // passing this xml to tally for requesting list of ledger name
            //string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>Ledgers</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            // passing this xml to tally for requesting All Inventory Masters
            //string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>Stock Summary</REPORTNAME><STATICVARIABLES></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            string TallyResponse = TallyXml.ConnectToTally(RequestXML);

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(TallyResponse);
            //show list of leadger name
            XmlNodeList xmlNodeList = xml.SelectNodes("//BODY/IMPORTDATA/REQUESTDATA/TALLYMESSAGE");
            //// XmlNodeList nodes = xml.GetElementsByTagName("NAME");
            
           // Dictionary<string, string> dictionary = new Dictionary<string, string>();
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

                        if (xmlElementName == "DATE" || xmlElementName == "PARTYNAME" || xmlElementName == "VOUCHERTYPENAME" || xmlElementName == "VOUCHERNUMBER" || xmlElementName == "PARTYLEDGERNAME")
                        {
                            listOfName.Add(xmlElementName);
                            listOfValue.Add(xmlElementValue);
    
                        }
                         
                    }

                }

               
            }

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


            //add row to datagridview1 
           // List<string> ids = new List<string>() { "amit", "sumit", "punit", "sajid" }; // 10 elements
              List<List<string>> SplitOfList2 = class1.Split(listOfValue, uniqueListOfName.Count()); //spliting the list according to column no.
            foreach (List<string> items in SplitOfList2)
            {
                
                string[] array1 = new string[2];
                array1 = items.ToArray();
                dataGridView1.Rows.Add(array1);
               
            } 


            foreach (var item1 in uniqueListOfName)
            {
                listBox1.Items.Add(item1);
            }

            foreach (var item2 in listOfValue)
            {
                listBox2.Items.Add(item2);
            }
       


           
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
   
}
