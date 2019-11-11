using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EntityF
{
    public partial class CategoryForm : Form
    {
        private int _categoryId = 1;
        private bool _changedCategory = false;

        ProdContext context = new ProdContext();
        public CategoryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context.categories.Load();
            context.products.Load();
            this.categoryBindingSource.DataSource = context.categories.Local.ToBindingList();
            LoadProductsOfSelectedCategory();
            this.productsBindingSource.DataSource = context.products.Local.ToBindingList();
        }

        private void LoadProductsOfSelectedCategory()
        {
            _changedCategory = true;
            this.productsOfCategoryBindingSource.DataSource = new BindingList<Product>(
                    context.products.Local.Where(p => p.CategoryId == _categoryId).ToList());
            _changedCategory = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                context.products.AddRange(
                    ((IEnumerable<EntityF.Product>)this.productsOfCategoryBindingSource.DataSource)
                       .Except(context.products.Local));
                
                context.SaveChanges();
            }catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            CategoriesGridView1.Refresh();
            ProductGridView.Refresh();
        }

        private void CategoryGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(String.IsNullOrEmpty(((DataGridView)sender)[1, e.RowIndex].Value?.ToString()))
            {
                if (e.RowIndex < ((DataGridView)sender).RowCount - 1)
                { 
                    e.Cancel = true;
                }
            }
        }

        private void CategoryGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == ((DataGridView)sender).RowCount - 1) return;
            _categoryId = (int)((DataGridView)sender)[0, e.RowIndex].Value;
            //this.ProductGridView.ClearSelection();
            LoadProductsOfSelectedCategory();
        }

        private void ProductGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            ((DataGridView)sender)[3, e.RowIndex].Value = (decimal)_categoryId;
            if (String.IsNullOrEmpty(((DataGridView)sender)[1, e.RowIndex].Value?.ToString()))
            {
                if (!_changedCategory && e.RowIndex < ((DataGridView)sender).RowCount - 1)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ProductGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            context.Entry(e.Row.DataBoundItem).State = EntityState.Deleted;
        }
    }
}
