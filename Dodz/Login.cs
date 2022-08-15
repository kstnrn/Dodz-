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

namespace Dodz
{
    public partial class Login : Form
    {

        MySqlConnection con = new MySqlConnection("datasource = localhost; database = dodz; port = 3306; username = root; password = ");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            LabelHead.Parent = pictureBox1;
            LabelHead.BackColor = Color.Transparent;
            LabelBody.Parent = pictureBox1;
            LabelBody.BackColor = Color.Transparent;
            LabelNote.Parent = pictureBox1;
            LabelNote.BackColor = Color.Transparent;
            Register.Parent = pictureBox1;
            Register.BackColor = Color.Transparent;
            POS.Parent = pictureBox1;
            POS.BackColor = Color.Transparent;
            PanelIn.Show();
            PanelOut.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            PanelIn.Hide();
            PanelOut.Show();
            
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlCommand command;
            MySqlDataReader rdr;

            connection.Open();
            string selectQuery = "SELECT * FROM dodz.accounts WHERE user_name = '" + Ubox.Text + "' AND user_pass = '" + Pbox.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                string IN;
                IN = "Login";

                string connectionString = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                string iquery = "INSERT INTO session(`user_name`, `user_time`, `user_date`, `user_ses`) VALUES ('" + Ubox.Text + "','" + Time.Text + "','" + Date.Text + "', '"+IN+"')";

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

                MessageBox.Show("Login Success, Welcome!");
                this.Hide();
                Home pg = new Home(this.Ubox.Text);
                pg.ShowDialog();
            }

            else if (string.IsNullOrEmpty(Ubox.Text) || string.IsNullOrEmpty(Pbox.Text))
            {
                MessageBox.Show("Please Input Username and Password", "Error");
            }

            else
            {
                MessageBox.Show("Invalid Username/Password, Please Try Again.");
            }
            connection.Close();
        }

        private void SignUp_Click(object sender, EventArgs e)
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
                string iquery = "INSERT INTO accounts(`user_id`, `fname`, `mname`, `lname`, `user_name`, `user_pass`, `question`, `answer`) VALUES ('" + ID.Text + "','" + Fname.Text + "','" + Mname.Text + "','" + Lname.Text + "','" + Uname.Text + "','" + Passbox.Text + "', '"+ QCbox.Text+ "', '"+ QAns.Text+ "')";

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

                PanelIn.Show();
                PanelOut.Hide();

                ID.Text = "";
                Fname.Text = "";
                Mname.Text = "";
                Lname.Text = "";
                Uname.Text = "";
                Passbox.Text = "";
            }
            connection.Close();
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            PanelIn.Show();
            PanelOut.Hide();
        }

        private void POS_Click(object sender, EventArgs e)
        {
            this.Hide();
            POS pg = new POS();
            pg.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void ForgotB_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword pg = new ForgotPassword();
            pg.ShowDialog();
        }

        private void QCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
