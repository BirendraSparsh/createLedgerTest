using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedgerCreation
{
    public class TallyXml
    {
        private static WebRequest TallyRequest;
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
            catch (Exception ex)
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
