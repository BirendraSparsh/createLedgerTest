using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedgerCreation
{
    public partial class frmODBC_Conn : Form
    {
        public frmODBC_Conn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToTally();
          // DataSet TallyCollectionDataSet = ConnectToTally();
           //TallyGridView.DataSource = TallyCollectionDataSet.Tables[0];
           //TallyGridView.AutoGenerateColumns = true;
           //TallyGridView.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        // private static OdbcConnection TallyCollectionConnection = new OdbcConnection("Dsn=TallyODBC_9000;uid='';pwd=''");
        private static OdbcConnection TallyCollectionConnection = new OdbcConnection("Dsn=TallyODBC_9000;uid=Administrator;pwd=admin");
        public  void ConnectToTally()
        {
           // if (TallyCollectionConnection == null || TallyCollectionConnection.State == ConnectionState.Closed) 
          //  {
               // MessageBox.Show("Connection is closed");
         //   }
         //   else 
         //   {
                TallyCollectionConnection.Open();
                //OdbcCommand TallyCommand = new OdbcCommand("Select $NARRATION From TESTER.TallyUser.Vouchers", TallyCollectionConnection);
                OdbcCommand TallyCommand = new OdbcCommand("Select $Name,$Parent,$OpeningBalance,$MAILINGNAME,$LEDSTATENAME,$COUNTRYNAME,$PINCODE From Ledger", TallyCollectionConnection);
                //OdbcCommand TallyCommand = new OdbcCommand("Select $Name,$Parent,$OpeningBalance From Ledger", TallyCollectionConnection);
                //OdbcCommand TallyCommand = new OdbcCommand("SELECT StockItem.$Name, StockItem.$Parent FROM TESTER.TallyUser.StockItem ORDER BY StockItem.$Name", TallyCollectionConnection);
                OdbcDataAdapter TallyDataAdapter = new OdbcDataAdapter(TallyCommand);
                DataSet TallyDataSet = new DataSet();
                //TallyDataAdapter.Fill(TallyDataSet);
                TallyDataAdapter.Fill(TallyDataSet);
                TallyCollectionConnection.Close();
               // return TallyDataSet;
                TallyGridView.DataSource = TallyDataSet.Tables[0];
                TallyGridView.AutoGenerateColumns = true;
                TallyGridView.Visible = true;
                //Connection is open in some way
         //   }
                       
           
            
           

        }

        private void TallyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }

    //class TallyOdbc
    //{
    //   // private static OdbcConnection TallyCollectionConnection = new OdbcConnection("Dsn=TallyODBC_9000;uid='';pwd=''");
    //    private static OdbcConnection TallyCollectionConnection = new OdbcConnection("Dsn=TallyODBC_9000;uid=Administrator;pwd=admin");
    //    public static DataSet ConnectToTally()
    //    {
    //        TallyCollectionConnection.Open();

    //        OdbcCommand TallyCommand = new OdbcCommand("SELECT StockItem.$Name, StockItem.$Parent FROM TESTER.TallyUser.StockItem ORDER BY StockItem.$Name", TallyCollectionConnection);
    //        OdbcDataAdapter TallyDataAdapter = new OdbcDataAdapter(TallyCommand);
    //        DataSet TallyDataSet = new DataSet();
    //        //TallyDataAdapter.Fill(TallyDataSet);
    //        TallyDataAdapter.Fill(TallyDataSet);
    //        TallyCollectionConnection.Close();
    //        return TallyDataSet;          
    //    }

    //}
}
