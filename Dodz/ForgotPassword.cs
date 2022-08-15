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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dodz.accounts WHERE user_name = @parm1", con);
            cmd1.Parameters.AddWithValue("@parm1", UsernameBox.Text);
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                panel2.Visible = true;
                panel1.Visible = false;

                SecQ.Text = reader1["question"].ToString();
            }
           
            else if (string.IsNullOrEmpty(UsernameBox.Text))
            {
                MessageBox.Show("Please Input Username", "Error");
            }

            else
            {
                MessageBox.Show("Username doesn't exist!");
            }
            con.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void Submit2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlCommand command;
            MySqlDataReader rdr;

            connection.Open();
            string selectQuery = "SELECT * FROM dodz.accounts WHERE question = '" + SecQ.Text + "' AND answer = '" + AnsBox.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                panel2.Visible = false;
                panel3.Visible = true;
            }

            else if (string.IsNullOrEmpty(AnsBox.Text))
            {
                MessageBox.Show("Empty Field!", "Error");
            }

            else
            {
                MessageBox.Show("Invalid Security Question Answer, Please Try Again.");
            }
            connection.Close();

            MySqlConnection con = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dodz.accounts WHERE answer = @parm1 AND question ='"+SecQ.Text+"'", con);
            cmd1.Parameters.AddWithValue("@parm1", AnsBox.Text);
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
               PasswordLabel.Text = reader1["user_pass"].ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login pg = new Login();
            pg.ShowDialog();
        }

        private void Submit3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = Localhost; port = 3306; username = root; password=");
            MySqlCommand command;
            MySqlDataReader rdr;

            connection.Open();
            string selectQuery = "UPDATE dodz.accounts SET user_pass = '" + NewBox.Text + "' WHERE user_name = '" + UsernameBox.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                
            }
            else if (CurBox.Text != PasswordLabel.Text)
            {
                MessageBox.Show("Current Password doesnt exist! or Empty Field!");
            }
            else if (NewBox.Text != ConBox.Text)
            {
                MessageBox.Show("Passwords didnt match! or Empty Field!");
            }
            else
            {
                MessageBox.Show("Password Change Succesfully!");
                this.Hide();
                Login pg = new Login();
                pg.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login pg = new Login();
            pg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login pg = new Login();
            pg.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login pg = new Login();
            pg.ShowDialog();
        }
    }
}
