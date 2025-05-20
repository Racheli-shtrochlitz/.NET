namespace UI
{
    partial class Cashier
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            totalPrice = new Label();
            addProductBtn = new Button();
            addProductInput = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            amountInput = new NumericUpDown();
            doOrderBtn = new Button();
            productBindingSource = new BindingSource(components);
            productsGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productInOrderBindingSource = new BindingSource(components);
            productInOrderBindingSource1 = new BindingSource(components);
            productsInOrderGrid = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            sales = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            isForClubDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            saleBindingSource = new BindingSource(components);
            saleInProductBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)addProductInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsInOrderGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleInProductBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 353);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Total price";
            label1.Click += label1_Click;
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(384, 377);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(13, 15);
            totalPrice.TabIndex = 3;
            totalPrice.Text = "0";
            // 
            // addProductBtn
            // 
            addProductBtn.Location = new Point(77, 367);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(148, 35);
            addProductBtn.TabIndex = 4;
            addProductBtn.Text = "Add product";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // addProductInput
            // 
            addProductInput.Location = new Point(194, 88);
            addProductInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            addProductInput.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            addProductInput.Name = "addProductInput";
            addProductInput.Size = new Size(120, 23);
            addProductInput.TabIndex = 5;
            addProductInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            addProductInput.ValueChanged += addProductInput_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(326, 18);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 7;
            label2.Text = "Place an order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 295);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 8;
            label3.Text = "choose amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 59);
            label4.Name = "label4";
            label4.Size = new Size(232, 15);
            label4.TabIndex = 9;
            label4.Text = "Insert product code or choose from the list";
            // 
            // amountInput
            // 
            amountInput.Location = new Point(77, 323);
            amountInput.Margin = new Padding(3, 2, 3, 2);
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(131, 23);
            amountInput.TabIndex = 10;
            // 
            // doOrderBtn
            // 
            doOrderBtn.Location = new Point(605, 364);
            doOrderBtn.Margin = new Padding(3, 2, 3, 2);
            doOrderBtn.Name = "doOrderBtn";
            doOrderBtn.Size = new Size(111, 28);
            doOrderBtn.TabIndex = 11;
            doOrderBtn.Text = "Do order";
            doOrderBtn.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BO.Product);
            // 
            // productsGrid
            // 
            productsGrid.AutoGenerateColumns = false;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            productsGrid.DataSource = productBindingSource;
            productsGrid.Location = new Point(60, 128);
            productsGrid.Margin = new Padding(3, 2, 3, 2);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersWidth = 51;
            productsGrid.RowTemplate.Height = 29;
            productsGrid.Size = new Size(262, 141);
            productsGrid.TabIndex = 0;
            productsGrid.CellContentClick += productsGrid_CellContentClick;
            productsGrid.SelectionChanged += productsGrid_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productInOrderBindingSource
            // 
            productInOrderBindingSource.DataSource = typeof(BO.ProductInOrder);
            // 
            // productInOrderBindingSource1
            // 
            productInOrderBindingSource1.DataSource = typeof(BO.ProductInOrder);
            // 
            // productsInOrderGrid
            // 
            productsInOrderGrid.AutoGenerateColumns = false;
            productsInOrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsInOrderGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, productNameDataGridViewTextBoxColumn, originPriceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, finalPriceDataGridViewTextBoxColumn });
            productsInOrderGrid.DataSource = productInOrderBindingSource;
            productsInOrderGrid.Location = new Point(360, 102);
            productsInOrderGrid.Margin = new Padding(3, 2, 3, 2);
            productsInOrderGrid.Name = "productsInOrderGrid";
            productsInOrderGrid.RowHeadersWidth = 51;
            productsInOrderGrid.RowTemplate.Height = 29;
            productsInOrderGrid.Size = new Size(196, 214);
            productsInOrderGrid.TabIndex = 14;
            productsInOrderGrid.SelectionChanged += productsInOrderGrid_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // originPriceDataGridViewTextBoxColumn
            // 
            originPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginPrice";
            originPriceDataGridViewTextBoxColumn.HeaderText = "OriginPrice";
            originPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            originPriceDataGridViewTextBoxColumn.Name = "originPriceDataGridViewTextBoxColumn";
            originPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            finalPriceDataGridViewTextBoxColumn.HeaderText = "FinalPrice";
            finalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            finalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 84);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 15;
            label5.Text = "Products in order";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(618, 84);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 16;
            label6.Text = "sales in order";
            // 
            // sales
            // 
            sales.AutoGenerateColumns = false;
            sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sales.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, isForClubDataGridViewCheckBoxColumn });
            sales.DataSource = saleBindingSource;
            sales.Location = new Point(589, 102);
            sales.Name = "sales";
            sales.RowTemplate.Height = 25;
            sales.Size = new Size(160, 214);
            sales.TabIndex = 17;
            sales.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // isForClubDataGridViewCheckBoxColumn
            // 
            isForClubDataGridViewCheckBoxColumn.DataPropertyName = "IsForClub";
            isForClubDataGridViewCheckBoxColumn.HeaderText = "IsForClub";
            isForClubDataGridViewCheckBoxColumn.Name = "isForClubDataGridViewCheckBoxColumn";
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(BO.Sale);
            // 
            // saleInProductBindingSource
            // 
            saleInProductBindingSource.DataSource = typeof(BO.SaleInProduct);
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sales);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(productsInOrderGrid);
            Controls.Add(productsGrid);
            Controls.Add(doOrderBtn);
            Controls.Add(amountInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addProductInput);
            Controls.Add(addProductBtn);
            Controls.Add(totalPrice);
            Controls.Add(label1);
            Name = "Cashier";
            ((System.ComponentModel.ISupportInitialize)addProductInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsInOrderGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sales).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleInProductBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label totalPrice;
        private Button addProductBtn;
        private NumericUpDown addProductInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown amountInput;
        private Button doOrderBtn;
        private BindingSource productBindingSource;
        private DataGridView productsGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private BindingSource productInOrderBindingSource;
        private BindingSource productInOrderBindingSource1;
        private DataGridView productsInOrderGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private Label label5;
        private Label label6;
        private DataGridView sales;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn isForClubDataGridViewCheckBoxColumn;
        private BindingSource saleBindingSource;
        private BindingSource saleInProductBindingSource;
    }
}