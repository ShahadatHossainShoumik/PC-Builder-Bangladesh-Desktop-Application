namespace PCBUILDER
{
    partial class Customer2
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
            this.Products = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.BRAND = new System.Windows.Forms.Label();
            this.PRICE = new System.Windows.Forms.Label();
            this.MODEL = new System.Windows.Forms.Label();
            this.QUANTITY = new System.Windows.Forms.Label();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.idBox2 = new System.Windows.Forms.TextBox();
            this.brandBox3 = new System.Windows.Forms.TextBox();
            this.priceBox4 = new System.Windows.Forms.TextBox();
            this.modelBox5 = new System.Windows.Forms.TextBox();
            this.quantityBox6 = new System.Windows.Forms.TextBox();
            this.IMAGE = new System.Windows.Forms.Label();
            this.TotalQuantity = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.BillingName = new System.Windows.Forms.Label();
            this.totalquantityBox7 = new System.Windows.Forms.TextBox();
            this.totalpriceBox8 = new System.Windows.Forms.TextBox();
            this.billingnameBox9 = new System.Windows.Forms.TextBox();
            this.ORDER = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Location = new System.Drawing.Point(8, 36);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(72, 20);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(407, 324);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(425, 36);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(55, 20);
            this.NAME.TabIndex = 3;
            this.NAME.Text = "NAME";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(425, 80);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // BRAND
            // 
            this.BRAND.AutoSize = true;
            this.BRAND.Location = new System.Drawing.Point(425, 124);
            this.BRAND.Name = "BRAND";
            this.BRAND.Size = new System.Drawing.Size(66, 20);
            this.BRAND.TabIndex = 5;
            this.BRAND.Text = "BRAND";
            // 
            // PRICE
            // 
            this.PRICE.AutoSize = true;
            this.PRICE.Location = new System.Drawing.Point(425, 170);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(58, 20);
            this.PRICE.TabIndex = 6;
            this.PRICE.Text = "PRICE";
            this.PRICE.Click += new System.EventHandler(this.label5_Click);
            // 
            // MODEL
            // 
            this.MODEL.AutoSize = true;
            this.MODEL.Location = new System.Drawing.Point(425, 218);
            this.MODEL.Name = "MODEL";
            this.MODEL.Size = new System.Drawing.Size(66, 20);
            this.MODEL.TabIndex = 7;
            this.MODEL.Text = "MODEL";
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSize = true;
            this.QUANTITY.Location = new System.Drawing.Point(425, 268);
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(89, 20);
            this.QUANTITY.TabIndex = 8;
            this.QUANTITY.Text = "QUANTITY";
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(515, 31);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(149, 26);
            this.nameBox1.TabIndex = 9;
            this.nameBox1.TextChanged += new System.EventHandler(this.nameBox1_TextChanged);
            // 
            // idBox2
            // 
            this.idBox2.Location = new System.Drawing.Point(515, 74);
            this.idBox2.Name = "idBox2";
            this.idBox2.Size = new System.Drawing.Size(149, 26);
            this.idBox2.TabIndex = 10;
            this.idBox2.TextChanged += new System.EventHandler(this.idBox2_TextChanged);
            // 
            // brandBox3
            // 
            this.brandBox3.Location = new System.Drawing.Point(515, 118);
            this.brandBox3.Name = "brandBox3";
            this.brandBox3.Size = new System.Drawing.Size(149, 26);
            this.brandBox3.TabIndex = 11;
            this.brandBox3.TextChanged += new System.EventHandler(this.brandBox3_TextChanged);
            // 
            // priceBox4
            // 
            this.priceBox4.Location = new System.Drawing.Point(515, 164);
            this.priceBox4.Name = "priceBox4";
            this.priceBox4.Size = new System.Drawing.Size(149, 26);
            this.priceBox4.TabIndex = 12;
            this.priceBox4.TextChanged += new System.EventHandler(this.priceBox4_TextChanged);
            // 
            // modelBox5
            // 
            this.modelBox5.Location = new System.Drawing.Point(515, 212);
            this.modelBox5.Name = "modelBox5";
            this.modelBox5.Size = new System.Drawing.Size(149, 26);
            this.modelBox5.TabIndex = 13;
            this.modelBox5.TextChanged += new System.EventHandler(this.modelBox5_TextChanged);
            // 
            // quantityBox6
            // 
            this.quantityBox6.Location = new System.Drawing.Point(515, 262);
            this.quantityBox6.Name = "quantityBox6";
            this.quantityBox6.Size = new System.Drawing.Size(149, 26);
            this.quantityBox6.TabIndex = 14;
            this.quantityBox6.TextChanged += new System.EventHandler(this.quantityBox6_TextChanged);
            // 
            // IMAGE
            // 
            this.IMAGE.AutoSize = true;
            this.IMAGE.Location = new System.Drawing.Point(425, 322);
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Size = new System.Drawing.Size(62, 20);
            this.IMAGE.TabIndex = 15;
            this.IMAGE.Text = "IMAGE";
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.AutoSize = true;
            this.TotalQuantity.Location = new System.Drawing.Point(743, 32);
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.Size = new System.Drawing.Size(103, 20);
            this.TotalQuantity.TabIndex = 17;
            this.TotalQuantity.Text = "TotalQuantity";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(743, 92);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(79, 20);
            this.TotalPrice.TabIndex = 18;
            this.TotalPrice.Text = "TotalPrice";
            // 
            // BillingName
            // 
            this.BillingName.AutoSize = true;
            this.BillingName.Location = new System.Drawing.Point(743, 155);
            this.BillingName.Name = "BillingName";
            this.BillingName.Size = new System.Drawing.Size(92, 20);
            this.BillingName.TabIndex = 19;
            this.BillingName.Text = "BillingName";
            // 
            // totalquantityBox7
            // 
            this.totalquantityBox7.Location = new System.Drawing.Point(850, 26);
            this.totalquantityBox7.Name = "totalquantityBox7";
            this.totalquantityBox7.Size = new System.Drawing.Size(149, 26);
            this.totalquantityBox7.TabIndex = 20;
            this.totalquantityBox7.TextChanged += new System.EventHandler(this.totalquantityBox7_TextChanged);
            // 
            // totalpriceBox8
            // 
            this.totalpriceBox8.Location = new System.Drawing.Point(850, 86);
            this.totalpriceBox8.Name = "totalpriceBox8";
            this.totalpriceBox8.Size = new System.Drawing.Size(149, 26);
            this.totalpriceBox8.TabIndex = 21;
            this.totalpriceBox8.TextChanged += new System.EventHandler(this.totalpriceBox8_TextChanged);
            // 
            // billingnameBox9
            // 
            this.billingnameBox9.Location = new System.Drawing.Point(850, 149);
            this.billingnameBox9.Name = "billingnameBox9";
            this.billingnameBox9.Size = new System.Drawing.Size(149, 26);
            this.billingnameBox9.TabIndex = 22;
            this.billingnameBox9.TextChanged += new System.EventHandler(this.billingnameBox9_TextChanged);
            // 
            // ORDER
            // 
            this.ORDER.Location = new System.Drawing.Point(826, 256);
            this.ORDER.Name = "ORDER";
            this.ORDER.Size = new System.Drawing.Size(137, 69);
            this.ORDER.TabIndex = 23;
            this.ORDER.Text = "ORDER";
            this.ORDER.UseVisualStyleBackColor = true;
            this.ORDER.Click += new System.EventHandler(this.ORDER_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(503, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 154);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(909, 478);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(90, 42);
            this.EXIT.TabIndex = 25;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(12, 478);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(90, 42);
            this.BACK.TabIndex = 24;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // Customer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.ORDER);
            this.Controls.Add(this.billingnameBox9);
            this.Controls.Add(this.totalpriceBox8);
            this.Controls.Add(this.totalquantityBox7);
            this.Controls.Add(this.BillingName);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.TotalQuantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IMAGE);
            this.Controls.Add(this.quantityBox6);
            this.Controls.Add(this.modelBox5);
            this.Controls.Add(this.priceBox4);
            this.Controls.Add(this.brandBox3);
            this.Controls.Add(this.idBox2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.QUANTITY);
            this.Controls.Add(this.MODEL);
            this.Controls.Add(this.PRICE);
            this.Controls.Add(this.BRAND);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Products);
            this.Name = "Customer2";
            this.Text = "Customer2";
            this.Load += new System.EventHandler(this.Customer2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label BRAND;
        private System.Windows.Forms.Label PRICE;
        private System.Windows.Forms.Label MODEL;
        private System.Windows.Forms.Label QUANTITY;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.TextBox idBox2;
        private System.Windows.Forms.TextBox brandBox3;
        private System.Windows.Forms.TextBox priceBox4;
        private System.Windows.Forms.TextBox modelBox5;
        private System.Windows.Forms.TextBox quantityBox6;
        private System.Windows.Forms.Label IMAGE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TotalQuantity;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label BillingName;
        private System.Windows.Forms.TextBox totalquantityBox7;
        private System.Windows.Forms.TextBox totalpriceBox8;
        private System.Windows.Forms.TextBox billingnameBox9;
        private System.Windows.Forms.Button ORDER;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button BACK;
    }
}