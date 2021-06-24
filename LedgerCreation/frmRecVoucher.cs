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
    public partial class frmRecVoucher : Form
    {
        public frmRecVoucher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string xmlstc = "";
                // xmlstc = xmlstc + "<VOUCHER VCHTYPE=" + "\"" + "Receipt" + "\" ACTION=" + "\"" + "Create" + "\">";
                xmlstc = "<ENVELOPE>";
                xmlstc = xmlstc + "<HEADER>";
                xmlstc = xmlstc + "<TALLYREQUEST>Import Data</TALLYREQUEST>";
                xmlstc = xmlstc + "</HEADER>";
                xmlstc = xmlstc + "<BODY>";
                xmlstc = xmlstc + "<IMPORTDATA>";
                xmlstc = xmlstc + "<REQUESTDESC>";
                xmlstc = xmlstc + "<REPORTNAME>Vouchers</REPORTNAME>";
                xmlstc = xmlstc + "<STATICVARIABLES>";
                xmlstc = xmlstc + "<SVCURRENTCOMPANY>" + "##SVCURRENTCOMPANY" + "</SVCURRENTCOMPANY>";
                xmlstc = xmlstc + "</STATICVARIABLES>";
                xmlstc = xmlstc + "</REQUESTDESC>";

                xmlstc = xmlstc + "<REQUESTDATA>";


                string strVchNumber = txtVhrNo.Text;
                //strDate = "01/04/2020";
                string strDate = dtpDate.Value.Date.ToShortDateString();
                string strNarration = txtNaration.Text;
                string strAmount = txtAmount.Text;
                string strAccount = comboAccount.Text;
                string strParticular = comboParticular.Text;

                xmlstc = xmlstc + "<TALLYMESSAGE >";
                xmlstc = xmlstc + "<VOUCHER VCHTYPE=" + "\"" + "Receipt" + "\" ACTION=" + "\"" + "Alter" + "\">";
                xmlstc = xmlstc + "<VOUCHERNUMBER>" + strVchNumber + "</VOUCHERNUMBER>";
                xmlstc = xmlstc + "<DATE>" + strDate + "</DATE>";
                xmlstc = xmlstc + "<EFFECTIVEDATE>" + strDate + "</EFFECTIVEDATE>";
                xmlstc = xmlstc + "<NARRATION>" + strNarration + "</NARRATION>";
                xmlstc = xmlstc + "<VOUCHERTYPENAME>Receipt</VOUCHERTYPENAME>";

                //Credit Ledger
                xmlstc = xmlstc + "<ALLLEDGERENTRIES.LIST>";
                xmlstc = xmlstc + "<LEDGERNAME>" + strParticular + "</LEDGERNAME>";
                xmlstc = xmlstc + "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>";
                xmlstc = xmlstc + "<AMOUNT>" + strAmount + "</AMOUNT>";
                xmlstc = xmlstc + "</ALLLEDGERENTRIES.LIST>";

                //Debit Ledger
                xmlstc = xmlstc + "<ALLLEDGERENTRIES.LIST>";
                xmlstc = xmlstc + "<LEDGERNAME>" + strAccount + "</LEDGERNAME>";
                xmlstc = xmlstc + "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>";
                xmlstc = xmlstc + "<AMOUNT>-" + strAmount + "</AMOUNT>";
                xmlstc = xmlstc + "</ALLLEDGERENTRIES.LIST>";

                xmlstc = xmlstc + "</VOUCHER>";
                xmlstc = xmlstc + "</TALLYMESSAGE>";
                xmlstc = xmlstc + "</REQUESTDATA>";
                xmlstc = xmlstc + "</IMPORTDATA>";
                xmlstc = xmlstc + "</BODY>";
                xmlstc = xmlstc + "</ENVELOPE>";

                String xml = xmlstc;
                String lResponse = SendReqst(xml);
                MessageBox.Show(lResponse);


                /*string xmlstc = "";
                xmlstc = "<ENVELOPE>";
                xmlstc = xmlstc + "<HEADER>";
                xmlstc = xmlstc + "<VERSION>1</VERSION>";
                xmlstc = xmlstc + "<TALLYREQUEST>Import</TALLYREQUEST>";
                xmlstc = xmlstc + "<TYPE>Data</TYPE>";
                xmlstc = xmlstc + "<ID>Vouchers</ID>";
                xmlstc = xmlstc + "</HEADER>";
                xmlstc = xmlstc + "<BODY>";
                xmlstc = xmlstc + "<DESC>";
                xmlstc = xmlstc + "</DESC>";
                xmlstc = xmlstc + "<DATA>";
               // xmlstc = xmlstc + "<REQUESTDESC>";
               // xmlstc = xmlstc + "<REPORTNAME>Vouchers</REPORTNAME>";
               // xmlstc = xmlstc + "<STATICVARIABLES>";
               // xmlstc = xmlstc + "<SVCURRENTCOMPANY>" + "##SVCURRENTCOMPANY" + "</SVCURRENTCOMPANY>";
               // xmlstc = xmlstc + "</STATICVARIABLES>";
               // xmlstc = xmlstc + "</REQUESTDESC>";

               // xmlstc = xmlstc + "<REQUESTDATA>";


                string strVchNumber = txtVhrNo.Text;
                //strDate = "01/04/2020";
                string strDate = dtpDate.Value.Date.ToShortDateString();
                string strNarration = txtNaration.Text;
                string strAmount = txtAmount.Text;
                string strAccount = txtAccount.Text;
                string strParticular = txtParticular.Text;

                xmlstc = xmlstc + "<TALLYMESSAGE >";
                xmlstc = xmlstc + "<VOUCHER VCHTYPE=" + "\"" + "Receipt" + "\" ACTION=" + "\"" + "Create" + "\">";
               // xmlstc = xmlstc + "<VOUCHERNUMBER>" + strVchNumber + "</VOUCHERNUMBER>";
                xmlstc = xmlstc + "<DATE>" + strDate + "</DATE>";
                xmlstc = xmlstc + "<EFFECTIVEDATE>" + strDate + "</EFFECTIVEDATE>";
                xmlstc = xmlstc + "<NARRATION>" + strNarration + "</NARRATION>";
                xmlstc = xmlstc + "<VOUCHERTYPENAME> Receipt </VOUCHERTYPENAME>";
                xmlstc = xmlstc + "<EFFECTIVEDATE>" + strDate + "</EFFECTIVEDATE>";
                //Credit Ledger
                xmlstc = xmlstc + "<ALLLEDGERENTRIES.LIST>";
                xmlstc = xmlstc + "<LEDGERNAME>" + strParticular + "</LEDGERNAME>";
                xmlstc = xmlstc + "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>";
                xmlstc = xmlstc + "<AMOUNT>" + strAmount + "</AMOUNT>";
                xmlstc = xmlstc + "</ALLLEDGERENTRIES.LIST>";

               //Debit Ledger
                xmlstc = xmlstc + "<ALLLEDGERENTRIES.LIST>";
                xmlstc = xmlstc + "<LEDGERNAME>" + strAccount  + "</LEDGERNAME>";
                xmlstc = xmlstc + "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>";
                xmlstc = xmlstc + "<AMOUNT>-" + strAmount + "</AMOUNT>";
                xmlstc = xmlstc + "</ALLLEDGERENTRIES.LIST>"; 

                xmlstc = xmlstc + "</VOUCHER>";
                xmlstc = xmlstc + "</TALLYMESSAGE>";
               //xmlstc = xmlstc + "</REQUESTDATA>";
                xmlstc = xmlstc + "</DATA>";
                xmlstc = xmlstc + "</BODY>";
                xmlstc = xmlstc + "</ENVELOPE>";  */

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
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

               // string newstring = InstrRev(lResponseStr, "<LINEERROR>");
                int newstring = lResponseStr.LastIndexOf("<LINEERROR>");

                if (newstring == -1 )
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(lResponseStr);
                    //show list of leadger name
                    XmlNodeList xnList = xml.SelectNodes("RESPONSE/LASTVCHID");

                  //  MessageBox.Show("Voucher created with" + xnList[0].InnerText, "Voucher Creation");
                    foreach (XmlNode xn in xnList)
                    {
                        foreach (XmlNode xa in xn)
                        {
                            string data = xa.Value;
                           // listBox1.Items.Add(data);
                            MessageBox.Show("The Master ID is" + data, "Voucher Creation");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("failed to Post");

                }

            }
            catch (Exception)
            {

                throw;
            }
            lResult = lResponseStr;
            return lResult;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRecVoucher_Load(object sender, EventArgs e)
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
                    comboAccount.Items.Add(data);
                    comboParticular.Items.Add(data);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
