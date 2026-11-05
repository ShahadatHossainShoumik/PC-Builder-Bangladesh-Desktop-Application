namespace PCBUILDER
{
    partial class OrderPC
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
            this.PRODUCTS = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MONITOR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MONITORBox1 = new System.Windows.Forms.TextBox();
            this.MOUSEBox2 = new System.Windows.Forms.TextBox();
            this.KEYBOARDBox = new System.Windows.Forms.TextBox();
            this.CPUBox = new System.Windows.Forms.TextBox();
            this.PROCESSORBox = new System.Windows.Forms.TextBox();
            this.MOTHERBOARDBox = new System.Windows.Forms.TextBox();
            this.RAMBox = new System.Windows.Forms.TextBox();
            this.ROMBox = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalPriceBox = new System.Windows.Forms.TextBox();
            this.ProductBox = new System.Windows.Forms.TextBox();
            this.BillingNameBox = new System.Windows.Forms.TextBox();
            this.Order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addmonitor = new System.Windows.Forms.Button();
            this.DeleteMonitor = new System.Windows.Forms.Button();
            this.AddMouse = new System.Windows.Forms.Button();
            this.DeleteMouse = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteCPU = new System.Windows.Forms.Button();
            this.addCPU = new System.Windows.Forms.Button();
            this.deletekeyboard = new System.Windows.Forms.Button();
            this.addkeyboard = new System.Windows.Forms.Button();
            this.deletemotherboard = new System.Windows.Forms.Button();
            this.addmotherboard = new System.Windows.Forms.Button();
            this.deleteprocessor = new System.Windows.Forms.Button();
            this.addprocessor = new System.Windows.Forms.Button();
            this.deleterom = new System.Windows.Forms.Button();
            this.addrom = new System.Windows.Forms.Button();
            this.deleteram = new System.Windows.Forms.Button();
            this.addram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PRODUCTS
            // 
            this.PRODUCTS.AutoSize = true;
            this.PRODUCTS.Location = new System.Drawing.Point(30, 23);
            this.PRODUCTS.Name = "PRODUCTS";
            this.PRODUCTS.Size = new System.Drawing.Size(98, 20);
            this.PRODUCTS.TabIndex = 1;
            this.PRODUCTS.Text = "PRODUCTS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MONITOR
            // 
            this.MONITOR.AutoSize = true;
            this.MONITOR.Location = new System.Drawing.Point(448, 50);
            this.MONITOR.Name = "MONITOR";
            this.MONITOR.Size = new System.Drawing.Size(83, 20);
            this.MONITOR.TabIndex = 3;
            this.MONITOR.Text = "MONITOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MOUSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "KEYBOARD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "PROCESSOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "MOTHERBOARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "ROM";
            // 
            // MONITORBox1
            // 
            this.MONITORBox1.Location = new System.Drawing.Point(591, 47);
            this.MONITORBox1.Name = "MONITORBox1";
            this.MONITORBox1.Size = new System.Drawing.Size(141, 26);
            this.MONITORBox1.TabIndex = 11;
            this.MONITORBox1.TextChanged += new System.EventHandler(this.MONITORBox1_TextChanged);
            // 
            // MOUSEBox2
            // 
            this.MOUSEBox2.Location = new System.Drawing.Point(591, 85);
            this.MOUSEBox2.Name = "MOUSEBox2";
            this.MOUSEBox2.Size = new System.Drawing.Size(141, 26);
            this.MOUSEBox2.TabIndex = 12;
            this.MOUSEBox2.TextChanged += new System.EventHandler(this.MOUSEBox2_TextChanged);
            // 
            // KEYBOARDBox
            // 
            this.KEYBOARDBox.Location = new System.Drawing.Point(591, 124);
            this.KEYBOARDBox.Name = "KEYBOARDBox";
            this.KEYBOARDBox.Size = new System.Drawing.Size(141, 26);
            this.KEYBOARDBox.TabIndex = 13;
            this.KEYBOARDBox.TextChanged += new System.EventHandler(this.KEYBOARDBox_TextChanged);
            // 
            // CPUBox
            // 
            this.CPUBox.Location = new System.Drawing.Point(591, 159);
            this.CPUBox.Name = "CPUBox";
            this.CPUBox.Size = new System.Drawing.Size(141, 26);
            this.CPUBox.TabIndex = 14;
            this.CPUBox.TextChanged += new System.EventHandler(this.CPUBox_TextChanged);
            // 
            // PROCESSORBox
            // 
            this.PROCESSORBox.Location = new System.Drawing.Point(591, 197);
            this.PROCESSORBox.Name = "PROCESSORBox";
            this.PROCESSORBox.Size = new System.Drawing.Size(141, 26);
            this.PROCESSORBox.TabIndex = 15;
            this.PROCESSORBox.TextChanged += new System.EventHandler(this.PROCESSORBox_TextChanged);
            // 
            // MOTHERBOARDBox
            // 
            this.MOTHERBOARDBox.Location = new System.Drawing.Point(591, 237);
            this.MOTHERBOARDBox.Name = "MOTHERBOARDBox";
            this.MOTHERBOARDBox.Size = new System.Drawing.Size(141, 26);
            this.MOTHERBOARDBox.TabIndex = 16;
            this.MOTHERBOARDBox.TextChanged += new System.EventHandler(this.MOTHERBOARDBox_TextChanged);
            // 
            // RAMBox
            // 
            this.RAMBox.Location = new System.Drawing.Point(591, 281);
            this.RAMBox.Name = "RAMBox";
            this.RAMBox.Size = new System.Drawing.Size(141, 26);
            this.RAMBox.TabIndex = 17;
            this.RAMBox.TextChanged += new System.EventHandler(this.RAMBox_TextChanged);
            // 
            // ROMBox
            // 
            this.ROMBox.Location = new System.Drawing.Point(591, 319);
            this.ROMBox.Name = "ROMBox";
            this.ROMBox.Size = new System.Drawing.Size(141, 26);
            this.ROMBox.TabIndex = 18;
            this.ROMBox.TextChanged += new System.EventHandler(this.ROMBox_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(914, 47);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(68, 20);
            this.Quantity.TabIndex = 19;
            this.Quantity.Text = "Quantity";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(914, 102);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(79, 20);
            this.TotalPrice.TabIndex = 20;
            this.TotalPrice.Text = "TotalPrice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(914, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Products";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(914, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "BillingName";
            // 
            // TotalPriceBox
            // 
            this.TotalPriceBox.Location = new System.Drawing.Point(1021, 96);
            this.TotalPriceBox.Name = "TotalPriceBox";
            this.TotalPriceBox.Size = new System.Drawing.Size(141, 26);
            this.TotalPriceBox.TabIndex = 24;
            this.TotalPriceBox.TextChanged += new System.EventHandler(this.TotalPriceBox_TextChanged);
            // 
            // ProductBox
            // 
            this.ProductBox.Location = new System.Drawing.Point(1021, 153);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(141, 26);
            this.ProductBox.TabIndex = 25;
            this.ProductBox.TextChanged += new System.EventHandler(this.ProductBox_TextChanged);
            // 
            // BillingNameBox
            // 
            this.BillingNameBox.Location = new System.Drawing.Point(1021, 209);
            this.BillingNameBox.Name = "BillingNameBox";
            this.BillingNameBox.Size = new System.Drawing.Size(141, 26);
            this.BillingNameBox.TabIndex = 26;
            this.BillingNameBox.TextChanged += new System.EventHandler(this.BillingNameBox_TextChanged);
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(1036, 281);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(110, 43);
            this.Order.TabIndex = 27;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(930, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addmonitor
            // 
            this.addmonitor.Location = new System.Drawing.Point(748, 47);
            this.addmonitor.Name = "addmonitor";
            this.addmonitor.Size = new System.Drawing.Size(70, 26);
            this.addmonitor.TabIndex = 30;
            this.addmonitor.Text = "Add";
            this.addmonitor.UseVisualStyleBackColor = true;
            this.addmonitor.Click += new System.EventHandler(this.addmonitor_Click);
            // 
            // DeleteMonitor
            // 
            this.DeleteMonitor.Location = new System.Drawing.Point(824, 47);
            this.DeleteMonitor.Name = "DeleteMonitor";
            this.DeleteMonitor.Size = new System.Drawing.Size(70, 26);
            this.DeleteMonitor.TabIndex = 31;
            this.DeleteMonitor.Text = "Delete";
            this.DeleteMonitor.UseVisualStyleBackColor = true;
            this.DeleteMonitor.Click += new System.EventHandler(this.DeleteMonitor_Click);
            // 
            // AddMouse
            // 
            this.AddMouse.Location = new System.Drawing.Point(748, 85);
            this.AddMouse.Name = "AddMouse";
            this.AddMouse.Size = new System.Drawing.Size(70, 26);
            this.AddMouse.TabIndex = 32;
            this.AddMouse.Text = "Add";
            this.AddMouse.UseVisualStyleBackColor = true;
            this.AddMouse.Click += new System.EventHandler(this.AddMouse_Click);
            // 
            // DeleteMouse
            // 
            this.DeleteMouse.Location = new System.Drawing.Point(824, 85);
            this.DeleteMouse.Name = "DeleteMouse";
            this.DeleteMouse.Size = new System.Drawing.Size(70, 26);
            this.DeleteMouse.TabIndex = 33;
            this.DeleteMouse.Text = "Delete";
            this.DeleteMouse.UseVisualStyleBackColor = true;
            this.DeleteMouse.Click += new System.EventHandler(this.DeleteMouse_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(1021, 41);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(141, 26);
            this.QuantityBox.TabIndex = 34;
            this.QuantityBox.TextChanged += new System.EventHandler(this.QuantityBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(410, 343);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // deleteCPU
            // 
            this.deleteCPU.Location = new System.Drawing.Point(824, 165);
            this.deleteCPU.Name = "deleteCPU";
            this.deleteCPU.Size = new System.Drawing.Size(70, 26);
            this.deleteCPU.TabIndex = 39;
            this.deleteCPU.Text = "Delete";
            this.deleteCPU.UseVisualStyleBackColor = true;
            this.deleteCPU.Click += new System.EventHandler(this.deleteCPU_Click);
            // 
            // addCPU
            // 
            this.addCPU.Location = new System.Drawing.Point(748, 165);
            this.addCPU.Name = "addCPU";
            this.addCPU.Size = new System.Drawing.Size(70, 26);
            this.addCPU.TabIndex = 38;
            this.addCPU.Text = "Add";
            this.addCPU.UseVisualStyleBackColor = true;
            this.addCPU.Click += new System.EventHandler(this.addCPU_Click);
            // 
            // deletekeyboard
            // 
            this.deletekeyboard.Location = new System.Drawing.Point(824, 127);
            this.deletekeyboard.Name = "deletekeyboard";
            this.deletekeyboard.Size = new System.Drawing.Size(70, 26);
            this.deletekeyboard.TabIndex = 37;
            this.deletekeyboard.Text = "Delete";
            this.deletekeyboard.UseVisualStyleBackColor = true;
            this.deletekeyboard.Click += new System.EventHandler(this.deletekeyboard_Click);
            // 
            // addkeyboard
            // 
            this.addkeyboard.Location = new System.Drawing.Point(748, 127);
            this.addkeyboard.Name = "addkeyboard";
            this.addkeyboard.Size = new System.Drawing.Size(70, 26);
            this.addkeyboard.TabIndex = 36;
            this.addkeyboard.Text = "Add";
            this.addkeyboard.UseVisualStyleBackColor = true;
            this.addkeyboard.Click += new System.EventHandler(this.addkeyboard_Click);
            // 
            // deletemotherboard
            // 
            this.deletemotherboard.Location = new System.Drawing.Point(824, 238);
            this.deletemotherboard.Name = "deletemotherboard";
            this.deletemotherboard.Size = new System.Drawing.Size(70, 26);
            this.deletemotherboard.TabIndex = 43;
            this.deletemotherboard.Text = "Delete";
            this.deletemotherboard.UseVisualStyleBackColor = true;
            this.deletemotherboard.Click += new System.EventHandler(this.deletemotherboard_Click);
            // 
            // addmotherboard
            // 
            this.addmotherboard.Location = new System.Drawing.Point(748, 238);
            this.addmotherboard.Name = "addmotherboard";
            this.addmotherboard.Size = new System.Drawing.Size(70, 26);
            this.addmotherboard.TabIndex = 42;
            this.addmotherboard.Text = "Add";
            this.addmotherboard.UseVisualStyleBackColor = true;
            this.addmotherboard.Click += new System.EventHandler(this.addmotherboard_Click);
            // 
            // deleteprocessor
            // 
            this.deleteprocessor.Location = new System.Drawing.Point(824, 200);
            this.deleteprocessor.Name = "deleteprocessor";
            this.deleteprocessor.Size = new System.Drawing.Size(70, 26);
            this.deleteprocessor.TabIndex = 41;
            this.deleteprocessor.Text = "Delete";
            this.deleteprocessor.UseVisualStyleBackColor = true;
            this.deleteprocessor.Click += new System.EventHandler(this.deleteprocessor_Click);
            // 
            // addprocessor
            // 
            this.addprocessor.Location = new System.Drawing.Point(748, 200);
            this.addprocessor.Name = "addprocessor";
            this.addprocessor.Size = new System.Drawing.Size(70, 26);
            this.addprocessor.TabIndex = 40;
            this.addprocessor.Text = "Add";
            this.addprocessor.UseVisualStyleBackColor = true;
            this.addprocessor.Click += new System.EventHandler(this.addprocessor_Click);
            // 
            // deleterom
            // 
            this.deleterom.Location = new System.Drawing.Point(824, 316);
            this.deleterom.Name = "deleterom";
            this.deleterom.Size = new System.Drawing.Size(70, 26);
            this.deleterom.TabIndex = 47;
            this.deleterom.Text = "Delete";
            this.deleterom.UseVisualStyleBackColor = true;
            this.deleterom.Click += new System.EventHandler(this.deleterom_Click);
            // 
            // addrom
            // 
            this.addrom.Location = new System.Drawing.Point(748, 316);
            this.addrom.Name = "addrom";
            this.addrom.Size = new System.Drawing.Size(70, 26);
            this.addrom.TabIndex = 46;
            this.addrom.Text = "Add";
            this.addrom.UseVisualStyleBackColor = true;
            this.addrom.Click += new System.EventHandler(this.addrom_Click);
            // 
            // deleteram
            // 
            this.deleteram.Location = new System.Drawing.Point(824, 278);
            this.deleteram.Name = "deleteram";
            this.deleteram.Size = new System.Drawing.Size(70, 26);
            this.deleteram.TabIndex = 45;
            this.deleteram.Text = "Delete";
            this.deleteram.UseVisualStyleBackColor = true;
            this.deleteram.Click += new System.EventHandler(this.deleteram_Click);
            // 
            // addram
            // 
            this.addram.Location = new System.Drawing.Point(748, 278);
            this.addram.Name = "addram";
            this.addram.Size = new System.Drawing.Size(70, 26);
            this.addram.TabIndex = 44;
            this.addram.Text = "Add";
            this.addram.UseVisualStyleBackColor = true;
            this.addram.Click += new System.EventHandler(this.addram_Click);
            // 
            // OrderPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.deleterom);
            this.Controls.Add(this.addrom);
            this.Controls.Add(this.deleteram);
            this.Controls.Add(this.addram);
            this.Controls.Add(this.deletemotherboard);
            this.Controls.Add(this.addmotherboard);
            this.Controls.Add(this.deleteprocessor);
            this.Controls.Add(this.addprocessor);
            this.Controls.Add(this.deleteCPU);
            this.Controls.Add(this.addCPU);
            this.Controls.Add(this.deletekeyboard);
            this.Controls.Add(this.addkeyboard);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.DeleteMouse);
            this.Controls.Add(this.AddMouse);
            this.Controls.Add(this.DeleteMonitor);
            this.Controls.Add(this.addmonitor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.BillingNameBox);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.TotalPriceBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ROMBox);
            this.Controls.Add(this.RAMBox);
            this.Controls.Add(this.MOTHERBOARDBox);
            this.Controls.Add(this.PROCESSORBox);
            this.Controls.Add(this.CPUBox);
            this.Controls.Add(this.KEYBOARDBox);
            this.Controls.Add(this.MOUSEBox2);
            this.Controls.Add(this.MONITORBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MONITOR);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PRODUCTS);
            this.Name = "OrderPC";
            this.Text = "OrderPC";
            this.Load += new System.EventHandler(this.OrderPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PRODUCTS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label MONITOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MONITORBox1;
        private System.Windows.Forms.TextBox MOUSEBox2;
        private System.Windows.Forms.TextBox KEYBOARDBox;
        private System.Windows.Forms.TextBox CPUBox;
        private System.Windows.Forms.TextBox PROCESSORBox;
        private System.Windows.Forms.TextBox MOTHERBOARDBox;
        private System.Windows.Forms.TextBox RAMBox;
        private System.Windows.Forms.TextBox ROMBox;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalPriceBox;
        private System.Windows.Forms.TextBox ProductBox;
        private System.Windows.Forms.TextBox BillingNameBox;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addmonitor;
        private System.Windows.Forms.Button DeleteMonitor;
        private System.Windows.Forms.Button AddMouse;
        private System.Windows.Forms.Button DeleteMouse;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteCPU;
        private System.Windows.Forms.Button addCPU;
        private System.Windows.Forms.Button deletekeyboard;
        private System.Windows.Forms.Button addkeyboard;
        private System.Windows.Forms.Button deletemotherboard;
        private System.Windows.Forms.Button addmotherboard;
        private System.Windows.Forms.Button deleteprocessor;
        private System.Windows.Forms.Button addprocessor;
        private System.Windows.Forms.Button deleterom;
        private System.Windows.Forms.Button addrom;
        private System.Windows.Forms.Button deleteram;
        private System.Windows.Forms.Button addram;
    }
}