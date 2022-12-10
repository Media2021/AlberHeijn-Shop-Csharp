namespace PresentationLayer
{
    partial class AddProduct
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddProduct = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_Pamount = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.tb_Pprice = new System.Windows.Forms.TextBox();
            this.tb_categoryId = new System.Windows.Forms.TextBox();
            this.tb_Punit = new System.Windows.Forms.TextBox();
            this.tb_iPname = new System.Windows.Forms.TextBox();
            this.tabAddCategory = new System.Windows.Forms.TabPage();
            this.cb_subCatName = new System.Windows.Forms.ComboBox();
            this.cb_catName = new System.Windows.Forms.ComboBox();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.tb_subCategory = new System.Windows.Forms.TextBox();
            this.tb_Ca_name = new System.Windows.Forms.TextBox();
            this.tabViewAllProducts = new System.Windows.Forms.TabPage();
            this.btn_updateItem = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabAddProduct.SuspendLayout();
            this.tabAddCategory.SuspendLayout();
            this.tabViewAllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddProduct);
            this.tabControl1.Controls.Add(this.tabAddCategory);
            this.tabControl1.Controls.Add(this.tabViewAllProducts);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2674, 1009);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.Controls.Add(this.comboBox1);
            this.tabAddProduct.Controls.Add(this.tb_Pamount);
            this.tabAddProduct.Controls.Add(this.btn_addProduct);
            this.tabAddProduct.Controls.Add(this.tb_Pprice);
            this.tabAddProduct.Controls.Add(this.tb_categoryId);
            this.tabAddProduct.Controls.Add(this.tb_Punit);
            this.tabAddProduct.Controls.Add(this.tb_iPname);
            this.tabAddProduct.Location = new System.Drawing.Point(12, 69);
            this.tabAddProduct.Name = "tabAddProduct";
            this.tabAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProduct.Size = new System.Drawing.Size(2650, 928);
            this.tabAddProduct.TabIndex = 0;
            this.tabAddProduct.Text = "Add Product";
            this.tabAddProduct.UseVisualStyleBackColor = true;
            this.tabAddProduct.Click += new System.EventHandler(this.tabAddProduct_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1191, 566);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(363, 56);
            this.comboBox1.TabIndex = 9;
            // 
            // tb_Pamount
            // 
            this.tb_Pamount.Location = new System.Drawing.Point(1221, 357);
            this.tb_Pamount.Name = "tb_Pamount";
            this.tb_Pamount.PlaceholderText = "product amount";
            this.tb_Pamount.Size = new System.Drawing.Size(300, 55);
            this.tb_Pamount.TabIndex = 7;
            this.tb_Pamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(1164, 708);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(421, 69);
            this.btn_addProduct.TabIndex = 5;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // tb_Pprice
            // 
            this.tb_Pprice.Location = new System.Drawing.Point(1221, 447);
            this.tb_Pprice.Name = "tb_Pprice";
            this.tb_Pprice.PlaceholderText = "product price";
            this.tb_Pprice.Size = new System.Drawing.Size(300, 55);
            this.tb_Pprice.TabIndex = 4;
            this.tb_Pprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_categoryId
            // 
            this.tb_categoryId.Location = new System.Drawing.Point(130, 590);
            this.tb_categoryId.Name = "tb_categoryId";
            this.tb_categoryId.PlaceholderText = "category id";
            this.tb_categoryId.Size = new System.Drawing.Size(300, 55);
            this.tb_categoryId.TabIndex = 3;
            this.tb_categoryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Punit
            // 
            this.tb_Punit.Location = new System.Drawing.Point(1221, 248);
            this.tb_Punit.Name = "tb_Punit";
            this.tb_Punit.PlaceholderText = "product unit";
            this.tb_Punit.Size = new System.Drawing.Size(300, 55);
            this.tb_Punit.TabIndex = 1;
            this.tb_Punit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_iPname
            // 
            this.tb_iPname.Location = new System.Drawing.Point(1221, 144);
            this.tb_iPname.Name = "tb_iPname";
            this.tb_iPname.PlaceholderText = "product name";
            this.tb_iPname.Size = new System.Drawing.Size(300, 55);
            this.tb_iPname.TabIndex = 0;
            this.tb_iPname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabAddCategory
            // 
            this.tabAddCategory.Controls.Add(this.cb_subCatName);
            this.tabAddCategory.Controls.Add(this.cb_catName);
            this.tabAddCategory.Controls.Add(this.btn_AddCategory);
            this.tabAddCategory.Controls.Add(this.tb_subCategory);
            this.tabAddCategory.Controls.Add(this.tb_Ca_name);
            this.tabAddCategory.Location = new System.Drawing.Point(12, 69);
            this.tabAddCategory.Name = "tabAddCategory";
            this.tabAddCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCategory.Size = new System.Drawing.Size(2650, 928);
            this.tabAddCategory.TabIndex = 1;
            this.tabAddCategory.Text = "Add Category";
            this.tabAddCategory.UseVisualStyleBackColor = true;
            // 
            // cb_subCatName
            // 
            this.cb_subCatName.FormattingEnabled = true;
            this.cb_subCatName.Location = new System.Drawing.Point(1150, 389);
            this.cb_subCatName.Name = "cb_subCatName";
            this.cb_subCatName.Size = new System.Drawing.Size(363, 56);
            this.cb_subCatName.TabIndex = 13;
            // 
            // cb_catName
            // 
            this.cb_catName.FormattingEnabled = true;
            this.cb_catName.Items.AddRange(new object[] {
            "Meat",
            "Vegetables",
            "Fruit",
            "Grains"});
            this.cb_catName.Location = new System.Drawing.Point(1150, 286);
            this.cb_catName.Name = "cb_catName";
            this.cb_catName.Size = new System.Drawing.Size(363, 56);
            this.cb_catName.TabIndex = 12;
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(1138, 516);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(375, 69);
            this.btn_AddCategory.TabIndex = 11;
            this.btn_AddCategory.Text = "Add Category";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // tb_subCategory
            // 
            this.tb_subCategory.Location = new System.Drawing.Point(596, 390);
            this.tb_subCategory.Name = "tb_subCategory";
            this.tb_subCategory.PlaceholderText = " sub-category";
            this.tb_subCategory.Size = new System.Drawing.Size(300, 55);
            this.tb_subCategory.TabIndex = 9;
            this.tb_subCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ca_name
            // 
            this.tb_Ca_name.Location = new System.Drawing.Point(596, 287);
            this.tb_Ca_name.Name = "tb_Ca_name";
            this.tb_Ca_name.PlaceholderText = "category name";
            this.tb_Ca_name.Size = new System.Drawing.Size(300, 55);
            this.tb_Ca_name.TabIndex = 7;
            this.tb_Ca_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabViewAllProducts
            // 
            this.tabViewAllProducts.Controls.Add(this.textBox4);
            this.tabViewAllProducts.Controls.Add(this.textBox3);
            this.tabViewAllProducts.Controls.Add(this.textBox2);
            this.tabViewAllProducts.Controls.Add(this.textBox1);
            this.tabViewAllProducts.Controls.Add(this.btn_updateItem);
            this.tabViewAllProducts.Controls.Add(this.btn_deleteItem);
            this.tabViewAllProducts.Controls.Add(this.dgvProducts);
            this.tabViewAllProducts.Location = new System.Drawing.Point(12, 69);
            this.tabViewAllProducts.Name = "tabViewAllProducts";
            this.tabViewAllProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAllProducts.Size = new System.Drawing.Size(2650, 928);
            this.tabViewAllProducts.TabIndex = 2;
            this.tabViewAllProducts.Text = "Products INFO";
            this.tabViewAllProducts.UseVisualStyleBackColor = true;
            this.tabViewAllProducts.Click += new System.EventHandler(this.tabViewAllProducts_Click);
            // 
            // btn_updateItem
            // 
            this.btn_updateItem.Location = new System.Drawing.Point(2164, 617);
            this.btn_updateItem.Name = "btn_updateItem";
            this.btn_updateItem.Size = new System.Drawing.Size(225, 69);
            this.btn_updateItem.TabIndex = 2;
            this.btn_updateItem.Text = "Update item";
            this.btn_updateItem.UseVisualStyleBackColor = true;
            this.btn_updateItem.Click += new System.EventHandler(this.btn_updateItem_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(1061, 810);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(225, 69);
            this.btn_deleteItem.TabIndex = 1;
            this.btn_deleteItem.Text = "Delete item";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProducts.Location = new System.Drawing.Point(19, 21);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 123;
            this.dgvProducts.RowTemplate.Height = 57;
            this.dgvProducts.Size = new System.Drawing.Size(1923, 584);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 15;
            this.id.Name = "id";
            this.id.Width = 300;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "name";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "unit";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "amount";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "price";
            this.Column4.MinimumWidth = 15;
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "category Id";
            this.Column5.MinimumWidth = 15;
            this.Column5.Name = "Column5";
            this.Column5.Width = 300;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2129, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 55);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2129, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 55);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(2129, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 55);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(2129, 458);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 55);
            this.textBox4.TabIndex = 6;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2716, 1044);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddProduct";
            this.Text = "Product";
            this.tabControl1.ResumeLayout(false);
            this.tabAddProduct.ResumeLayout(false);
            this.tabAddProduct.PerformLayout();
            this.tabAddCategory.ResumeLayout(false);
            this.tabAddCategory.PerformLayout();
            this.tabViewAllProducts.ResumeLayout(false);
            this.tabViewAllProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAddProduct;
        private TabPage tabAddCategory;
        private Button btn_addProduct;
        private TextBox tb_Pprice;
        private TextBox tb_categoryId;
        private TextBox tb_Punit;
        private TextBox tb_iPname;
        private Button btn_AddCategory;
        private TextBox tb_subCategory;
        private TextBox tb_Ca_name;
        private TabPage tabViewAllProducts;
        private Button btn_updateItem;
        private Button btn_deleteItem;
        private DataGridView dgvProducts;
        private TextBox tb_Pamount;
        private ComboBox cb_subCatName;
        private ComboBox cb_catName;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}