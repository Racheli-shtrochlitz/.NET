using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Cashier : Form
    {
        private IOrder _order = BlApi.Factory.Get.Order;
        IProduct _product = BlApi.Factory.Get.Product;
        BO.Order order;
        bool isClubMember;
        public Cashier(bool isForClub)
        {
            InitializeComponent();
            productsGrid.DataSource = _product.ReadAll();
            productsGrid.ReadOnly = true;
            sales.ReadOnly = true;
            order = new BO.Order(new List<BO.ProductInOrder>());
            productsInOrderGrid.DataSource = order.ProductsList;
            isClubMember = isForClub;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void addProductInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void allProductsTable_Selected(object sender, TabControlEventArgs e)
        {
        }

        private void allProductsTable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsGrid_SelectionChanged(object sender, EventArgs e)
        {
            addProductInput.Value = ((BO.Product)productsGrid.CurrentRow.DataBoundItem).Id;

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            BO.Product product;
            try
            {
                product = _product.Read((int)addProductInput.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found");
                return;
            }
            if (amountInput.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero");
                return;
            }
            else if (amountInput.Value > product.Amount)
            {
                MessageBox.Show($"Invalid quantity. You can order up to {product.Amount} units.");
                return;
            }
            List<BO.SaleInProduct> salesList = _order.AddProductToOrder(order, product.Id, (int)amountInput.Value, isClubMember);
            sales.DataSource = null;
            sales.DataSource = salesList;

            updateProductsInOrder();
            updateSales();
        }

        private void productsInOrderGrid_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void updateProductsInOrder()
        {
            productsInOrderGrid.DataSource = null;
            productsInOrderGrid.DataSource = order.ProductsList;
        }
        public void updateSales()
        {
            //sales.DataSource = null;
            //sales.DataSource = order.ProductsList.Select(p => p.SalesList).ToList();
        }

        private void productsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addProductInput.Value = ((BO.Product)productsGrid.CurrentRow.DataBoundItem).Id;

        }
    }
}
