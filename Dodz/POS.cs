using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Net;
using System.Collections.Specialized;

namespace Dodz
{
    public partial class POS : Form
    {
  
        string pro_name, pro_code;
        int un_price, un_quantity, subtot, tot, pay, change, POSprof, c_quantity, n_quantity, rn_quantity;

        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;
        public POS()
        {
            InitializeComponent();
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (1 == 1)
            {
                MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                con.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dodz.products WHERE products_code = @parm1", con);
                cmd1.Parameters.AddWithValue("@parm1", Search.Text);
                MySqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    Pname.Clear();
                    ProductQuantity.Clear();
                    UnitPrice.Clear();
                    Barcode.Clear();
                    CQuant.Clear();
                    NQuant.Clear();

                    Pname.Text = reader1["products_name"].ToString();
                    ProductQuantity.Text = "1";
                    UnitPrice.Text = reader1["products_price"].ToString();
                    Barcode.Text = reader1["products_code"].ToString();
                    CQuant.Text = reader1["products_quantity"].ToString();
                    proid.Text = reader1["products_id"].ToString();
                    Sdate.Text = reader1["products_exp"].ToString();
                    Search.Clear();
                    Search.Focus();


                    pro_name = Pname.Text;
                    pro_code = Barcode.Text;
                    un_price = Convert.ToInt32(UnitPrice.Text);
                    un_quantity = Convert.ToInt32(ProductQuantity.Text);
                    c_quantity = Convert.ToInt32(CQuant.Text);

                    n_quantity = c_quantity - un_quantity;
                    subtot = un_quantity * un_price;
                    SubTotalPriceBox.Text = Convert.ToString(subtot);
                    tot = subtot + tot;
                    TotalPriceBox.Text = Convert.ToString(tot);
                    NQuant.Text = Convert.ToString(n_quantity);

                    MySqlConnection consale = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                    MySqlDataReader rdr2;

                    string cons2 = "datasource = Localhost; port=3306; username=root; password=";
                    string squery2 = "UPDATE dodz.products SET products_quantity = '" + NQuant.Text + "' WHERE products_id = '" + proid.Text + "'";
                    MySqlConnection con3 = new MySqlConnection(cons2);
                    MySqlCommand cmd3 = new MySqlCommand(squery2, con3);
                    try
                    {
                        con3.Open();
                        rdr2 = cmd3.ExecuteReader();

                        while (rdr2.Read())
                        {
                        }
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (c_quantity <= 10)
                    {
                        WebClient webClient = new WebClient();
                        NameValueCollection nameValueCollection = new NameValueCollection();
                        nameValueCollection.Add("1", textBox1.Text);
                        nameValueCollection.Add("2",  Pname.Text+" "+"is on critical level");
                        nameValueCollection.Add("3", "TR-PAULV073355_8Q1M8");
                        nameValueCollection.Add("passwd", "erqnm{is5g");
                        byte[] send = webClient.UploadValues("https://www.itexmo.com/php_api/api.php", "POST", nameValueCollection);
                        System.Text.UTF8Encoding.UTF8.GetString(send);

                    }

                    if (Sdate.Text == Date.Text)
                    {
                        WebClient webClient = new WebClient();
                        NameValueCollection nameValueCollection = new NameValueCollection();
                        nameValueCollection.Add("1", textBox1.Text);
                        nameValueCollection.Add("2", Pname.Text + " " + "product is expiring");
                        nameValueCollection.Add("3", "TR-PAULV240544_2K7CU");
                        nameValueCollection.Add("passwd", "%#e@&b{eag");
                        byte[] send = webClient.UploadValues("https://www.itexmo.com/php_api/api.php", "POST", nameValueCollection);
                        System.Text.UTF8Encoding.UTF8.GetString(send);
                    }
                    else
                    {
                      
                    }
                        MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");

                        connection.Open();

                        string connectionString = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                        string iquery = "INSERT INTO itemlist(`prod_code`, `prod_name`, `prod_quantity`, `prod_price`) VALUES ('" + Barcode.Text + "','" + Pname.Text + "','" + ProductQuantity.Text + "','" + UnitPrice.Text + "')";

                        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                        MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                        commandDatabase.CommandTimeout = 60;

                        try
                        {
                            databaseConnection.Open();
                            MySqlDataReader myReader = commandDatabase.ExecuteReader();
                            databaseConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        connection.Close();


                        MySqlConnection con2 = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                        con2.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.itemlist", con2);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "itemlist");
                        DGPOS.DataSource = ds.Tables["itemlist"];
                        DGPOS.Columns[0].Visible = false;


                        int nRowIndex = DGPOS.Rows.Count - 1;
                        DGPOS.ClearSelection();
                        // Find last visible row
                        DataGridViewRow row = DGPOS.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).Last();
                        // scroll to last row if necessary
                        DGPOS.FirstDisplayedScrollingRowIndex = DGPOS.Rows.IndexOf(row);
                        // select row
                        row.Selected = true;
                        if (DGPOS.SelectedRows.Count > 0) // make sure user select at least 1 row 
                        {
                            string Num = DGPOS.SelectedRows[0].Cells[0].Value + string.Empty;
                            string Code = DGPOS.SelectedRows[0].Cells[1].Value + string.Empty;
                            string Name = DGPOS.SelectedRows[0].Cells[2].Value + string.Empty;

                            Barcode.Text = Code;
                            Pname.Text = Name;
                            ProdNumBox2.Text = Num;
                        }
                        con2.Close();
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LABEL_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {
            Profit.Hide();
            DBdate.Hide();
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Today.ToString("MM/dd/yy");
            DGPOS.ClearSelection();

            MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dodz.sales WHERE sales_date = @parm1", con);
            cmd1.Parameters.AddWithValue("@parm1", Date.Text);
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                Profit.Text = reader1["sales_profit"].ToString();
                DBdate.Text = reader1["sales_date"].ToString();
                POSprof = Convert.ToInt32(Profit.Text);
            }
            else
            {
                Profit.Text = null;
                DBdate.Text = null;
            }
            con.Close();
        }
        
        private void Barcode_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Pname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Escape(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    Login pg = new Login();
                    pg.ShowDialog();
                }
                if (res == DialogResult.Cancel)
                {
                    Search.Focus();
                    DGPOS.ClearSelection();
                }
            }
        }

