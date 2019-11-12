using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityF
{
    public partial class Shop : Form
    {
        int _categoryId;
        ProdContext _context;
        Order _currentOrder;
        Customer _currentCustomer;
        public Shop(ProdContext c)
        {
            _context = c;
            InitializeComponent();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context.categories.Load();
            _context.products.Load();
            _context.orders.Load();
            _context.customers.Load();
            _context.orderDetails.Load();
            this.categoryBindingSource.DataSource = _context.categories.Local.ToBindingList();
            
            this.orderBindingSource.DataSource = _context.orders.Local.ToBindingList();
            
            SetUpNewOrder();
            LoadProductsOfSelectedCategory();
        }

        private void SetUpNewOrder()
        {
            _currentOrder = new Order();
            _currentOrder.Customer = _currentCustomer;
            _currentOrder.Paid = false;
            _context.orders.Add(_currentOrder);
            _context.SaveChanges();
            LoadCurrentOrderDetails();
        }

        private void LoadCurrentOrderDetails()
        {
            this.detailsBindingSource.DataSource = new BindingList<OrderDetails>(
                _context.orderDetails.Local.Where(p => p.OrderId == _currentOrder.OrderId).ToList());
        }

        private void LoadCurrentOrderDetailsOfOrder(int orderId)
        {
            this.detailsBindingSource1.DataSource = new BindingList<OrderDetails>(
                _context.orderDetails.Local.Where(p => p.OrderId == orderId).ToList());
        }

        private void LoadProductsOfSelectedCategory()
        {
            this.productsBindingSource.DataSource = new BindingList<Product>(
                    _context.products.Local.Where(p => p.CategoryId == ((Category)this.comboBox1.SelectedItem).CategoryID).ToList());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsOfSelectedCategory();
        }
        
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown1.Value;
            
            int productId = ((Product)this.dataGridView1.SelectedRows[0].DataBoundItem).ProductId;
            OrderDetails orderDetail = _context.orderDetails.Local.Where(o => o.OrderId == _currentOrder.OrderId &&
            o.ProductId == productId).SingleOrDefault();
            if (orderDetail == null)
            {
                orderDetail = new OrderDetails();
                orderDetail.OrderId = _currentOrder.OrderId;
                orderDetail.ProductId = productId;
                _context.orderDetails.Add(orderDetail);

                _context.orderDetails.Add(orderDetail);
            }

            orderDetail.Quantity += quantity;
            LoadCurrentOrderDetails();
            this.dataGridView2.Refresh();
            for(int i=0; i<this.dataGridView2.RowCount; i++)
            {
                OrderRowUpdate(this.dataGridView2, i);
            }
        }

        private void OrderRowUpdate(DataGridView grid, int row)
        {
            if (grid?.Rows[row]?.DataBoundItem == null)
            {
                return;
            }
            int productId = ((OrderDetails)grid.Rows[row].DataBoundItem).ProductId;
            var prod = _context.products.Where(p => p.ProductId == productId).SingleOrDefault();
            grid[0, row].Value = prod.Name;
            grid[1, row].Value = prod.UnitPrice * (int)grid[2, row].Value;
        }

        private void dataGridView2_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            OrderRowUpdate((DataGridView)sender, e.RowIndex);
            if(((OrderDetails)((DataGridView)sender).Rows[e.RowIndex].DataBoundItem).Quantity <= 0)
            {
                ((OrderDetails)((DataGridView)sender).Rows[e.RowIndex].DataBoundItem).Quantity = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            SetUpNewOrder();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCurrentOrderDetailsOfOrder(((Order)((ComboBox)sender).SelectedItem).OrderId);
            for (int i = 0; i < this.dataGridView3.RowCount; i++)
            {
                OrderRowUpdate(this.dataGridView3, i);
            }
        }
    }
}
