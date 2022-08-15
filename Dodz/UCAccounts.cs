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
    public partial class UCAccounts : UserControl
    {
        private static UCAccounts _instance;

        public static UCAccounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCAccounts();
                return _instance;
            }
        }

        public UCAccounts()
        {
            InitializeComponent();
        }

        private void UCAccounts_Load(object sender, EventArgs e)
        {
                MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.accounts", conn);
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "accounts");
                DGAcc1.DataSource = ds.Tables["accounts"];
                conn.Close();

                MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                MySqlDataAdapter adapters = new MySqlDataAdapter("SELECT * FROM dodz.session", connection);

                connection.Open();

                DataSet dr = new DataSet();
                adapters.Fill(dr, "session");
                DGAcc2.DataSource = dr.Tables["session"];
                connection.Close();
                    
                DGAcc1.Columns[0].HeaderText = "User ID";
                DGAcc1.Columns[1].HeaderText = "Username";
                DGAcc1.Columns[2].HeaderText = "Password";
                DGAcc1.Columns[3].HeaderText = "First Name";
                DGAcc1.Columns[4].HeaderText = "Middle Name";
                DGAcc1.Columns[5].HeaderText = "Last Name";
                DGAcc1.Columns[6].HeaderText = "Security Question";
                DGAcc1.Columns[7].HeaderText = "Security Answer";

                int nRowIndex = DGAcc1.Rows.Count - 1;
                DGAcc1.ClearSelection();
                // Find last visible row
                DataGridViewRow row = DGAcc1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
                // scroll to last row if necessary
                DGAcc1.FirstDisplayedScrollingRowIndex = DGAcc1.Rows.IndexOf(row);
                // select row
                row.Selected = true;

                DGAcc2.Columns[0].HeaderText = "ID";
                DGAcc2.Columns[1].HeaderText = "Username";
                DGAcc2.Columns[2].HeaderText = "Time";
                DGAcc2.Columns[3].HeaderText = "Date";
                DGAcc2.Columns[4].HeaderText = "Session";
               
         
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlCommand command;
            MySqlDataReader rdr;

            connection.Open();
            string selectQuery = "SELECT * FROM dodz.accounts WHERE user_id = '" + ID.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("ID is taken.");
            }
            else if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Fname.Text) || string.IsNullOrEmpty(Mname.Text) || string.IsNullOrEmpty(Lname.Text) || string.IsNullOrEmpty(Uname.Text) || string.IsNullOrEmpty(Passbox.Text))
            {
                MessageBox.Show("Please fill empty field");
            }
            else
            {
                string connectionString = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                string iquery = "INSERT INTO accounts(`user_id`, `fname`, `mname`, `lname`, `user_name`, `user_pass`, `question`, `answer`) VALUES ('" + ID.Text + "','" + Fname.Text + "','" + Mname.Text + "','" + Lname.Text + "','" + Uname.Text + "','" + Passbox.Text + "', '" + QCbox.Text + "', '" + QAns.Text + "')";

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

                MessageBox.Show("Account Successfully Registered!");
                ID.Text = "";
                Fname.Text = "";
                Mname.Text = "";
                Lname.Text = "";
                Uname.Text = "";
                Passbox.Text = "";
                QCbox.Text = "";
                QAns.Text = "";
            }
            connection.Close();

            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.accounts", conn);

            connection.Open();

            DataSet ds = new DataSet();
            adapter.Fill(ds, "accounts");
            DGAcc1.DataSource = ds.Tables["accounts"];
            connection.Close();

            DGAcc1.Columns[0].HeaderText = "User ID";
            DGAcc1.Columns[1].HeaderText = "Username";
            DGAcc1.Columns[2].HeaderText = "Password";
            DGAcc1.Columns[3].HeaderText = "First Name";
            DGAcc1.Columns[4].HeaderText = "Middle Name";
            DGAcc1.Columns[5].HeaderText = "Last Name";
            DGAcc1.Columns[6].HeaderText = "Security Question";
            DGAcc1.Columns[7].HeaderText = "Security Answer";

            int nRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc1.ClearSelection();
            // Find last visible row
            DataGridViewRow row = DGAcc1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc1.FirstDisplayedScrollingRowIndex = DGAcc1.Rows.IndexOf(row);
            // select row
            row.Selected = true;

            DGAcc2.Columns[0].HeaderText = "ID";
            DGAcc2.Columns[1].HeaderText = "Username";
            DGAcc2.Columns[2].HeaderText = "Time";
            DGAcc2.Columns[3].HeaderText = "Date";
            DGAcc2.Columns[4].HeaderText = "Session";

            int rRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc2.ClearSelection();
            // Find last visible row
            DataGridViewRow rows = DGAcc2.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc2.FirstDisplayedScrollingRowIndex = DGAcc2.Rows.IndexOf(rows);
            // select row
            rows.Selected = true;
        }

        private void DGAcc1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dodz.accounts WHERE user_id = @parm1 OR user_name = '"+Search.Text+"'", con);
            cmd1.Parameters.AddWithValue("@parm1", Search.Text);
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                ID.Text = reader1["user_id"].ToString();
                Fname.Text = reader1["fname"].ToString();
                Mname.Text = reader1["mname"].ToString();
                Lname.Text = reader1["lname"].ToString();
                Uname.Text = reader1["user_name"].ToString();
                Passbox.Text = reader1["user_pass"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            Search.Text = null;
            con.Close();

            DGAcc1.Columns[0].HeaderText = "User ID";
            DGAcc1.Columns[1].HeaderText = "Username";
            DGAcc1.Columns[2].HeaderText = "Password";
            DGAcc1.Columns[3].HeaderText = "First Name";
            DGAcc1.Columns[4].HeaderText = "Middle Name";
            DGAcc1.Columns[5].HeaderText = "Last Name";
            DGAcc1.Columns[6].HeaderText = "Security Question";
            DGAcc1.Columns[7].HeaderText = "Security Answer";

            int nRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc1.ClearSelection();
            // Find last visible row
            DataGridViewRow row = DGAcc1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc1.FirstDisplayedScrollingRowIndex = DGAcc1.Rows.IndexOf(row);
            // select row
            row.Selected = true;

            DGAcc2.Columns[0].HeaderText = "ID";
            DGAcc2.Columns[1].HeaderText = "Username";
            DGAcc2.Columns[2].HeaderText = "Time";
            DGAcc2.Columns[3].HeaderText = "Date";
            DGAcc2.Columns[4].HeaderText = "Session";

            int rRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc2.ClearSelection();
            // Find last visible row
            DataGridViewRow rows = DGAcc2.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc2.FirstDisplayedScrollingRowIndex = DGAcc2.Rows.IndexOf(rows);
            // select row
            rows.Selected = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlDataReader rdr;

            if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Fname.Text) || string.IsNullOrEmpty(Mname.Text) || string.IsNullOrEmpty(Lname.Text) || string.IsNullOrEmpty(Uname.Text) || string.IsNullOrEmpty(Passbox.Text))
            {
                MessageBox.Show("Please fill empty field");
            }
            else
            {

                string con = "datasource = Localhost; port = 3306; username = root; password=";
                string query = "update dodz.accounts set user_id = '" + this.ID.Text + "',user_name = '" + this.Uname.Text + "',user_pass = '" + this.Passbox.Text + "',fname = '" + this.Fname.Text + "',mname = '" + Mname.Text + "',lname = '" + this.Lname.Text + "', question = '"+QCbox.Text+"', answer = '"+QAns.Text+"' WHERE user_id='" + ID.Text + "';";
                MySqlConnection con2 = new MySqlConnection(con);
                MySqlCommand cmd2 = new MySqlCommand(query, con2);

                con2.Open();
                rdr = cmd2.ExecuteReader();
                MessageBox.Show("Account Updated!");

                ID.Text = "";
                Uname.Text = "";
                Passbox.Text = "";
                Fname.Text = "";
                Mname.Text = "";
                Lname.Text = "";
                QCbox.Text = "";
                QAns.Text = "";

                while (rdr.Read())
                {
                }
                con2.Close();

                MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.accounts", conn);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "accounts");
                DGAcc1.DataSource = ds.Tables["accounts"];
                connection.Close();
            }

            DGAcc1.Columns[0].HeaderText = "User ID";
            DGAcc1.Columns[1].HeaderText = "Username";
            DGAcc1.Columns[2].HeaderText = "Password";
            DGAcc1.Columns[3].HeaderText = "First Name";
            DGAcc1.Columns[4].HeaderText = "Middle Name";
            DGAcc1.Columns[5].HeaderText = "Last Name";
            DGAcc1.Columns[6].HeaderText = "Security Question";
            DGAcc1.Columns[7].HeaderText = "Security Answer";

            int nRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc1.ClearSelection();
            // Find last visible row
            DataGridViewRow row = DGAcc1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc1.FirstDisplayedScrollingRowIndex = DGAcc1.Rows.IndexOf(row);
            // select row
            row.Selected = true;

            DGAcc2.Columns[0].HeaderText = "ID";
            DGAcc2.Columns[1].HeaderText = "Username";
            DGAcc2.Columns[2].HeaderText = "Time";
            DGAcc2.Columns[3].HeaderText = "Date";
            DGAcc2.Columns[4].HeaderText = "Session";

            int rRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc2.ClearSelection();
            // Find last visible row
            DataGridViewRow rows = DGAcc2.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc2.FirstDisplayedScrollingRowIndex = DGAcc2.Rows.IndexOf(rows);
            // select row
            rows.Selected = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlDataReader rdr;
           

            if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Fname.Text) || string.IsNullOrEmpty(Mname.Text) || string.IsNullOrEmpty(Lname.Text) || string.IsNullOrEmpty(Uname.Text) || string.IsNullOrEmpty(Passbox.Text))
            {
                MessageBox.Show("Please fill empty field");
            }
            else
            {
                string con = "datasource = Localhost; port = 3306; username = root; password=";
                string query = "DELETE from dodz.accounts WHERE user_id='" + ID.Text + "';";
                MySqlConnection con2 = new MySqlConnection(con);
                MySqlCommand cmd2 = new MySqlCommand(query, con2);
               
                    con2.Open();
                    rdr = cmd2.ExecuteReader();
                    MessageBox.Show("Data Deleted");

                    ID.Text = null;
                    Uname.Text = null;
                    Passbox.Text = null;
                    Fname.Text = null;
                    Mname.Text = null;
                    Lname.Text = null;


                    while (rdr.Read())
                    {
                    }
                    con2.Close();

                MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dodz.accounts", conn);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "accounts");
                DGAcc1.DataSource = ds.Tables["accounts"];
                connection.Close();
            }

            DGAcc1.Columns[0].HeaderText = "User ID";
            DGAcc1.Columns[1].HeaderText = "Username";
            DGAcc1.Columns[2].HeaderText = "Password";
            DGAcc1.Columns[3].HeaderText = "First Name";
            DGAcc1.Columns[4].HeaderText = "Middle Name";
            DGAcc1.Columns[5].HeaderText = "Last Name";
            DGAcc1.Columns[6].HeaderText = "Security Question";
            DGAcc1.Columns[7].HeaderText = "Security Answer";

            int nRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc1.ClearSelection();
            // Find last visible row
            DataGridViewRow row = DGAcc1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc1.FirstDisplayedScrollingRowIndex = DGAcc1.Rows.IndexOf(row);
            // select row
            row.Selected = true;

            DGAcc2.Columns[0].HeaderText = "ID";
            DGAcc2.Columns[1].HeaderText = "Username";
            DGAcc2.Columns[2].HeaderText = "Time";
            DGAcc2.Columns[3].HeaderText = "Date";
            DGAcc2.Columns[4].HeaderText = "Session";
            
            int rRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc2.ClearSelection();
            // Find last visible row
            DataGridViewRow rows = DGAcc2.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc2.FirstDisplayedScrollingRowIndex = DGAcc2.Rows.IndexOf(rows);
            // select row
            rows.Selected = true;
        
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

        private void Clear_Click(object sender, EventArgs e)
        {
            MySqlConnection connection20 = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlDataReader rdr20;

            string c20 = "datasource = Localhost; port = 3306; username = root; password=";
            string query = "DELETE FROM dodz.session;";
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
            MySqlDataAdapter adapters = new MySqlDataAdapter("SELECT * FROM dodz.session", connection);

            connection.Open();

            DataSet dr = new DataSet();
            adapters.Fill(dr, "session");
            DGAcc2.DataSource = dr.Tables["session"];
            connection.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapters = new MySqlDataAdapter("SELECT * FROM dodz.session", connection);

            connection.Open();

            DataSet dr = new DataSet();
            adapters.Fill(dr, "session");
            DGAcc2.DataSource = dr.Tables["session"];
            connection.Close();

            DGAcc1.Columns[0].HeaderText = "User ID";
            DGAcc1.Columns[1].HeaderText = "Username";
            DGAcc1.Columns[2].HeaderText = "Password";
            DGAcc1.Columns[3].HeaderText = "First Name";
            DGAcc1.Columns[4].HeaderText = "Middle Name";
            DGAcc1.Columns[5].HeaderText = "Last Name";
            DGAcc1.Columns[6].HeaderText = "Security Question";
            DGAcc1.Columns[7].HeaderText = "Security Answer";

            int nRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc1.ClearSelection();
            // Find last visible row
            DataGridViewRow row = DGAcc1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc1.FirstDisplayedScrollingRowIndex = DGAcc1.Rows.IndexOf(row);
            // select row
            row.Selected = true;

            DGAcc2.Columns[0].HeaderText = "ID";
            DGAcc2.Columns[1].HeaderText = "Username";
            DGAcc2.Columns[2].HeaderText = "Time";
            DGAcc2.Columns[3].HeaderText = "Date";
            DGAcc2.Columns[4].HeaderText = "Session";
        }

        private void SecA_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGAcc1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGAcc1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string id = DGAcc1.SelectedRows[0].Cells[0].Value + string.Empty;
                string User = DGAcc1.SelectedRows[0].Cells[1].Value + string.Empty;
                string Pass = DGAcc1.SelectedRows[0].Cells[2].Value + string.Empty;
                string First = DGAcc1.SelectedRows[0].Cells[3].Value + string.Empty;
                string Middle = DGAcc1.SelectedRows[0].Cells[4].Value + string.Empty;
                string Last = DGAcc1.SelectedRows[0].Cells[5].Value + string.Empty;
                string Question = DGAcc1.SelectedRows[0].Cells[6].Value + string.Empty;
                string Answer = DGAcc1.SelectedRows[0].Cells[7].Value + string.Empty;

                ID.Text = id;
                Uname.Text = User;
                Passbox.Text = Pass;
                Fname.Text = First;
                Mname.Text = Middle;
                Lname.Text = Last;
                QCbox.Text = Question;
                QAns.Text = Answer;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=");
            MySqlDataAdapter adapters = new MySqlDataAdapter("SELECT * FROM dodz.session WHERE user_date ='"+dateTimePicker1.Text+"'", connection);

            connection.Open();

            DataSet dr = new DataSet();
            adapters.Fill(dr, "session");
            DGAcc2.DataSource = dr.Tables["session"];
            connection.Close();

            DGAcc1.Columns[0].HeaderText = "User ID";
            DGAcc1.Columns[1].HeaderText = "Username";
            DGAcc1.Columns[2].HeaderText = "Password";
            DGAcc1.Columns[3].HeaderText = "First Name";
            DGAcc1.Columns[4].HeaderText = "Middle Name";
            DGAcc1.Columns[5].HeaderText = "Last Name";
            DGAcc1.Columns[6].HeaderText = "Security Question";
            DGAcc1.Columns[7].HeaderText = "Security Answer";

            int nRowIndex = DGAcc1.Rows.Count - 1;
            DGAcc1.ClearSelection();
            // Find last visible row
            DataGridViewRow row = DGAcc1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).First();
            // scroll to last row if necessary
            DGAcc1.FirstDisplayedScrollingRowIndex = DGAcc1.Rows.IndexOf(row);
            // select row
            row.Selected = true;

            DGAcc2.Columns[0].HeaderText = "ID";
            DGAcc2.Columns[1].HeaderText = "Username";
            DGAcc2.Columns[2].HeaderText = "Time";
            DGAcc2.Columns[3].HeaderText = "Date";
            DGAcc2.Columns[4].HeaderText = "Session";
        }
    }
}
