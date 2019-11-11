namespace EntityF
{
    partial class CategoryForm
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
            this.components = new System.ComponentModel.Container();
            this.CategoriesGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsOfCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CategoriesTabPage = new System.Windows.Forms.TabPage();
            this.ProductsTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOfCategoryBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.CategoriesTabPage.SuspendLayout();
            this.ProductsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesGridView1
            // 
            this.CategoriesGridView1.AutoGenerateColumns = false;
            this.CategoriesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.CategoriesGridView1.DataSource = this.categoryBindingSource;
            this.CategoriesGridView1.Location = new System.Drawing.Point(0, 0);
            this.CategoriesGridView1.Name = "CategoriesGridView1";
            this.CategoriesGridView1.Size = new System.Drawing.Size(357, 176);
            this.CategoriesGridView1.TabIndex = 0;
            this.CategoriesGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_RowEnter);
            this.CategoriesGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.CategoryGridView_RowValidating);
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(EntityF.Category);
            // 
            // ProductGridView
            // 
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn1,
            this.unitPriceDataGridViewTextBoxColumn});
            this.ProductGridView.DataSource = this.productsOfCategoryBindingSource;
            this.ProductGridView.Location = new System.Drawing.Point(3, 177);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(563, 216);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ProductGridView_RowValidating);
            this.ProductGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ProductGridView_UserDeletingRow);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn1
            // 
            this.categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
            this.categoryIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsOfCategoryBindingSource
            // 
            this.productsOfCategoryBindingSource.DataMember = "Products";
            this.productsOfCategoryBindingSource.DataSource = this.categoryBindingSource;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(713, 83);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CategoriesTabPage);
            this.tabControl1.Controls.Add(this.ProductsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 425);
            this.tabControl1.TabIndex = 2;
            // 
            // CategoriesTabPage
            // 
            this.CategoriesTabPage.Controls.Add(this.CategoriesGridView1);
            this.CategoriesTabPage.Controls.Add(this.ProductGridView);
            this.CategoriesTabPage.Location = new System.Drawing.Point(4, 22);
            this.CategoriesTabPage.Name = "CategoriesTabPage";
            this.CategoriesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CategoriesTabPage.Size = new System.Drawing.Size(667, 399);
            this.CategoriesTabPage.TabIndex = 0;
            this.CategoriesTabPage.Text = "Categories";
            this.CategoriesTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductsTabPage
            // 
            this.ProductsTabPage.Controls.Add(this.dataGridView1);
            this.ProductsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProductsTabPage.Name = "ProductsTabPage";
            this.ProductsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTabPage.Size = new System.Drawing.Size(667, 399);
            this.ProductsTabPage.TabIndex = 1;
            this.ProductsTabPage.Text = "Products";
            this.ProductsTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn2,
            this.unitsInStockDataGridViewTextBoxColumn1,
            this.categoryIdDataGridViewTextBoxColumn2,
            this.unitPriceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            this.productIdDataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn1.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // unitsInStockDataGridViewTextBoxColumn1
            // 
            this.unitsInStockDataGridViewTextBoxColumn1.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn1.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn1.Name = "unitsInStockDataGridViewTextBoxColumn1";
            // 
            // categoryIdDataGridViewTextBoxColumn2
            // 
            this.categoryIdDataGridViewTextBoxColumn2.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn2.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn2.Name = "categoryIdDataGridViewTextBoxColumn2";
            // 
            // unitPriceDataGridViewTextBoxColumn1
            // 
            this.unitPriceDataGridViewTextBoxColumn1.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.Name = "unitPriceDataGridViewTextBoxColumn1";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.categoryBindingSource;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveButton);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOfCategoryBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.CategoriesTabPage.ResumeLayout(false);
            this.ProductsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridView CategoriesGridView1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.BindingSource productsOfCategoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CategoriesTabPage;
        private System.Windows.Forms.TabPage ProductsTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}