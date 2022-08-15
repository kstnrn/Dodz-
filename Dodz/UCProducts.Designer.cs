namespace Dodz
{
    partial class UCProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ORbox = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.DSProd1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reload = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.dodzDataSet = new Dodz.dodzDataSet();
            this.psessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DGProduct = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSProd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(55, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 5);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // Edit
            // 
            this.Edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(216, 518);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(66, 39);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(334, 518);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(66, 39);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(98, 518);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(66, 39);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Expiration Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Price";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(98, 415);
            this.Price.MaxLength = 45;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(303, 27);
            this.Price.TabIndex = 4;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Quantity";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(97, 307);
            this.Quantity.MaxLength = 45;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(303, 27);
            this.Quantity.TabIndex = 3;
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Product Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Pname
            // 
            this.Pname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pname.Location = new System.Drawing.Point(97, 250);
            this.Pname.MaxLength = 45;
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(303, 27);
            this.Pname.TabIndex = 2;
            this.Pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(121, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 3);
            this.panel4.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 33);
            this.label5.TabIndex = 23;
            this.label5.Text = "Products Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Barcode";
            // 
            // Barcode
            // 
            this.Barcode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode.Location = new System.Drawing.Point(97, 188);
            this.Barcode.MaxLength = 100;
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(303, 31);
            this.Barcode.TabIndex = 1;
            this.Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTPicker
            // 
            this.DTPicker.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker.CustomFormat = "dd/MM/yy";
            this.DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPicker.Location = new System.Drawing.Point(98, 472);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(303, 20);
            this.DTPicker.TabIndex = 37;
            this.DTPicker.Value = new System.DateTime(2021, 7, 14, 22, 19, 48, 0);
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(896, 52);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(195, 24);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(896, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 2);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(491, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 3);
            this.panel3.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 33);
            this.label3.TabIndex = 39;
            this.label3.Text = "Products Details";
            // 
            // BTNSearch
            // 
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSearch.Location = new System.Drawing.Point(1097, 52);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(75, 26);
            this.BTNSearch.TabIndex = 41;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "O.R.";
            // 
            // ORbox
            // 
            this.ORbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORbox.Location = new System.Drawing.Point(97, 363);
            this.ORbox.MaxLength = 45;
            this.ORbox.Name = "ORbox";
            this.ORbox.Size = new System.Drawing.Size(303, 27);
            this.ORbox.TabIndex = 42;
            this.ORbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(311, 44);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 46;
            this.Time.Text = "Time";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(311, 31);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 45;
            this.Date.Text = "Date";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(308, 14);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(55, 13);
            this.User.TabIndex = 44;
            this.User.Text = "Username";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(491, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 3);
            this.panel5.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(485, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 33);
            this.label10.TabIndex = 48;
            this.label10.Text = "Product Changes Log";
            // 
            // DSProd1
            // 
            this.DSProd1.AllowUserToAddRows = false;
            this.DSProd1.AllowUserToDeleteRows = false;
            this.DSProd1.AllowUserToResizeColumns = false;
            this.DSProd1.AllowUserToResizeRows = false;
            this.DSProd1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DSProd1.BackgroundColor = System.Drawing.Color.White;
            this.DSProd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSProd1.GridColor = System.Drawing.Color.Black;
            this.DSProd1.Location = new System.Drawing.Point(491, 379);
            this.DSProd1.Name = "DSProd1";
            this.DSProd1.RowHeadersVisible = false;
            this.DSProd1.RowHeadersWidth = 70;
            this.DSProd1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DSProd1.Size = new System.Drawing.Size(600, 252);
            this.DSProd1.TabIndex = 47;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reload
            // 
            this.Reload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Reload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Reload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.Location = new System.Drawing.Point(1106, 397);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(66, 39);
            this.Reload.TabIndex = 51;
            this.Reload.Text = "Refresh";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Clear
            // 
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1106, 352);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(66, 39);
            this.Clear.TabIndex = 50;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // dodzDataSet
            // 
            this.dodzDataSet.DataSetName = "dodzDataSet";
            this.dodzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // psessionBindingSource
            // 
            this.psessionBindingSource.DataMember = "psession";
            this.psessionBindingSource.DataSource = this.dodzDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add Product",
            "Product Update",
            "Product Deleted"});
            this.comboBox1.Location = new System.Drawing.Point(970, 352);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(911, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 54;
            this.label11.Text = "Sort by:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(287, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 103);
            this.panel6.TabIndex = 55;
            // 
            // DGProduct
            // 
            this.DGProduct.AllowUserToAddRows = false;
            this.DGProduct.AllowUserToDeleteRows = false;
            this.DGProduct.AllowUserToResizeColumns = false;
            this.DGProduct.AllowUserToResizeRows = false;
            this.DGProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProduct.BackgroundColor = System.Drawing.Color.White;
            this.DGProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProduct.GridColor = System.Drawing.Color.Black;
            this.DGProduct.Location = new System.Drawing.Point(491, 82);
            this.DGProduct.Name = "DGProduct";
            this.DGProduct.RowHeadersVisible = false;
            this.DGProduct.RowHeadersWidth = 70;
            this.DGProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProduct.Size = new System.Drawing.Size(681, 252);
            this.DGProduct.TabIndex = 38;
            this.DGProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProduct_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(425, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(362, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(299, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(425, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "label12";
            // 
            // UCProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DSProd1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ORbox);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DGProduct);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "UCProducts";
            this.Size = new System.Drawing.Size(1208, 660);
            this.Load += new System.EventHandler(this.UCProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSProd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ORbox;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DSProd1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.BindingSource psessionBindingSource;
        private dodzDataSet dodzDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DGProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
