namespace Dodz
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.UnitPrice = new System.Windows.Forms.TextBox();
            this.SubTotalPriceBox = new System.Windows.Forms.TextBox();
            this.LABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.TotalPriceBox = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGPOS = new System.Windows.Forms.DataGridView();
            this.prodnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodzDataSet = new Dodz.dodzDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.TextBox();
            this.QuantityButton = new System.Windows.Forms.Button();
            this.ProdNumBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.printtimes = new System.Windows.Forms.TextBox();
            this.ProdNumBox2 = new System.Windows.Forms.TextBox();
            this.DGSold = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.TextBox();
            this.DBdate = new System.Windows.Forms.TextBox();
            this.itemlistTableAdapter = new Dodz.dodzDataSetTableAdapters.itemlistTableAdapter();
            this.CQuant = new System.Windows.Forms.TextBox();
            this.NQuant = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.proid = new System.Windows.Forms.TextBox();
            this.RNQuant = new System.Windows.Forms.TextBox();
            this.Sdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodzDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSold)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(142, 66);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Search.MaxLength = 1000;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(533, 31);
            this.Search.TabIndex = 0;
            this.Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fs);
            this.Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Escape);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.BackColor = System.Drawing.Color.White;
            this.ProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductQuantity.Enabled = false;
            this.ProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProductQuantity.Location = new System.Drawing.Point(2, 92);
            this.ProductQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            this.ProductQuantity.Size = new System.Drawing.Size(149, 31);
            this.ProductQuantity.TabIndex = 4;
            this.ProductQuantity.TabStop = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.BackColor = System.Drawing.Color.White;
            this.UnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPrice.Enabled = false;
            this.UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.UnitPrice.Location = new System.Drawing.Point(2, 157);
            this.UnitPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Size = new System.Drawing.Size(149, 31);
            this.UnitPrice.TabIndex = 5;
            this.UnitPrice.TabStop = false;
            // 
            // SubTotalPriceBox
            // 
            this.SubTotalPriceBox.BackColor = System.Drawing.Color.White;
            this.SubTotalPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubTotalPriceBox.Enabled = false;
            this.SubTotalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalPriceBox.Location = new System.Drawing.Point(2, 221);
            this.SubTotalPriceBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubTotalPriceBox.Name = "SubTotalPriceBox";
            this.SubTotalPriceBox.ReadOnly = true;
            this.SubTotalPriceBox.Size = new System.Drawing.Size(149, 31);
            this.SubTotalPriceBox.TabIndex = 6;
            this.SubTotalPriceBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL.ForeColor = System.Drawing.Color.Black;
            this.LABEL.Location = new System.Drawing.Point(4, 69);
            this.LABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(68, 20);
            this.LABEL.TabIndex = 7;
            this.LABEL.Text = "Quantity";
            this.LABEL.Click += new System.EventHandler(this.LABEL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unit Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.ForeColor = System.Drawing.Color.Black;
            this.TotalPrice.Location = new System.Drawing.Point(2, 198);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(112, 20);
            this.TotalPrice.TabIndex = 9;
            this.TotalPrice.Text = "SubTotal Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Product Name";
            // 
            // Pname
            // 
            this.Pname.BackColor = System.Drawing.Color.White;
            this.Pname.Enabled = false;
            this.Pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pname.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Pname.Location = new System.Drawing.Point(30, 35);
            this.Pname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pname.Name = "Pname";
            this.Pname.ReadOnly = true;
            this.Pname.Size = new System.Drawing.Size(483, 26);
            this.Pname.TabIndex = 13;
            this.Pname.TabStop = false;
            this.Pname.TextChanged += new System.EventHandler(this.Pname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(515, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Barcode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Barcode
            // 
            this.Barcode.BackColor = System.Drawing.Color.White;
            this.Barcode.Enabled = false;
            this.Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Barcode.Location = new System.Drawing.Point(518, 35);
            this.Barcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Size = new System.Drawing.Size(156, 26);
            this.Barcode.TabIndex = 12;
            this.Barcode.TabStop = false;
            this.Barcode.TextChanged += new System.EventHandler(this.Barcode_TextChanged);
            // 
            // TotalPriceBox
            // 
            this.TotalPriceBox.BackColor = System.Drawing.Color.White;
            this.TotalPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPriceBox.Enabled = false;
            this.TotalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TotalPriceBox.Location = new System.Drawing.Point(2, 285);
            this.TotalPriceBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TotalPriceBox.Name = "TotalPriceBox";
            this.TotalPriceBox.ReadOnly = true;
            this.TotalPriceBox.Size = new System.Drawing.Size(149, 31);
            this.TotalPriceBox.TabIndex = 17;
            this.TotalPriceBox.TabStop = false;
            this.TotalPriceBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Black;
            this.Total.Location = new System.Drawing.Point(4, 261);
            this.Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 20);
            this.Total.TabIndex = 18;
            this.Total.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(30, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 14);
            this.panel1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, -1);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 24;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, -1);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantity";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, -1);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Barcode";
            // 
            // DGPOS
            // 
            this.DGPOS.AllowUserToAddRows = false;
            this.DGPOS.AllowUserToDeleteRows = false;
            this.DGPOS.AllowUserToResizeColumns = false;
            this.DGPOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGPOS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGPOS.AutoGenerateColumns = false;
            this.DGPOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGPOS.BackgroundColor = System.Drawing.Color.White;
            this.DGPOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGPOS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGPOS.ColumnHeadersVisible = false;
            this.DGPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodnumDataGridViewTextBoxColumn,
            this.prodcodeDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.prodquantityDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn});
            this.DGPOS.DataSource = this.itemlistBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPOS.DefaultCellStyle = dataGridViewCellStyle10;
            this.DGPOS.Location = new System.Drawing.Point(30, 117);
            this.DGPOS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGPOS.Name = "DGPOS";
            this.DGPOS.RowHeadersVisible = false;
            this.DGPOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGPOS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPOS.ShowEditingIcon = false;
            this.DGPOS.Size = new System.Drawing.Size(644, 266);
            this.DGPOS.TabIndex = 21;
            this.DGPOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPOS_CellClick);
            this.DGPOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPOS_CellContentClick);
            this.DGPOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGPOS_KeyDown);
            this.DGPOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGPOS_KeyPress);
            // 
            // prodnumDataGridViewTextBoxColumn
            // 
            this.prodnumDataGridViewTextBoxColumn.DataPropertyName = "prod_num";
            this.prodnumDataGridViewTextBoxColumn.HeaderText = "prod_num";
            this.prodnumDataGridViewTextBoxColumn.Name = "prodnumDataGridViewTextBoxColumn";
            // 
            // prodcodeDataGridViewTextBoxColumn
            // 
            this.prodcodeDataGridViewTextBoxColumn.DataPropertyName = "prod_code";
            this.prodcodeDataGridViewTextBoxColumn.HeaderText = "prod_code";
            this.prodcodeDataGridViewTextBoxColumn.Name = "prodcodeDataGridViewTextBoxColumn";
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            // 
            // prodquantityDataGridViewTextBoxColumn
            // 
            this.prodquantityDataGridViewTextBoxColumn.DataPropertyName = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.HeaderText = "prod_quantity";
            this.prodquantityDataGridViewTextBoxColumn.Name = "prodquantityDataGridViewTextBoxColumn";
            // 
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            // 
            // itemlistBindingSource
            // 
            this.itemlistBindingSource.DataMember = "itemlist";
            this.itemlistBindingSource.DataSource = this.dodzDataSet;
            // 
            // dodzDataSet
            // 
            this.dodzDataSet.DataSetName = "dodzDataSet";
            this.dodzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(30, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Exit\r\n(Esc)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.White;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Location = new System.Drawing.Point(355, 391);
            this.Payment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(59, 42);
            this.Payment.TabIndex = 23;
            this.Payment.Text = "Payment (F12)";
            this.Payment.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Change);
            this.panel2.Controls.Add(this.TotalPriceBox);
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.TotalPrice);
            this.panel2.Controls.Add(this.SubTotalPriceBox);
            this.panel2.Controls.Add(this.UnitPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ProductQuantity);
            this.panel2.Controls.Add(this.LABEL);
            this.panel2.Location = new System.Drawing.Point(680, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 326);
            this.panel2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Change";
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.White;
            this.Change.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Change.Enabled = false;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Change.Location = new System.Drawing.Point(2, 29);
            this.Change.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Size = new System.Drawing.Size(149, 31);
            this.Change.TabIndex = 19;
            this.Change.TabStop = false;
            // 
            // QuantityButton
            // 
            this.QuantityButton.BackColor = System.Drawing.Color.White;
            this.QuantityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityButton.Location = new System.Drawing.Point(160, 391);
            this.QuantityButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.QuantityButton.Name = "QuantityButton";
            this.QuantityButton.Size = new System.Drawing.Size(59, 42);
            this.QuantityButton.TabIndex = 25;
            this.QuantityButton.Text = "Quantity (F1)";
            this.QuantityButton.UseVisualStyleBackColor = false;
            this.QuantityButton.Click += new System.EventHandler(this.QuantityButton_Click);
            // 
            // ProdNumBox
            // 
            this.ProdNumBox.BackColor = System.Drawing.Color.White;
            this.ProdNumBox.Enabled = false;
            this.ProdNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNumBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProdNumBox.Location = new System.Drawing.Point(589, 9);
            this.ProdNumBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProdNumBox.Name = "ProdNumBox";
            this.ProdNumBox.ReadOnly = true;
            this.ProdNumBox.Size = new System.Drawing.Size(86, 26);
            this.ProdNumBox.TabIndex = 27;
            this.ProdNumBox.TabStop = false;
            this.ProdNumBox.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(95, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 42);
            this.button2.TabIndex = 28;
            this.button2.Text = "Insert (Enter)";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(224, 391);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 42);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete (F10)";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(290, 391);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 42);
            this.button4.TabIndex = 30;
            this.button4.Text = "Void \r\n(F11)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(680, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // printtimes
            // 
            this.printtimes.BackColor = System.Drawing.Color.White;
            this.printtimes.Enabled = false;
            this.printtimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printtimes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.printtimes.Location = new System.Drawing.Point(655, 391);
            this.printtimes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.printtimes.Name = "printtimes";
            this.printtimes.ReadOnly = true;
            this.printtimes.Size = new System.Drawing.Size(23, 38);
            this.printtimes.TabIndex = 21;
            this.printtimes.TabStop = false;
            this.printtimes.Text = "2";
            this.printtimes.Visible = false;
            // 
            // ProdNumBox2
            // 
            this.ProdNumBox2.BackColor = System.Drawing.Color.White;
            this.ProdNumBox2.Enabled = false;
            this.ProdNumBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNumBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProdNumBox2.Location = new System.Drawing.Point(462, 8);
            this.ProdNumBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProdNumBox2.Name = "ProdNumBox2";
            this.ProdNumBox2.ReadOnly = true;
            this.ProdNumBox2.Size = new System.Drawing.Size(51, 26);
            this.ProdNumBox2.TabIndex = 32;
            this.ProdNumBox2.TabStop = false;
            // 
            // DGSold
            // 
            this.DGSold.AllowUserToAddRows = false;
            this.DGSold.AllowUserToDeleteRows = false;
            this.DGSold.AllowUserToResizeColumns = false;
            this.DGSold.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGSold.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGSold.AutoGenerateColumns = false;
            this.DGSold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSold.BackgroundColor = System.Drawing.Color.White;
            this.DGSold.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGSold.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGSold.ColumnHeadersVisible = false;
            this.DGSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DGSold.DataSource = this.itemlistBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGSold.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGSold.Location = new System.Drawing.Point(30, 117);
            this.DGSold.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGSold.Name = "DGSold";
            this.DGSold.RowHeadersVisible = false;
            this.DGSold.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGSold.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGSold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGSold.ShowEditingIcon = false;
            this.DGSold.Size = new System.Drawing.Size(644, 266);
            this.DGSold.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "prod_num";
            this.dataGridViewTextBoxColumn1.HeaderText = "prod_num";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prod_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "prod_code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prod_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "prod_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prod_quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "prod_quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prod_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "prod_price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(422, 391);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(40, 19);
            this.Date.TabIndex = 34;
            this.Date.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(422, 412);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(41, 19);
            this.Time.TabIndex = 35;
            this.Time.Text = "Time";
            // 
            // Profit
            // 
            this.Profit.BackColor = System.Drawing.Color.White;
            this.Profit.Enabled = false;
            this.Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Profit.Location = new System.Drawing.Point(590, 391);
            this.Profit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Size = new System.Drawing.Size(59, 38);
            this.Profit.TabIndex = 36;
            this.Profit.TabStop = false;
            this.Profit.Visible = false;
            // 
            // DBdate
            // 
            this.DBdate.BackColor = System.Drawing.Color.White;
            this.DBdate.Enabled = false;
            this.DBdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBdate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DBdate.Location = new System.Drawing.Point(524, 391);
            this.DBdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DBdate.Name = "DBdate";
            this.DBdate.ReadOnly = true;
            this.DBdate.Size = new System.Drawing.Size(59, 38);
            this.DBdate.TabIndex = 37;
            this.DBdate.TabStop = false;
            this.DBdate.Visible = false;
            // 
            // itemlistTableAdapter
            // 
            this.itemlistTableAdapter.ClearBeforeFill = true;
            // 
            // CQuant
            // 
            this.CQuant.BackColor = System.Drawing.Color.White;
            this.CQuant.Enabled = false;
            this.CQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CQuant.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CQuant.Location = new System.Drawing.Point(372, 8);
            this.CQuant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CQuant.Name = "CQuant";
            this.CQuant.ReadOnly = true;
            this.CQuant.Size = new System.Drawing.Size(86, 26);
            this.CQuant.TabIndex = 38;
            this.CQuant.TabStop = false;
            // 
            // NQuant
            // 
            this.NQuant.BackColor = System.Drawing.Color.White;
            this.NQuant.Enabled = false;
            this.NQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NQuant.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NQuant.Location = new System.Drawing.Point(325, 8);
            this.NQuant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NQuant.Name = "NQuant";
            this.NQuant.ReadOnly = true;
            this.NQuant.Size = new System.Drawing.Size(43, 26);
            this.NQuant.TabIndex = 39;
            this.NQuant.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(160, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 29);
            this.panel3.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(83, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Notification Receiver:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(241, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 43;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "09060073355";
            // 
            // proid
            // 
            this.proid.BackColor = System.Drawing.Color.White;
            this.proid.Enabled = false;
            this.proid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.proid.Location = new System.Drawing.Point(278, 9);
            this.proid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.proid.Name = "proid";
            this.proid.ReadOnly = true;
            this.proid.Size = new System.Drawing.Size(43, 26);
            this.proid.TabIndex = 41;
            this.proid.TabStop = false;
            // 
            // RNQuant
            // 
            this.RNQuant.BackColor = System.Drawing.Color.White;
            this.RNQuant.Enabled = false;
            this.RNQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNQuant.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.RNQuant.Location = new System.Drawing.Point(231, 8);
            this.RNQuant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RNQuant.Name = "RNQuant";
            this.RNQuant.ReadOnly = true;
            this.RNQuant.Size = new System.Drawing.Size(43, 26);
            this.RNQuant.TabIndex = 42;
            this.RNQuant.TabStop = false;
            // 
            // Sdate
            // 
            this.Sdate.AutoSize = true;
            this.Sdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sdate.ForeColor = System.Drawing.Color.White;
            this.Sdate.Location = new System.Drawing.Point(156, 11);
            this.Sdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sdate.Name = "Sdate";
            this.Sdate.Size = new System.Drawing.Size(55, 20);
            this.Sdate.TabIndex = 44;
            this.Sdate.Text = "SDate";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(854, 441);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NQuant);
            this.Controls.Add(this.CQuant);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.DBdate);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ProdNumBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProdNumBox);
            this.Controls.Add(this.QuantityButton);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGPOS);
            this.Controls.Add(this.DGSold);
            this.Controls.Add(this.printtimes);
            this.Controls.Add(this.proid);
            this.Controls.Add(this.RNQuant);
            this.Controls.Add(this.Sdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodzDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSold)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ProductQuantity;
        private System.Windows.Forms.TextBox UnitPrice;
        private System.Windows.Forms.TextBox SubTotalPriceBox;
        private System.Windows.Forms.Label LABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.TextBox TotalPriceBox;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGPOS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button QuantityButton;
        private System.Windows.Forms.TextBox ProdNumBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Change;
        private System.Windows.Forms.TextBox printtimes;
        private System.Windows.Forms.TextBox ProdNumBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemlistBindingSource;
        private dodzDataSet dodzDataSet;
        private System.Windows.Forms.DataGridView DGSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox Profit;
        private System.Windows.Forms.TextBox DBdate;
        private dodzDataSetTableAdapters.itemlistTableAdapter itemlistTableAdapter;
        private System.Windows.Forms.TextBox CQuant;
        private System.Windows.Forms.TextBox NQuant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox proid;
        private System.Windows.Forms.TextBox RNQuant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Sdate;
    }
}