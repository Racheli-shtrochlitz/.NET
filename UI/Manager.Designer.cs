namespace UI
{
    partial class Manager
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
            selectCategory = new Label();
            Products = new Button();
            Sales = new Button();
            Customers = new Button();
            SuspendLayout();
            // 
            // selectCategory
            // 
            selectCategory.AutoSize = true;
            selectCategory.Location = new Point(357, 166);
            selectCategory.Name = "selectCategory";
            selectCategory.Size = new Size(89, 15);
            selectCategory.TabIndex = 0;
            selectCategory.Text = "Select Category";
            selectCategory.Click += label1_Click;
            // 
            // Products
            // 
            Products.Location = new Point(259, 208);
            Products.Name = "Products";
            Products.Size = new Size(75, 23);
            Products.TabIndex = 1;
            Products.Text = "Products";
            Products.UseVisualStyleBackColor = true;
            Products.Click += Products_Click;
            // 
            // Sales
            // 
            Sales.Location = new Point(357, 208);
            Sales.Name = "Sales";
            Sales.Size = new Size(75, 23);
            Sales.TabIndex = 2;
            Sales.Text = "Sales";
            Sales.UseVisualStyleBackColor = true;
            Sales.Click += button1_Click;
            // 
            // Customers
            // 
            Customers.Location = new Point(476, 208);
            Customers.Name = "Customers";
            Customers.Size = new Size(75, 23);
            Customers.TabIndex = 3;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Customers);
            Controls.Add(Sales);
            Controls.Add(Products);
            Controls.Add(selectCategory);
            Name = "Manager";
            Text = "Manager";
            Load += Manager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectCategory;
        private Button Products;
        private Button Sales;
        private Button Customers;
    }
}