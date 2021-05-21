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
using Newtonsoft.Json;
using System.Xml;

namespace LedgerCreation
{
     
    public partial class frmStockItem : Form
    {
       
        public frmStockItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //// passing this xml to tally for requesting vouchers
            //string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>Vouchers</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><VOUCHERTYPENAME>Receipt</VOUCHERTYPENAME></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            // passing this xml to tally for requesting All Inventory Masters
            string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>All Inventory Masters</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            // passing this xml to tally for requesting list of ledger name
            //string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>Ledgers</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            // passing this xml to tally for requesting All Inventory Masters
            //string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>Stock Summary</REPORTNAME><STATICVARIABLES></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
            string TallyResponse = TallyXml.ConnectToTally(RequestXML);

             XmlDocument xml = new XmlDocument();
             xml.LoadXml(TallyResponse);
            //show list of leadger name
             XmlNodeList xnList = xml.SelectNodes("//BODY/IMPORTDATA/REQUESTDATA/TALLYMESSAGE/STOCKITEM/LANGUAGENAME.LIST/NAME.LIST/NAME");
            //// XmlNodeList nodes = xml.GetElementsByTagName("NAME");
           foreach (XmlNode xn in xnList)
           {
               foreach (XmlNode xa in xn)
               {
                   string data = xa.Value;
                   listBox1.Items.Add(data);
               }
             
           }  


            /*DataSet TallyCollectionDataSet = TallyXml.ConnectToTally();

           // TallyGridView.DataSource = TallyCollectionDataSet.Tables["GODOWN"];
            TallyGridView.DataSource = TallyCollectionDataSet.Tables[0];

            TallyGridView.AutoGenerateColumns = true;
            TallyGridView.Visible = true; */
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    class TallyXml
    {

       // private static string RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>All Inventory Masters</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
        private static WebRequest TallyRequest;// = WebRequest.Create("http://192.168.0.96:9000");
        //private static ServerXMLHTTP30 RequestClient=new ServerXMLHTTP30();
       // public static DataSet ConnectToTally()
        public static string ConnectToTally(string RequestXML)
        {

            string responseFromTallyServer;
                // RequestXML = "<ENVELOPE><HEADER><TALLYREQUEST>Export Data</TALLYREQUEST></HEADER><BODY><EXPORTDATA><REQUESTDESC><REPORTNAME>List of Accounts</REPORTNAME><STATICVARIABLES><SVEXPORTFORMAT>$$SysName:XML</SVEXPORTFORMAT><ACCOUNTTYPE>Ledgers</ACCOUNTTYPE></STATICVARIABLES></REQUESTDESC></EXPORTDATA></BODY></ENVELOPE>";
                TallyRequest = WebRequest.Create("http://localhost:9000");
                ((HttpWebRequest)TallyRequest).UserAgent = ".NET Framework Example Client";
                // Set the Method property of the request to POST.
                TallyRequest.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = RequestXML;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                TallyRequest.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                TallyRequest.ContentLength = byteArray.Length;
                // Get the request stream.
            Stream dataStream;
            try
            {
                dataStream = TallyRequest.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
                // Get the response.
                WebResponse response = TallyRequest.GetResponse();
                // Display the status.
                string Response = (((HttpWebResponse)response).StatusDescription).ToString();
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromTallyServer = reader.ReadToEnd().ToString();
           

            // Display the content.
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
            byteArray = null;
            response = null;
            Response = null;
            dataStream = null;
            return responseFromTallyServer;        
            
          
         
        

        }

    }
}
