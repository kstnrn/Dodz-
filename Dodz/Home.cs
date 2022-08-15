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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }
        public Home(string str)
        {
            InitializeComponent();
            this.User.Text = str;
        }

        private void BTAccounts_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCAccounts.Instance))
            {
                panel.Controls.Add(UCAccounts.Instance);
                UCAccounts.Instance.Dock = DockStyle.Fill;
                UCAccounts.Instance.BringToFront();

            }
            else
                UCAccounts.Instance.BringToFront();
            panel3.Hide();
        }

        private void BTHome_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCHome.Instance))
            {
                panel.Controls.Add(UCHome.Instance);
                UCHome.Instance.Dock = DockStyle.Fill;
                UCHome.Instance.BringToFront();

            }
            else
                UCHome.Instance.BringToFront();
            panel3.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            panel3.Hide();
            panel.Controls.Add(UCHome.Instance);
            UCHome.Instance.Dock = DockStyle.Fill;
            UCHome.Instance.BringToFront();
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            DialogResult res = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                string IN;
                IN = "Logout";
                string connectionString = "datasource = Localhost; port = 3306; username = root; password=; database=dodz;";
                string iquery = "INSERT INTO session(`user_name`, `user_time`, `user_date`, `user_ses`) VALUES ('" + User.Text + "','" + Time.Text + "','" + Date.Text + "', '" + IN + "')";

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

                this.Hide();
                Login pg = new Login();
                pg.ShowDialog();
            }
            if (res == DialogResult.Cancel)
            {
               
            }
           
        }

        private void BTSales_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCSales.Instance))
            {
                panel.Controls.Add(UCSales.Instance);
                UCSales.Instance.Dock = DockStyle.Fill;
                UCSales.Instance.BringToFront();

            }
            else
                UCSales.Instance.BringToFront();
            panel3.Hide();
        }

        private void BTProduct_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCProducts.Instance))
            {
                panel.Controls.Add(UCProducts.Instance);
                UCProducts.Instance.Dock = DockStyle.Fill;
                UCProducts.Instance.BringToFront();

            }
            else
                UCProducts.Instance.BringToFront();
            panel3.Hide();
        }

        private void BTReport_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void RProduct_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCReport.Instance))
            {
                panel.Controls.Add(UCReport.Instance);
                UCReport.Instance.Dock = DockStyle.Fill;
                UCReport.Instance.BringToFront();

            }
            else
                UCReport.Instance.BringToFront();
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UCSalesReport.Instance))
            {
                panel.Controls.Add(UCSalesReport.Instance);
                UCSalesReport.Instance.Dock = DockStyle.Fill;
                UCSalesReport.Instance.BringToFront();

            }
            else
                UCSalesReport.Instance.BringToFront();
            panel3.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
