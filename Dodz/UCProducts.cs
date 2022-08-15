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
    public partial class UCProducts : UserControl
    {
        private static UCProducts _instance;

        int a, b;
        public static UCProducts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCProducts();
                return _instance;
            }
        }

        public UCProducts()
        {
            InitializeComponent();
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {

            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToShortDateString();

            dateTimePicker1.Text = Date.Text;

            DateTime chosendate = dateTimePicker1.Value;

            int day1 = chosendate.Day;
            int month1 = chosendate.Month;
            int year1 = chosendate.Year;

            String yearString = year1.ToString();

            String lastTwoDigits = yearString.Substring(2);

            int finalTwoValue1 = int.Parse(lastTwoDigits);
            //////////////////////////////////////////////////////////////
            DateTime chosendate2 = DTPicker.Value;

            int day2 = chosendate2.Day;
            int month2 = chosendate2.Month;
            int year2 = chosendate2.Year;

            String yearString2 = year2.ToString();

            String lastTwoDigits2 = yearString2.Substring(2);

            int finalTwoValue2 = int.Parse(lastTwoDigits2);

            label15.Text = "Day: " + day2;
            label16.Text = "Month: " + month2;
            label17.Text = "Year: " + finalTwoValue2;
            label12.Text = "Day: " + day1;
            label13.Text = "Month: " + month1;
            label14.Text = "Year: " + finalTwoValue1;
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.products", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "products");
                DGProduct.DataSource = ds.Tables["products"];
                Search.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.psession", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "psession");
                DSProd1.DataSource = ds.Tables["psession"];
                Search.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlConnection conn = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlCommand command;
            MySqlDataReader rdr;

            conn.Open();
            string selectQuery = "SELECT * FROM dodz.session ORDER BY ses_id DESC limit 1;";
            command = new MySqlCommand(selectQuery, conn);
            rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                User.Text = rdr["user_name"].ToString();
            }

            DGProduct.Columns[0].Visible = false;
            DGProduct.Columns[1].HeaderText = "Barcode";
            DGProduct.Columns[2].HeaderText = "Product Name";
            DGProduct.Columns[3].HeaderText = "Quantity";
            DGProduct.Columns[4].HeaderText = "OR";
            DGProduct.Columns[5].HeaderText = "Price";
            DGProduct.Columns[6].HeaderText = "EXP Date";


            DSProd1.Columns[0].Visible = false;
            DSProd1.Columns[1].HeaderText = "Username";
            DSProd1.Columns[2].HeaderText = "Product Name";
            DSProd1.Columns[3].HeaderText = "Modifications";
            DSProd1.Columns[4].HeaderText = "Time";
            DSProd1.Columns[5].HeaderText = "Date";
        }

        private void Add_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Text = Date.Text;

            DateTime chosendate = dateTimePicker1.Value;

            int day1 = chosendate.Day;
            int month1 = chosendate.Month;
            int year1 = chosendate.Year;

            String yearString = year1.ToString();

            String lastTwoDigits = yearString.Substring(2);

            int finalTwoValue1 = int.Parse(lastTwoDigits);

            label12.Text = "Day: " + day1;
            label13.Text = "Month: " + month1;
            label14.Text = "Year: " + finalTwoValue1;
            ///////////////////////////////////////////
            DateTime chosendate2 = DTPicker.Value;

            int day2 = chosendate2.Day;
            int month2 = chosendate2.Month;
            int year2 = chosendate2.Year;

            String yearString2 = year2.ToString();

            String lastTwoDigits2 = yearString2.Substring(2);

            int finalTwoValue2 = int.Parse(lastTwoDigits2);

            label15.Text = "Day: " + day2;
            label16.Text = "Month: " + month2;
            label17.Text = "Year: " + finalTwoValue2;
            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlCommand command;
            MySqlDataReader rdr;

            connection.Open();
            string selectQuery = "SELECT * FROM dodz.products WHERE products_code = '" + Barcode.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Product is Existing");
            }
            else if (string.IsNullOrEmpty(Barcode.Text) || string.IsNullOrEmpty(Pname.Text) || string.IsNullOrEmpty(Quantity.Text) || string.IsNullOrEmpty(Price.Text))
            {
                MessageBox.Show("Please fill empty field");
            }
            else if (month2 < month1)
            {
                MessageBox.Show("Selected Month is lower than present Month");
            }
            else if (finalTwoValue2 < finalTwoValue1)
            {
                MessageBox.Show("Selected Year is lower than present year");
            }
            else
            {
                a = Convert.ToInt32(Quantity.Text);
                b = Convert.ToInt32(Price.Text);
                if (a < 1)
                {
                    MessageBox.Show("Cannot Put Negative Quantity!");
                }
                else if (b < 1)
                {
                    MessageBox.Show("Cannot Put Negative Price!");
                }
                else
                {
                    if (day2 < day1)
                    {
                        DialogResult res = MessageBox.Show("The Day Value is lower than present day, do you still want to add this product?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            string connectionString = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                            string iquery = "INSERT INTO products(`products_code`, `products_name`, `products_price`, `products_quantity`, `products_exp`, `products_r`) VALUES ('" + Barcode.Text + "','" + Pname.Text + "','" + Price.Text + "','" + Quantity.Text + "','" + DTPicker.Text + "', '" + ORbox.Text + "')";

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

                            MessageBox.Show("Product Added!");
                        }
                    }
                    else
                    {
                        string connectionString = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                        string iquery = "INSERT INTO products(`products_code`, `products_name`, `products_price`, `products_quantity`, `products_exp`, `products_r`) VALUES ('" + Barcode.Text + "','" + Pname.Text + "','" + Price.Text + "','" + Quantity.Text + "','" + DTPicker.Text + "', '" + ORbox.Text + "')";

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

                        MessageBox.Show("Product Added!");
                    }
                }
            }
            connection.Close();

            MySqlConnection connection2 = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");

            connection2.Open();

            string connectionString2 = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
            string iquery2 = "INSERT INTO psession(`Username`, `Time`, `Date`, `Session`, `Product_Name`) VALUES ('" + User.Text + "','" + Time.Text + "','" + Date.Text + "','" + "Add Product" + "', '" + Pname.Text + "')";

            MySqlConnection databaseConnection2 = new MySqlConnection(connectionString2);
            MySqlCommand commandDatabase2 = new MySqlCommand(iquery2, databaseConnection2);
            commandDatabase2.CommandTimeout = 60;

            try
            {
                databaseConnection2.Open();
                MySqlDataReader myReader = commandDatabase2.ExecuteReader();
                databaseConnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Barcode.Text = "";
            Pname.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            ORbox.Text = "";

            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM dodz.psession", connection);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "psession");
            DSProd1.DataSource = ds2.Tables["psession"];

            connection.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.products", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "products");
            DGProduct.DataSource = ds.Tables["products"];

            DGProduct.Columns[0].Visible = false;
            DGProduct.Columns[1].HeaderText = "Barcode";
            DGProduct.Columns[2].HeaderText = "Product Name";
            DGProduct.Columns[3].HeaderText = "Quantity";
            DGProduct.Columns[4].HeaderText = "OR";
            DGProduct.Columns[5].HeaderText = "Price";
            DGProduct.Columns[6].HeaderText = "EXP Date";
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = Date.Text;

            DateTime chosendate = dateTimePicker1.Value;

            int day1 = chosendate.Day;
            int month1 = chosendate.Month;
            int year1 = chosendate.Year;

            String yearString = year1.ToString();

            String lastTwoDigits = yearString.Substring(2);

            int finalTwoValue1 = int.Parse(lastTwoDigits);

            label12.Text = "Day: " + day1;
            label13.Text = "Month: " + month1;
            label14.Text = "Year: " + finalTwoValue1;
            ///////////////////////////////////////////
            DateTime chosendate2 = DTPicker.Value;

            int day2 = chosendate2.Day;
            int month2 = chosendate2.Month;
            int year2 = chosendate2.Year;

            String yearString2 = year2.ToString();

            String lastTwoDigits2 = yearString2.Substring(2);

            int finalTwoValue2 = int.Parse(lastTwoDigits2);

            label15.Text = "Day: " + day2;
            label16.Text = "Month: " + month2;
            label17.Text = "Year: " + finalTwoValue2;

            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlDataReader rdr;
            if (string.IsNullOrEmpty(Barcode.Text) || string.IsNullOrEmpty(Pname.Text) || string.IsNullOrEmpty(Quantity.Text) || string.IsNullOrEmpty(Price.Text))
            {
                MessageBox.Show("Please fill empty field");
            }
            else if (month2 < month1)
            {
                MessageBox.Show("Selected Month is lower than present Month");
            }
            else if (finalTwoValue2 < finalTwoValue1)
            {
                MessageBox.Show("Selected Year is lower than present Year ");
            }
            else
            {
                a = Convert.ToInt32(Quantity.Text);
                b = Convert.ToInt32(Price.Text);
                if (a < 1)
                {
                    MessageBox.Show("Cannot put negative Quantity!");
                }
                else if (b < 1)
                {
                    MessageBox.Show("Cannot put negative Price!");
                }
                else
                {
                    if (day2 < day1)
                    {
                        DialogResult res = MessageBox.Show("The Day Value is lower than present day, do you still want to add this product?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            string con = "datasource = Localhost; port = 3306; username = root; password=";
                            string query = "update dodz.products set products_code = '" + this.Barcode.Text + "',products_name = '" + this.Pname.Text + "',products_quantity = '" + this.Quantity.Text + "',products_price = '" + this.Price.Text + "',products_exp = '" + DTPicker.Text + "',products_r = '" + ORbox.Text + "' WHERE products_code='" + this.Barcode.Text + "';";
                            MySqlConnection con2 = new MySqlConnection(con);
                            MySqlCommand cmd2 = new MySqlCommand(query, con2);

                            con2.Open();
                            rdr = cmd2.ExecuteReader();
                            MessageBox.Show("Products Updated!");

                            while (rdr.Read())
                            {

                            }
                            con2.Close();

                            MySqlConnection connection2 = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");

                            connection2.Open();

                            string connectionString2 = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                            string iquery2 = "INSERT INTO psession(`Username`, `Time`, `Date`, `Session`, `Product_Name`) VALUES ('" + User.Text + "','" + Time.Text + "','" + Date.Text + "','" + "Product Updated" + "', '" + Pname.Text + "')";

                            MySqlConnection databaseConnection2 = new MySqlConnection(connectionString2);
                            MySqlCommand commandDatabase2 = new MySqlCommand(iquery2, databaseConnection2);
                            commandDatabase2.CommandTimeout = 60;

                            try
                            {
                                databaseConnection2.Open();
                                MySqlDataReader myReader = commandDatabase2.ExecuteReader();
                                databaseConnection2.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            Barcode.Text = "";
                            Pname.Text = "";
                            Quantity.Text = "";
                            Price.Text = "";
                            ORbox.Text = "";
                        }
                    }
                    else
                    {
                        string con = "datasource = Localhost; port = 3306; username = root; password=";
                        string query = "update dodz.products set products_code = '" + this.Barcode.Text + "',products_name = '" + this.Pname.Text + "',products_quantity = '" + this.Quantity.Text + "',products_price = '" + this.Price.Text + "',products_exp = '" + DTPicker.Text + "',products_r = '" + ORbox.Text + "' WHERE products_code='" + this.Barcode.Text + "';";
                        MySqlConnection con2 = new MySqlConnection(con);
                        MySqlCommand cmd2 = new MySqlCommand(query, con2);

                        con2.Open();
                        rdr = cmd2.ExecuteReader();
                        MessageBox.Show("Products Updated!");

                        while (rdr.Read())
                        {

                        }
                        con2.Close();

                        MySqlConnection connection2 = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");

                        connection2.Open();

                        string connectionString2 = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                        string iquery2 = "INSERT INTO psession(`Username`, `Time`, `Date`, `Session`, `Product_Name`) VALUES ('" + User.Text + "','" + Time.Text + "','" + Date.Text + "','" + "Product Updated" + "', '" + Pname.Text + "')";

                        MySqlConnection databaseConnection2 = new MySqlConnection(connectionString2);
                        MySqlCommand commandDatabase2 = new MySqlCommand(iquery2, databaseConnection2);
                        commandDatabase2.CommandTimeout = 60;

                        try
                        {
                            databaseConnection2.Open();
                            MySqlDataReader myReader = commandDatabase2.ExecuteReader();
                            databaseConnection2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        Barcode.Text = "";
                        Pname.Text = "";
                        Quantity.Text = "";
                        Price.Text = "";
                        ORbox.Text = "";
                    }
                }
            }

            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM dodz.psession", connection);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "psession");
            DSProd1.DataSource = ds2.Tables["psession"];

            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.products", conn);

            connection.Open();
            DataSet ds = new DataSet();
            adapter.Fill(ds, "products");
            DGProduct.DataSource = ds.Tables["products"];
            connection.Close();

            DGProduct.Columns[0].Visible = false;
            DGProduct.Columns[1].HeaderText = "Barcode";
            DGProduct.Columns[2].HeaderText = "Product Name";
            DGProduct.Columns[3].HeaderText = "Quantity";
            DGProduct.Columns[4].HeaderText = "OR";
            DGProduct.Columns[5].HeaderText = "Price";
            DGProduct.Columns[6].HeaderText = "EXP Date";  
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlDataReader rdr;

            string con = "datasource = Localhost; port = 3306; username = root; password=";
            string query = "DELETE from dodz.products WHERE products_code='" + Barcode.Text + "';";
            MySqlConnection con2 = new MySqlConnection(con);
            MySqlCommand cmd2 = new MySqlCommand(query, con2);
            try
            {
                MySqlConnection connection2 = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");

                connection2.Open();

                string connectionString2 = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                string iquery2 = "INSERT INTO psession(`Username`, `Time`, `Date`, `Session`, `Product_Name`) VALUES ('" + User.Text + "','" + Time.Text + "','" + Date.Text + "','" + "Product Deleted" + "', '" + Pname.Text + "')";

                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString2);
                MySqlCommand commandDatabase2 = new MySqlCommand(iquery2, databaseConnection2);
                commandDatabase2.CommandTimeout = 60;

                try
                {
                    databaseConnection2.Open();
                    MySqlDataReader myReader = commandDatabase2.ExecuteReader();
                    databaseConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Barcode.Text = "";
                Pname.Text = "";
                Quantity.Text = "";
                Price.Text = "";
                ORbox.Text = "";

                con2.Open();
                rdr = cmd2.ExecuteReader();
                MessageBox.Show("Data Deleted");

                while (rdr.Read())
                {
                }
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM dodz.psession", connection);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "psession");
            DSProd1.DataSource = ds2.Tables["psession"];

            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.products", conn);

            connection.Open();

            DataSet ds = new DataSet();
            adapter.Fill(ds, "products");
            DGProduct.DataSource = ds.Tables["products"];
            connection.Close();

            DGProduct.Columns[0].Visible = false;
            DGProduct.Columns[1].HeaderText = "Barcode";
            DGProduct.Columns[2].HeaderText = "Product Name";
            DGProduct.Columns[3].HeaderText = "Quantity";
            DGProduct.Columns[4].HeaderText = "OR";
            DGProduct.Columns[5].HeaderText = "Price";
            DGProduct.Columns[6].HeaderText = "EXP Date";
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Search")
            {
                Search.Text = "";
                Search.ForeColor = Color.Black;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Search";
                Search.ForeColor = Color.Silver;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dodz.products WHERE products_code = @parm1 OR products_name = '" + Search.Text + "'", con);
            cmd1.Parameters.AddWithValue("@parm1", Search.Text);
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                Barcode.Text = reader1["products_code"].ToString();
                Pname.Text = reader1["products_name"].ToString();
                Quantity.Text = reader1["products_quantity"].ToString();
                Price.Text = reader1["products_price"].ToString();
                ORbox.Text = reader1["OR"].ToString();
            }
            else if (string.IsNullOrEmpty(Barcode.Text))
            {
                MessageBox.Show("No Data Found");
            }
            Search.Text = null;
            con.Close();

            DGProduct.Columns[0].Visible = false;
            DGProduct.Columns[1].HeaderText = "Barcode";
            DGProduct.Columns[2].HeaderText = "Product Name";
            DGProduct.Columns[3].HeaderText = "Quantity";
            DGProduct.Columns[4].HeaderText = "OR";
            DGProduct.Columns[5].HeaderText = "Price";
            DGProduct.Columns[6].HeaderText = "EXP Date";
        }

        private void DGProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGProduct.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string id = DGProduct.SelectedRows[0].Cells[1].Value + string.Empty;
                string name = DGProduct.SelectedRows[0].Cells[2].Value + string.Empty;
                string quantity = DGProduct.SelectedRows[0].Cells[3].Value + string.Empty;
                string or = DGProduct.SelectedRows[0].Cells[4].Value + string.Empty;
                string price = DGProduct.SelectedRows[0].Cells[5].Value + string.Empty;

                Barcode.Text = id;
                Pname.Text = name;
                Quantity.Text = quantity;
                ORbox.Text = or;
                Price.Text = price;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapters = new MySqlDataAdapter("SELECT * FROM dodz.psession WHERE Session ='" + comboBox1.Text + "'", connection);

            connection.Open();

            DataSet dr = new DataSet();
            adapters.Fill(dr, "session");
            DSProd1.DataSource = dr.Tables["session"];
            connection.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MySqlConnection connection20 = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlDataReader rdr20;

            string c20 = "datasource = Localhost; port = 3306; username = root; password=";
            string query = "DELETE FROM dodz.psession;";
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

            MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapters = new MySqlDataAdapter("SELECT * FROM dodz.psession", connection);

            connection.Open();

            DataSet dr = new DataSet();
            adapters.Fill(dr, "psession");
            DSProd1.DataSource = dr.Tables["psession"];
            connection.Close();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapters = new MySqlDataAdapter("SELECT * FROM dodz.psession", connection);

            connection.Open();

            DataSet dr = new DataSet();
            adapters.Fill(dr, "psession");
            DSProd1.DataSource = dr.Tables["psession"];
            connection.Close();
        }
    }
}