        public DataTable GetDataTable(string sql)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["Dodz.Properties.Settings.dodzConnectionString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(constr);
                var dt = new DataTable();
                con.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, con);
                adpt.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);
        }

        public static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
             @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>86mm</PageWidth>
                <PageHeight>114mm</PageHeight>
                <MarginTop>1mm</MarginTop>
                <MarginLeft>0.1mm</MarginLeft>
                <MarginRight>0.1mm</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }


        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
               Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        private void Fs(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                string Content1 = Interaction.InputBox("Enter Payment: ", "Payment");

                if (Content1 == "")
                {
                    
                }
                else
                {   
                    pay = Convert.ToInt32(Content1);
                    if (pay < tot)
                    {
                        MessageBox.Show("Can't Complete transaction due to insufficient payment.");
                    }
                    else
                    {
                        change = pay - tot;
                        Change.Text = Convert.ToString(change);
                        POSprof = tot + POSprof;
                        MySqlConnection consold = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                        MySqlDataReader rdr1;

                        string cons = "datasource = Localhost; port=3306; username=root; password=";
                        string squery = "INSERT INTO dodz.sold (`sold_change`, `sold_total`, `sold_pay`) VALUES ('" + change + "', '" + tot + "', '" + Content1 + "')";
                        MySqlConnection con1 = new MySqlConnection(cons);
                        MySqlCommand cmd1 = new MySqlCommand(squery, con1);
                        try
                        {
                            con1.Open();
                            rdr1 = cmd1.ExecuteReader();

                            while (rdr1.Read())
                            {
                            }
                            con1.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        if (Date.Text == DBdate.Text)
                        {
                            MySqlConnection consale = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                            MySqlDataReader rdr2;

                            string cons2 = "datasource = Localhost; port=3306; username=root; password=";
                            string squery2 = "UPDATE dodz.sales SET sales_date = '" + Date.Text + "', sales_profit = '" + POSprof + "' WHERE sales_date = '" + Date.Text + "'";
                            MySqlConnection con3 = new MySqlConnection(cons2);
                            MySqlCommand cmd3 = new MySqlCommand(squery2, con3);
                            try
                            {
                                con3.Open();
                                rdr2 = cmd3.ExecuteReader();

                                while (rdr2.Read())
                                {
                                }
                                con3.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (Date.Text != DBdate.Text || DBdate.Text != Date.Text)
                        {
                            MySqlConnection consale = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                            MySqlDataReader rdr;

                            string connection = "datasource = Localhost; port=3306; username=root; password=";
                            string squery0 = "INSERT INTO dodz.sales (`sales_date`, `sales_profit`) VALUES ('" + Date.Text + "', '" + tot + "')";
                            MySqlConnection conn1 = new MySqlConnection(connection);
                            MySqlCommand cmd11 = new MySqlCommand(squery0, conn1);
                            try
                            {
                                conn1.Open();
                                rdr = cmd11.ExecuteReader();

                                while (rdr.Read())
                                {

                                }
                                conn1.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        string sql = "select * from dodz.itemlist";
                        var dt = GetDataTable(sql);
                        LocalReport report = new LocalReport();
                        string path = Path.GetDirectoryName(Application.ExecutablePath);
                        string fullpath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Report\rptItemlistMemo.rdlc";
                        report.ReportPath = fullpath;
                        report.DataSources.Add(new ReportDataSource("dsItemlist", dt));

                        int printQty = Convert.ToInt32(printtimes.Text);
                        for (int i = 0; i < printQty; i++)
                        {
                            PrintToPrinter(report);
                        }


                        MySqlConnection connection20 = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                        MySqlDataReader rdr20;

                        string c20 = "datasource = Localhost; port = 3306; username = root; password=";
                        string query = "DELETE FROM dodz.itemlist;";
                        MySqlConnection con2 = new MySqlConnection(c20);
                        MySqlCommand cmd2 = new MySqlCommand(query, con2);
                        try
                        {
                            con2.Open();
                            rdr20 = cmd2.ExecuteReader();

                            while (rdr20.Read())
                            {
                            }
                            con2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.itemlist", conn);
                        connection20.Open();
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "itemlist");
                        DGPOS.DataSource = ds.Tables["itemlist"];
                        connection20.Close();

                        Pname.Clear();
                        ProductQuantity.Clear();
                        Barcode.Clear();
                        UnitPrice.Clear();
                        SubTotalPriceBox.Clear();
                        TotalPriceBox.Clear();
                        Change.Clear();
                        tot = 0;
                        subtot = 0;

                        Search.Focus();

                        MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                        con.Open();

                        MySqlCommand cmd90 = new MySqlCommand("SELECT * FROM dodz.sales WHERE sales_date = @parm1", con);
                        cmd90.Parameters.AddWithValue("@parm1", Date.Text);
                        MySqlDataReader reader1;
                        reader1 = cmd90.ExecuteReader();
                        if (reader1.Read())
                        {
                            Profit.Text = reader1["sales_profit"].ToString();
                            DBdate.Text = reader1["sales_date"].ToString();
                            POSprof = Convert.ToInt32(Profit.Text);
                        }
                        else
                        {
                            Profit.Text = null;
                            DBdate.Text = null;
                        }
                        con.Close();
                    }
                }
             
            }

            if (e.KeyCode == Keys.F1)
            {
                string Content2 = Interaction.InputBox("Enter Quantity: ", "Quantity");
                if (Content2 == "")
                {
                }
                else if (Convert.ToInt32(Content2) < 1)
                {
                    MessageBox.Show("Can't input product lower than 1");
                }
                else
                {
                    MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                    MySqlDataReader rdr;

                    string con = "datasource = Localhost; port = 3306; username = root; password=";
                    string query = "update dodz.itemlist set prod_quantity = '" + ProductQuantity.Text + "', prod_price = '" + subtot + "' where prod_num = '" + ProdNumBox.Text + "';";
                    MySqlConnection con2 = new MySqlConnection(con);
                    MySqlCommand cmd2 = new MySqlCommand(query, con2);

                    con2.Open();
                    rdr = cmd2.ExecuteReader();


                    while (rdr.Read())
                    {
                    }
                    con2.Close();

                    MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `prod_code`, `prod_name`, `prod_quantity`, `prod_price` FROM dodz.itemlist", conn);

                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "itemlist");
                    DGPOS.DataSource = ds.Tables["itemlist"];
                    connection.Close();

                }
                if (ProductQuantity.Text == Content2)
                {

                }
                int nRowIndex = DGPOS.Rows.Count - 1;
                DGPOS.ClearSelection();
                // Find last visible row
                DataGridViewRow row = DGPOS.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).Last();
                // scroll to last row if necessary
                DGPOS.FirstDisplayedScrollingRowIndex = DGPOS.Rows.IndexOf(row);
                // select row
                row.Selected = true;
            }
          
        }

        private void QuantityButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGPOS_click(object sender, EventArgs e)
        {

        }

        private void DGPOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGPOS.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Num = DGPOS.SelectedRows[0].Cells[0].Value + string.Empty;
                string Code = DGPOS.SelectedRows[0].Cells[1].Value + string.Empty;
                string Name = DGPOS.SelectedRows[0].Cells[2].Value + string.Empty;

                Barcode.Text = Code;
                Pname.Text = Name;
                ProdNumBox.Text = Num;
            }
        }

        private void DGPOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int nRowIndex = DGPOS.Rows.Count - 1;
                DGPOS.ClearSelection();
                // Find last visible row
                DataGridViewRow row = DGPOS.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).Last();
                // scroll to last row if necessary
                DGPOS.FirstDisplayedScrollingRowIndex = DGPOS.Rows.IndexOf(row);
                // select row
                row.Selected = true;
                if (DGPOS.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    string Num = DGPOS.SelectedRows[0].Cells[0].Value + string.Empty;
                    string Code = DGPOS.SelectedRows[0].Cells[1].Value + string.Empty;
                    string Name = DGPOS.SelectedRows[0].Cells[2].Value + string.Empty;

                    Barcode.Text = Code;
                    Pname.Text = Name;
                    ProdNumBox.Text = Num;
                }
                Search.Focus();
            }
        }

        private void DGPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string Content2 = Interaction.InputBox("Enter Quantity: ", "Quantity");

                if (Content2 == "")
                {

                }
                else
                {
                    ProductQuantity.Text = "1";

                    ProductQuantity.Text = Content2;
                    un_quantity = Convert.ToInt32(Content2);
                    subtot = un_quantity * un_price;
                    tot = subtot + tot;
                    SubTotalPriceBox.Text = Convert.ToString(subtot);
                    TotalPriceBox.Text = Convert.ToString(tot);
                    tot = tot - un_price;
                    TotalPriceBox.Text = Convert.ToString(tot);
                }
                if (ProductQuantity.Text == Content2)
                {
                    MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                    MySqlDataReader rdr;
                    if (string.IsNullOrEmpty(Content2))
                    {
                        MessageBox.Show("Please fill empty field");
                    }
                    else
                    {
                        string con = "datasource = Localhost; port = 3306; username = root; password=";
                        string query = "update dodz.itemlist set prod_quantity = '" + ProductQuantity.Text + "', prod_price = '" + subtot + "' where prod_num = '" + ProdNumBox.Text + "';";
                        MySqlConnection con2 = new MySqlConnection(con);
                        MySqlCommand cmd2 = new MySqlCommand(query, con2);

                        con2.Open();
                        rdr = cmd2.ExecuteReader();
                        while (rdr.Read())
                        {
                        }
                        con2.Close();

                        MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `prod_code`, `prod_name`, `prod_quantity`, `prod_price` FROM dodz.itemlist", conn);

                        connection.Open();
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "itemlist");
                        DGPOS.DataSource = ds.Tables["itemlist"];
                        connection.Close();
                    }

                }
                int nRowIndex = DGPOS.Rows.Count - 1;
                DGPOS.ClearSelection();
                // Find last visible row
                DataGridViewRow row = DGPOS.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).Last();
                // scroll to last row if necessary
                DGPOS.FirstDisplayedScrollingRowIndex = DGPOS.Rows.IndexOf(row);
                // select row
                row.Selected = true;
            }

            if (e.KeyCode == Keys.F10)
            {
                tot = tot - subtot;
                TotalPriceBox.Text = Convert.ToString(tot);

                MySqlConnection consale = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                MySqlDataReader rdr2;

                string cons2 = "datasource = Localhost; port=3306; username=root; password=";
                string squery2 = "UPDATE dodz.products SET products_quantity = '" + RNQuant.Text + "' WHERE products_id = '" + proid.Text + "'";
                MySqlConnection con3 = new MySqlConnection(cons2);
                MySqlCommand cmd3 = new MySqlCommand(squery2, con3);
                try
                {
                    con3.Open();
                    rdr2 = cmd3.ExecuteReader();

                    while (rdr2.Read())
                    {
                    }
                    con3.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
                MySqlDataReader rdr;

                string con = "datasource = Localhost; port = 3306; username = root; password=";
                string query = "DELETE from dodz.itemlist WHERE prod_num='" + ProdNumBox2.Text + "';";
                MySqlConnection con2 = new MySqlConnection(con);
                MySqlCommand cmd2 = new MySqlCommand(query, con2);
                try
                {
                    con2.Open();
                    rdr = cmd2.ExecuteReader();

                    while (rdr.Read())
                    {
                    }
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.itemlist", conn);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "itemlist");
                DGPOS.DataSource = ds.Tables["itemlist"];
                connection.Close();

                Pname.Clear();
                ProductQuantity.Clear();
                Barcode.Clear();
                UnitPrice.Clear();
                SubTotalPriceBox.Clear();
                TotalPriceBox.Clear();
                Change.Clear();
                tot = 0;
                subtot = 0;

                Search.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void DGPOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGPOS.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Num = DGPOS.SelectedRows[0].Cells[0].Value + string.Empty;
                string Code = DGPOS.SelectedRows[0].Cells[1].Value + string.Empty;
                string Name = DGPOS.SelectedRows[0].Cells[2].Value + string.Empty;

                Barcode.Text = Code;
                Pname.Text = Name;
                ProdNumBox2.Text = Num;
            }

            rn_quantity = c_quantity + un_quantity;
            RNQuant.Text = Convert.ToString(rn_quantity);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }

}
