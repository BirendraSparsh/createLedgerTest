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
    public partial class frmLedDel : Form
    {
        public frmLedDel()
        {
            InitializeComponent();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger()
            {
                ledgerName = txtLedName.Text,
                
            };

            LedgerDeleteXml(ledger);
        }

        public void LedgerDeleteXml(Ledger ledger) // request xml and response for ledger creation
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
                xmlstc = xmlstc + "<LEDGER NAME=" + "\"" + ledger.ledgerName + "\" Action =" + "\"" + "Delete" + "\">\r\n";
                xmlstc = xmlstc + "<NAME>" + ledger.ledgerName + "</NAME>\r\n";
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

    }
}
