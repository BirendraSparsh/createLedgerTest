using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LedgerCreation
{
    public partial class frmStockSummary : Form
    {
        public frmStockSummary()
        {
            InitializeComponent();
        }

        private void frmStockSummary_Load(object sender, EventArgs e)
        {

        }

        public void StockSummaryXmlPost()
        {
            /*<!--THIS WILL FETCH STOCK SUMMARY DETAILS PROGRAMMATICALLY-->
            <!--WHICH IS EQUIVALENT TO USING THE FOLLOWING OPTION MANUALLY IN TALLY-->
            <!--OPTION:-->
            <!--Gateway of Tally @STOCK SUMMARY--> */
            // file stksumm1.xml

            string RequestXML = "<ENVELOPE>" +
                                "<HEADER>" +
                                "<TALLYREQUEST>Export Data</TALLYREQUEST>" +
                                "</HEADER>" +
                                "<BODY>" +
                                "<EXPORTDATA>" +
                                "<REQUESTDESC>" +
                                "<STATICVARIABLES>" +
                                "</STATICVARIABLES>" +
                                "<REPORTNAME>Stock Summary</REPORTNAME>" +
                                "</REQUESTDESC>" +
                                "</EXPORTDATA>" +
                                "</BODY>" +
                                "</ENVELOPE>";

            string TallyResponse = TallyXml.ConnectToTally(RequestXML);

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(TallyResponse);
            //show list of node name
            XmlNodeList xmlStockItemList = xml.SelectNodes("ENVELOPE/DSPSTKINFO/DSPSTKCL");
            //XmlNodeList xmlNodeList = xml.SelectNodes("//BODY/IMPORTDATA/REQUESTDATA/TALLYMESSAGE");
            //// XmlNodeList nodes = xml.GetElementsByTagName("NAME");


            List<string> listOfName = new List<string>();  // list of xml element Name
            List<string> listOfValue = new List<string>();  // list of xml element Value
            foreach (XmlNode xmlNode in xmlStockItemList)
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

            

        }

        public string ConvertStringToDate(string strDate)
        {
            string strYear = strDate.Substring(0, 4);
            string strMonth = strDate.Substring(4, 2);
            string strDay = strDate.Substring(6, 2);
            string strDateConbine = strDay + "/" + strMonth + "/" + strYear;
            return strDateConbine;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            StockSummaryXmlPost();
        }
    }
}
