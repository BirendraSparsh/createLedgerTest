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
    public partial class frmVoucherAlter : Form
    {
        public frmVoucherAlter()
        {
            InitializeComponent();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                string strVCHNo = ""; string strDate = ""; string strVCHType = ""; string strNewNarr = ""; string strNewDate = "";
                strVCHNo = txtVCHNo.Text;
                strDate = dtpDate.Value.Date.ToShortDateString();
                strVCHType = txtVCHType.Text;
                strNewNarr = txtNewNarr.Text;
                strNewDate = dtpNewDate.Value.Date.ToShortDateString();
                string xmlstc = "<ENVELOPE><HEADER>" +

                             "<VERSION>1</VERSION>" +

                             "<TALLYREQUEST>Import</TALLYREQUEST>" +

                             "<TYPE>Data</TYPE>" +

                             "<ID>Vouchers</ID>" +

                             "</HEADER>" +

                             "<BODY>" +

                             "<DESC>" +

                             "</DESC>" +

                             "<DATA>" +

                             "<TALLYMESSAGE>" +

                             "<VOUCHER DATE=" + "\"" + strDate + "\" TAGNAME=" + "\"" + "Voucher Number" + "\" TAGVALUE=" + "\"" + strVCHNo + "\" Action=" + "\"" + "Alter" + "\" VCHTYPE=" + "\"" + strVCHType + "\">" +

                             "<DATE> " + strNewDate + "</DATE>" +
                            
                             "<NARRATION>" + strNewNarr + "</NARRATION>" +
                         
                             "</VOUCHER>" +

                             "</TALLYMESSAGE>" +

                             "</DATA>" +

                              "</BODY>" +

                              "</ENVELOPE>";

                String xml = xmlstc;
                String lResponse = SendReqst(xml);
                MessageBox.Show(lResponse);

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

                if (newstring == -1)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(lResponseStr);
                    //show list of leadger name
                    XmlNodeList xnList = xml.SelectNodes("ENVELOPE/BODY/DATA/IMPORTRESULT/LASTVCHID");

                    //  MessageBox.Show("Voucher created with" + xnList[0].InnerText, "Voucher Creation");
                    foreach (XmlNode xn in xnList)
                    {
                        foreach (XmlNode xa in xn)
                        {
                            string data = xa.Value;
                            // listBox1.Items.Add(data);
                            MessageBox.Show("The Master ID is = " + data, "Voucher Creation");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("failed to Alter");

                }

            }
            catch (Exception)
            {

                throw;
            }
            lResult = lResponseStr;
            return lResult;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
