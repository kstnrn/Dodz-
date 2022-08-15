using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dodz
{
    public partial class UCSalesReport : UserControl
    {
        private static UCSalesReport _instance;

        public static UCSalesReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCSalesReport();
                return _instance;
            }
        }

        public UCSalesReport()
        {
            InitializeComponent();
        }

        private void UCSalesReport_Load(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.dodzDataSet.sales);

            this.reportViewer1.RefreshReport();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            MySqlConnection DGSalesCon = new MySqlConnection ("datasource = localhost; port = 3306; username = root; password=");
            DGSalesCon.Open();
     
            MySqlCommand DGSalesCMD = new MySqlCommand("SELECT * FROM dodz.sales WHERE sales_date BETWEEN '" + dateTimePicker1.Text + "' AND  '" + dateTimePicker2.Text + "' ORDER BY sales_date ASC", DGSalesCon);
            MySqlDataAdapter DGSalesADP = new MySqlDataAdapter();
            DGSalesADP.SelectCommand = DGSalesCMD;
            DataTable dt = new DataTable();
            dt.Clear();
            DGSalesADP.Fill(dt);
            DGSales.DataSource = dt;
            DGSalesCon.Close();


            //code ended today
            this.reportViewer1.RefreshReport();
        }
    }
}
