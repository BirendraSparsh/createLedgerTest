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

namespace LedgerCreation
{
    public partial class frmLedRename : Form
    {
        public frmLedRename()
        {
            InitializeComponent();
        }

        public void LedgerCreateXml(Ledger ledger) // request xml and response for ledger Alteration
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
                xmlstc = xmlstc + "<LEDGER NAME=" + "\"" + ledger.ledgerName + "\" Action =" + "\"" + "Alter" + "\">\r\n";
                xmlstc = xmlstc + "<NAME>" + ledger.NewledgerName + "</NAME>\r\n";
                //xmlstc = xmlstc + "<PARENT>Sundry Creditors</PARENT>\r\n";
                //xmlstc = xmlstc + "<PARENT>" + ledger.parentName + "</PARENT>\r\n";
                //xmlstc = xmlstc + "<OPENINGBALANCE>" + ledger.openingBalance + "</OPENINGBALANCE>\r\n";
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

                /*String xmlstc = "";
               xmlstc = "<ENVELOPE>\r\n";
               xmlstc = xmlstc + "<HEADER>\r\n";
               xmlstc = xmlstc + "<Version>1</Version>\r\n";
               xmlstc = xmlstc + "<TALLYREQUEST>Import</TALLYREQUEST>\r\n";
               xmlstc = xmlstc + "<TYPE>DATA</TYPE>\r\n";
               xmlstc = xmlstc + "<ID>All Masters</ID>\r\n";
               xmlstc = xmlstc + "</HEADER>\r\n";
               xmlstc = xmlstc + "<BODY>\r\n";
               xmlstc = xmlstc + "<DESC>\r\n";
               xmlstc = xmlstc + "</DESC>\r\n";
               xmlstc = xmlstc + "<DATA>\r\n";
               xmlstc = xmlstc + "<TALLYMESSAGE>\r\n";
               xmlstc = xmlstc + "<LEDGER NAME=" + "\"" + ledger.ledgerName + "\" Action =" + "\"" + "Alter" + "\">\r\n";
               xmlstc = xmlstc + "<NAME>" + ledger.NewledgerName + "</NAME>\r\n";
               //xmlstc = xmlstc + "<PARENT>Sundry Creditors</PARENT>\r\n";
               //xmlstc = xmlstc + "<PARENT>" + ledger.parentName + "</PARENT>\r\n";
               //xmlstc = xmlstc + "<OPENINGBALANCE>" + ledger.openingBalance + "</OPENINGBALANCE>\r\n";
               xmlstc = xmlstc + "</LEDGER>\r\n";
               xmlstc = xmlstc + "</TALLYMESSAGE>\r\n";
                xmlstc = xmlstc + "</DATA>\r\n";
               xmlstc = xmlstc + "</BODY>";
               xmlstc = xmlstc + "</ENVELOPE>";
               String xml = xmlstc;
               String lLedgerResponse = SendReqst(xml);
               MessageBox.Show(lLedgerResponse); */
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


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger()
            {
                ledgerName = txtLedName.Text,
                NewledgerName = txtNewLedName.Text,
               // parentName = comboParent.Text,
               // openingBalance = txtOpeningBalance.Text
            };

            LedgerCreateXml(ledger);
        }
    }

    class abc
    {

        DataSet ds = new DataSet();

       // ds = TallyXml2.GetTallyData();

    }



     class TallyXml2
    {
        private static string RequestXML1;
        private static WebRequest TallyRequest;
        //private static ServerXMLHTTP30 RequestClient=new ServerXMLHTTP30();
       /* public static DataSet GetTallyData()
        { 
          RequestXML1 = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>Ledgers</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";

            TallyRequest = WebRequest.Create("http://localhost:9000");
            ((HttpWebRequest)TallyRequest).UserAgent = ".NET Framework Example Client";
            // Set the Method property of the request to POST.
            TallyRequest.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = RequestXML1;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            TallyRequest.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            TallyRequest.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = TallyRequest.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = TallyRequest.GetResponse();
            // Display the status.
            string Response = (((HttpWebResponse)response).StatusDescription).ToString();
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromTallyServer = reader.ReadToEnd().ToString(); 
            DataSet TallyResponseDataSet = new DataSet();
            TallyResponseDataSet.ReadXml(new StringReader(responseFromTallyServer));
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
            byteArray = null;
            response = null;
            responseFromTallyServer = null;
            Response = null;
            dataStream = null;
            // RequestClient.open("Get", "http://localhost:9000/", false, null, null);
            // RequestClient.send(
            // IXMLDOMNode ResponseXml = (IXMLDOMNode)RequestClient.responseXML  



            return TallyResponseDataSet; 
        }  */
    }



}
