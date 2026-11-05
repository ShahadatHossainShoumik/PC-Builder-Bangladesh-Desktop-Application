namespace PCBUILDER
{
    partial class CUSTOMER
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
            this.OrderProduct = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.OrderPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderProduct
            // 
            this.OrderProduct.Location = new System.Drawing.Point(408, 338);
            this.OrderProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderProduct.Name = "OrderProduct";
            this.OrderProduct.Size = new System.Drawing.Size(185, 58);
            this.OrderProduct.TabIndex = 0;
            this.OrderProduct.Text = "OrderProduct";
            this.OrderProduct.UseVisualStyleBackColor = true;
            this.OrderProduct.Click += new System.EventHandler(this.OrderProduct_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(852, 469);
            this.EXIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(120, 52);
            this.EXIT.TabIndex = 9;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(88, 469);
            this.BACK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(120, 52);
            this.BACK.TabIndex = 8;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // OrderPC
            // 
            this.OrderPC.Location = new System.Drawing.Point(408, 165);
            this.OrderPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderPC.Name = "OrderPC";
            this.OrderPC.Size = new System.Drawing.Size(185, 55);
            this.OrderPC.TabIndex = 10;
            this.OrderPC.Text = "OrderPC";
            this.OrderPC.UseVisualStyleBackColor = true;
            this.OrderPC.Click += new System.EventHandler(this.OrderPC_Click);
            // 
            // CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.OrderPC);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.OrderProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CUSTOMER";
            this.Text = "CUSTOMER";
            this.Load += new System.EventHandler(this.CUSTOMER_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrderProduct;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button OrderPC;
    }
}