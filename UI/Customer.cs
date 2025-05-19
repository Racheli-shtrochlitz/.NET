using BlApi;

namespace UI
{
    public partial class Customer : Form
    {
        private ICustomer _customer = BlApi.Factory.Get.Customer;
        DataGridView grid;
        public Customer()
        {
            InitializeComponent();
            grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true,
                ReadOnly = true,
                DataSource = _customer.ReadAll()
            };

            tabPage1.Controls.Add(grid);
            idFilter.Items.AddRange(_customer.ReadAll().Select(c => c.Id.ToString()).ToArray());
        }


        private void UpdateDetails(object? sender, FormClosedEventArgs e)
        {
            grid.DataSource = _customer.ReadAll();
            grid.Refresh();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CustomerEditor p = new CustomerEditor("ADD");
            p.Show();
            p.FormClosed += UpdateDetails;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CustomerEditor p = new CustomerEditor("UPDATE", (BO.Customer)grid.CurrentRow.DataBoundItem);
            p.Show();
            p.FormClosed += UpdateDetails;
            grid.DataSource = _customer.ReadAll();
            grid.Refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.DataBoundItem == null)
                MessageBox.Show("Please select product");
            else
            {
                BO.Customer selectedProduct = (BO.Customer)grid.CurrentRow.DataBoundItem;
                _customer.Delete(selectedProduct.Id);
                grid.DataSource = _customer.ReadAll();
                grid.Refresh();
            }
        }

        private void idFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid.DataSource = _customer.ReadAll(c => c.Id.ToString() == idFilter.SelectedItem.ToString());
        }
    }
}
