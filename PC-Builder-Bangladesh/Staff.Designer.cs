namespace PCBUILDER
{
    partial class Staff
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
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.ProductDetails = new System.Windows.Forms.Button();
            this.ShowOrder = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(36, 142);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(155, 136);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "AddProduct";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(227, 142);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(155, 136);
            this.DeleteProduct.TabIndex = 1;
            this.DeleteProduct.Text = "DeleteProduct";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // ProductDetails
            // 
            this.ProductDetails.Location = new System.Drawing.Point(409, 142);
            this.ProductDetails.Name = "ProductDetails";
            this.ProductDetails.Size = new System.Drawing.Size(155, 136);
            this.ProductDetails.TabIndex = 2;
            this.ProductDetails.Text = "ProductDetails";
            this.ProductDetails.UseVisualStyleBackColor = true;
            this.ProductDetails.Click += new System.EventHandler(this.ProductDetails_Click);
            // 
            // ShowOrder
            // 
            this.ShowOrder.Location = new System.Drawing.Point(593, 142);
            this.ShowOrder.Name = "ShowOrder";
            this.ShowOrder.Size = new System.Drawing.Size(155, 136);
            this.ShowOrder.TabIndex = 3;
            this.ShowOrder.Text = "ShowOrder";
            this.ShowOrder.UseVisualStyleBackColor = true;
            this.ShowOrder.Click += new System.EventHandler(this.ShowOrder_Click);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(61, 369);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(90, 42);
            this.BACK.TabIndex = 4;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(634, 369);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(90, 42);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.ShowOrder);
            this.Controls.Add(this.ProductDetails);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button ProductDetails;
        private System.Windows.Forms.Button ShowOrder;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button EXIT;
    }
}