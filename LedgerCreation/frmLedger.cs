using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmLedger : Form
    {
        public frmLedger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger(){
                ledgerName = txtLedgerName.Text,
                parentName = comboParent.Text,
                openingBalance = txtOpeningBalance.Text
            };

            LedgerCreateXml(ledger);
        }

        public void LedgerCreateXml(Ledger ledger) // request xml and response for ledger creation
        {
            try
            {
 
                String xmlstc = "";
                xmlstc = "<ENVELOPE>\r\n";
                xmlstc = xmlstc + "<HEADER>\r\n";
                xmlstc = xmlstc + "<TALLYREQUEST>Import Data</TALLYREQUEST>\r\n";
                xmlstc = xmlstc + "</HEADER>\r\n";
                xmlstc = xmlstc + "<BODY>\r\n";
                xmlstc = xmlstc + "<IMPORTDATA>\r\n";
                xmlstc = xmlstc + "<REQUESTDESC>\r\n";
                xmlstc = xmlstc + "<REPORTNAME>All Masters</REPORTNAME>\r\n";
                xmlstc = xmlstc + "</REQUESTDESC>\r\n";
                xmlstc = xmlstc + "<REQUESTDATA>\r\n";
                xmlstc = xmlstc + "<TALLYMESSAGE xmlns:UDF=" + "\"" + "TallyUDF" + "\">\r\n";

                xmlstc = xmlstc + "<LEDGER NAME=" + "\"" + ledger.ledgerName + "\" Action =" + "\"" + "Create" + "\">\r\n";
                xmlstc = xmlstc + "<NAME>" + ledger.ledgerName + "</NAME>\r\n";
                xmlstc = xmlstc + "<PARENT>" + ledger.parentName + "</PARENT>\r\n";
                xmlstc = xmlstc + "<OPENINGBALANCE>" + ledger.openingBalance + "</OPENINGBALANCE>\r\n";
                xmlstc = xmlstc + "<ISBILLWISEON>Yes</ISBILLWISEON>\r\n";
                xmlstc = xmlstc + "</LEDGER>\r\n";

                xmlstc = xmlstc + "</TALLYMESSAGE>\r\n";
                xmlstc = xmlstc + "</REQUESTDATA>\r\n";
                xmlstc = xmlstc + "</IMPORTDATA>\r\n";
                xmlstc = xmlstc + "</BODY>";
                xmlstc = xmlstc + "</ENVELOPE>";
                String xml = xmlstc;
                String lLedgerResponse = SendReqst(xml);
                MessageBox.Show(lLedgerResponse);  
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

         private void Form1_Load(object sender, EventArgs e)
         {
             // passing this xml to tally for requesting list of ledger name
             string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>Ledgers</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
             string TallyResponse = TallyXml.ConnectToTally(RequestXML);

             XmlDocument xml = new XmlDocument();
             xml.LoadXml(TallyResponse);
             //show list of leadger name
             XmlNodeList xnList = xml.SelectNodes("//BODY/IMPORTDATA/REQUESTDATA/TALLYMESSAGE/GROUP/LANGUAGENAME.LIST/NAME.LIST/NAME");
             //// XmlNodeList nodes = xml.GetElementsByTagName("NAME");
             foreach (XmlNode xn in xnList)
             {
                 foreach (XmlNode xa in xn)
                 {
                     string data = xa.Value;
                     comboParent.Items.Add(data);

                 }

             }
         }

         private void button2_Click(object sender, EventArgs e)
         {
             // passing this xml to tally for requesting list of ledger name
             string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>Ledgers</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
             string TallyResponse = TallyXml.ConnectToTally(RequestXML);

             XmlDocument xml = new XmlDocument();
             xml.LoadXml(TallyResponse);
             //show list of leadger name
             XmlNodeList xnList = xml.SelectNodes("//BODY/IMPORTDATA/REQUESTDATA/TALLYMESSAGE/LEDGER/LANGUAGENAME.LIST/NAME.LIST/NAME");
             foreach (XmlNode xn in xnList)
             {
                 foreach (XmlNode xa in xn)
                 {
                     string data = xa.Value;
                     listBox1.Items.Add(data);
                 }
             }
         }

         public void LedgeGetXml()
         {
            /* string path_of_xml = @"C:\Users\Birendra Kumar\Desktop\Tally Integration Doc-23Mar-21\Trial_Bal.xml";
             XmlDocument doc = new XmlDocument();

             doc.Load(path_of_xml);

             //Get your nodes
             XmlNodeList nodes = doc.DocumentElement.SelectNodes("//ENVELOPE");

             //This will build your string
             StringBuilder yourString = new StringBuilder();
             yourString.Append("The Products available are : ");

             //Iterates through your String appending the available Names
             foreach (XmlNode node in nodes)
             {
                 yourString.Append(node["Name"].InnerText + "\n");
             }

             //Variable for your final string (replaces the trailing comma with a period)
             string result = yourString.Remove(yourString.Length - 1, 1).ToString() + "\r\n";  */


             try
             {
                 String xmlstc = "";
                 xmlstc = "<ENVELOPE>\r\n";
                 xmlstc = xmlstc + "<HEADER>\r\n";
                 xmlstc = xmlstc + "<VERSION>1</VERSION>\r\n";
                 xmlstc = xmlstc + "<TALLYREQUEST>Export</TALLYREQUEST>\r\n";
                 xmlstc = xmlstc + "<TYPE>Data</TALLYREQUEST>\r\n";
                 xmlstc = xmlstc + "<ID>Trial Balance</ID>\r\n";
                 xmlstc = xmlstc + "</HEADER>\r\n";
                 xmlstc = xmlstc + "<BODY>\r\n";
                 xmlstc = xmlstc + "<DESC>\r\n";
                 xmlstc = xmlstc + "<REQUESTDESC>\r\n";
                 xmlstc = xmlstc + "</REQUESTDESC>\r\n";
                 xmlstc = xmlstc + "<STATICVARIABLES>\r\n";
                 xmlstc = xmlstc + "<EXPLODEFLAG>Yes</EXPLODEFLAG>\r\n";
                 xmlstc = xmlstc + "<SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT>";
                 xmlstc = xmlstc + "</STATICVARIABLES>\r\n";
                 xmlstc = xmlstc + "</DESC>\r\n";
                 xmlstc = xmlstc + "</BODY>\r\n";
                 xmlstc = xmlstc + "</ENVELOPE>";
                 String xml = xmlstc;
                 String lLedgerResponse = SendReqst(xml);
                 MessageBox.Show(lLedgerResponse);
             }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }  
         }



    }

    public class Ledger
    {
        public Ledger() { }

        public string ledgerName { get; set; }
        public string parentName { get; set; }
        public string openingBalance { get; set; }

        public string NewledgerName { get; set; }
    }

    
}
