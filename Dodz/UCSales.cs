using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Dodz
{
    public partial class UCSales : UserControl
    {

        private static UCSales _instance;

        public static UCSales Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCSales();
                return _instance;
            }
        }

        public UCSales()
        {
            InitializeComponent();
        }

        private void UCSales_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Date.Text = DateTime.Today.ToString("MM/dd/yy");

            this.salesTableAdapter.Fill(this.dodzDataSet.sales);

            chart1.Series["Date"].XValueMember = "sales_date";
            chart1.Series["Date"].YValueMembers = "sales_profit";
            chart1.DataSource = dodzDataSet.sales;
            chart1.DataBind();

            DGSales.Columns[0].HeaderText = "Sales ID";
            DGSales.Columns[1].HeaderText = "Sales Date";
            DGSales.Columns[2].HeaderText = "Total Sales";


            int nRowIndex = DGSales.Rows.Count - 1;
            DGSales.ClearSelection();
            // Find last visible row
            DataGridViewRow row = DGSales.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGSales.FirstDisplayedScrollingRowIndex = DGSales.Rows.IndexOf(row);
            // select row
            row.Selected = true;

            MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dodz.sales WHERE sales_date = @parm1", con);
            cmd1.Parameters.AddWithValue("@parm1", Date.Text);
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                SDate.Text = reader1["sales_date"].ToString();
                SProfit.Text = reader1["sales_profit"].ToString();
            }
            else
            {
                SDate.Text = "MM/DD/YY";
                SProfit.Text = "0";
            }
        }

        private void DGSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //Starting Connection String
            MySqlConnection DGSalesCon = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            DGSalesCon.Open();

            //SQL Command Query
            MySqlCommand DGSalesCMD = new MySqlCommand("SELECT * FROM dodz.sales WHERE sales_date BETWEEN '" + dateTimePicker1.Text + "' AND  '" + dateTimePicker2.Text + "' ORDER BY sales_date ASC", DGSalesCon);
            MySqlDataAdapter DGSalesADP = new MySqlDataAdapter();
            DGSalesADP.SelectCommand = DGSalesCMD;
            DataTable dt = new DataTable(); //Data Table/Datagrid view content filling
            dt.Clear();
            DGSalesADP.Fill(dt);
            DGSales.DataSource = dt;
            DGSalesCon.Close();

            //Chart Data
            this.salesTableAdapter.Fill(this.dodzDataSet.sales);

            chart1.Series["Date"].XValueMember = "sales_date";
            chart1.Series["Date"].YValueMembers = "sales_profit";
            chart1.DataSource = dt;
            chart1.DataBind();

            //NOTE: chart1.Datasource is equal to dt which is the variable used for DGSales (datagridview) and not the dataset itself
            //So upon clicking the button, the datagridview and chart will refresh with the same data. 
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
       
    }
}
