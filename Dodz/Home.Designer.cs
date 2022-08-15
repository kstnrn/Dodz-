namespace Dodz
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTLogout = new System.Windows.Forms.Button();
            this.BTReport = new System.Windows.Forms.Button();
            this.BTProduct = new System.Windows.Forms.Button();
            this.BTSales = new System.Windows.Forms.Button();
            this.BTHome = new System.Windows.Forms.Button();
            this.BTAccounts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RPProduct = new System.Windows.Forms.Button();
            this.RPSales = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.RProduct = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTLogout
            // 
            this.BTLogout.BackColor = System.Drawing.Color.Red;
            this.BTLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTLogout.FlatAppearance.BorderSize = 0;
            this.BTLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BTLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTLogout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogout.ForeColor = System.Drawing.Color.White;
            this.BTLogout.Location = new System.Drawing.Point(1118, 0);
            this.BTLogout.Name = "BTLogout";
            this.BTLogout.Size = new System.Drawing.Size(90, 63);
            this.BTLogout.TabIndex = 6;
            this.BTLogout.Text = "Logout";
            this.BTLogout.UseVisualStyleBackColor = false;
            this.BTLogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTReport
            // 
            this.BTReport.FlatAppearance.BorderSize = 0;
            this.BTReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BTReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTReport.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTReport.Location = new System.Drawing.Point(972, 0);
            this.BTReport.Name = "BTReport";
            this.BTReport.Size = new System.Drawing.Size(137, 63);
            this.BTReport.TabIndex = 5;
            this.BTReport.Text = "Report";
            this.BTReport.UseVisualStyleBackColor = true;
            this.BTReport.Click += new System.EventHandler(this.BTReport_Click);
            // 
            // BTProduct
            // 
            this.BTProduct.FlatAppearance.BorderSize = 0;
            this.BTProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BTProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTProduct.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTProduct.Location = new System.Drawing.Point(686, 0);
            this.BTProduct.Name = "BTProduct";
            this.BTProduct.Size = new System.Drawing.Size(137, 63);
            this.BTProduct.TabIndex = 3;
            this.BTProduct.Text = "Product";
            this.BTProduct.UseVisualStyleBackColor = true;
            this.BTProduct.Click += new System.EventHandler(this.BTProduct_Click);
            // 
            // BTSales
            // 
            this.BTSales.FlatAppearance.BorderSize = 0;
            this.BTSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BTSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSales.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSales.Location = new System.Drawing.Point(543, 0);
            this.BTSales.Name = "BTSales";
            this.BTSales.Size = new System.Drawing.Size(137, 63);
            this.BTSales.TabIndex = 2;
            this.BTSales.Text = "Sales";
            this.BTSales.UseVisualStyleBackColor = true;
            this.BTSales.Click += new System.EventHandler(this.BTSales_Click);
            // 
            // BTHome
            // 
            this.BTHome.FlatAppearance.BorderSize = 0;
            this.BTHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BTHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTHome.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTHome.Location = new System.Drawing.Point(400, -1);
            this.BTHome.Name = "BTHome";
            this.BTHome.Size = new System.Drawing.Size(137, 63);
            this.BTHome.TabIndex = 1;
            this.BTHome.Text = "Home";
            this.BTHome.UseVisualStyleBackColor = true;
            this.BTHome.Click += new System.EventHandler(this.BTHome_Click);
            // 
            // BTAccounts
            // 
            this.BTAccounts.FlatAppearance.BorderSize = 0;
            this.BTAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BTAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAccounts.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAccounts.Location = new System.Drawing.Point(829, 0);
            this.BTAccounts.Name = "BTAccounts";
            this.BTAccounts.Size = new System.Drawing.Size(137, 63);
            this.BTAccounts.TabIndex = 0;
            this.BTAccounts.Text = "Accounts";
            this.BTAccounts.UseVisualStyleBackColor = true;
            this.BTAccounts.Click += new System.EventHandler(this.BTAccounts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.Time);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.User);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.BTReport);
            this.panel2.Controls.Add(this.BTLogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BTHome);
            this.panel2.Controls.Add(this.BTAccounts);
            this.panel2.Controls.Add(this.BTProduct);
            this.panel2.Controls.Add(this.BTSales);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 63);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(130, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 58);
            this.panel4.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(133, 44);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 10;
            this.Time.Text = "Time";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(133, 31);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 9;
            this.Date.Text = "Date";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(130, 14);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(55, 13);
            this.User.TabIndex = 8;
            this.User.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RPProduct);
            this.panel1.Controls.Add(this.RPSales);
            this.panel1.Location = new System.Drawing.Point(972, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 127);
            this.panel1.TabIndex = 0;
            // 
            // RPProduct
            // 
            this.RPProduct.FlatAppearance.BorderSize = 0;
            this.RPProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.RPProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RPProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPProduct.Location = new System.Drawing.Point(0, 59);
            this.RPProduct.Name = "RPProduct";
            this.RPProduct.Size = new System.Drawing.Size(137, 63);
            this.RPProduct.TabIndex = 9;
            this.RPProduct.Text = "Product Report";
            this.RPProduct.UseVisualStyleBackColor = true;
            // 
            // RPSales
            // 
            this.RPSales.FlatAppearance.BorderSize = 0;
            this.RPSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.RPSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RPSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPSales.Location = new System.Drawing.Point(0, 0);
            this.RPSales.Name = "RPSales";
            this.RPSales.Size = new System.Drawing.Size(137, 63);
            this.RPSales.TabIndex = 8;
            this.RPSales.Text = "Sales Report";
            this.RPSales.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Gray;
            this.panel.Location = new System.Drawing.Point(9, 83);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1208, 660);
            this.panel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.RProduct);
            this.panel3.Location = new System.Drawing.Point(981, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 127);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sales Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RProduct
            // 
            this.RProduct.FlatAppearance.BorderSize = 0;
            this.RProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.RProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RProduct.Location = new System.Drawing.Point(0, 0);
            this.RProduct.Name = "RProduct";
            this.RProduct.Size = new System.Drawing.Size(137, 63);
            this.RProduct.TabIndex = 8;
            this.RProduct.Text = "Product Report";
            this.RProduct.UseVisualStyleBackColor = true;
            this.RProduct.Click += new System.EventHandler(this.RProduct_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1229, 755);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTAccounts;
        private System.Windows.Forms.Button BTHome;
        private System.Windows.Forms.Button BTLogout;
        private System.Windows.Forms.Button BTReport;
        private System.Windows.Forms.Button BTProduct;
        private System.Windows.Forms.Button BTSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RPProduct;
        private System.Windows.Forms.Button RPSales;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RProduct;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
    }
}