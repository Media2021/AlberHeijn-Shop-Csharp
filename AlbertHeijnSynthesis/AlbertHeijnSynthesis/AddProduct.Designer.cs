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
            this.tb_Punit = new System.Windows.Forms.TextBox();
            this.tb_iPname = new System.Windows.Forms.TextBox();
            this.tabAddLocation = new System.Windows.Forms.TabPage();
            this.btn_deletLocation = new System.Windows.Forms.Button();
            this.tb_EditCity = new System.Windows.Forms.TextBox();
            this.btn_EditLocation = new System.Windows.Forms.Button();
            this.tb_editAddress = new System.Windows.Forms.TextBox();
            this.dgv_location = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_CityName = new System.Windows.Forms.ComboBox();
            this.btn_AddLocation = new System.Windows.Forms.Button();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tabViewAllProducts = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_updateItem = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_status = new System.Windows.Forms.TabPage();
            this.rb_onway = new System.Windows.Forms.RadioButton();
            this.rb_progress = new System.Windows.Forms.RadioButton();
            this.rb_delivered = new System.Windows.Forms.RadioButton();
            this.btn_editStatus = new System.Windows.Forms.Button();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rb_readyPickup = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabAddProduct.SuspendLayout();
            this.tabAddLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_location)).BeginInit();
            this.tabViewAllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tab_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddProduct);
            this.tabControl1.Controls.Add(this.tabAddLocation);
            this.tabControl1.Controls.Add(this.tabViewAllProducts);
            this.tabControl1.Controls.Add(this.tab_status);
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
            // tabAddLocation
            // 
            this.tabAddLocation.Controls.Add(this.btn_deletLocation);
            this.tabAddLocation.Controls.Add(this.tb_EditCity);
            this.tabAddLocation.Controls.Add(this.btn_EditLocation);
            this.tabAddLocation.Controls.Add(this.tb_editAddress);
            this.tabAddLocation.Controls.Add(this.dgv_location);
            this.tabAddLocation.Controls.Add(this.cb_CityName);
            this.tabAddLocation.Controls.Add(this.btn_AddLocation);
            this.tabAddLocation.Controls.Add(this.tb_address);
            this.tabAddLocation.Location = new System.Drawing.Point(12, 69);
            this.tabAddLocation.Name = "tabAddLocation";
            this.tabAddLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddLocation.Size = new System.Drawing.Size(2650, 928);
            this.tabAddLocation.TabIndex = 1;
            this.tabAddLocation.Text = "Add Locations";
            this.tabAddLocation.UseVisualStyleBackColor = true;
            // 
            // btn_deletLocation
            // 
            this.btn_deletLocation.Location = new System.Drawing.Point(162, 669);
            this.btn_deletLocation.Name = "btn_deletLocation";
            this.btn_deletLocation.Size = new System.Drawing.Size(375, 69);
            this.btn_deletLocation.TabIndex = 17;
            this.btn_deletLocation.Text = "Delete Location";
            this.btn_deletLocation.UseVisualStyleBackColor = true;
            this.btn_deletLocation.Click += new System.EventHandler(this.btn_deletLocation_Click);
            // 
            // tb_EditCity
            // 
            this.tb_EditCity.Location = new System.Drawing.Point(1981, 270);
            this.tb_EditCity.Name = "tb_EditCity";
            this.tb_EditCity.PlaceholderText = "city";
            this.tb_EditCity.Size = new System.Drawing.Size(300, 55);
            this.tb_EditCity.TabIndex = 16;
            this.tb_EditCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_EditLocation
            // 
            this.btn_EditLocation.Location = new System.Drawing.Point(1940, 499);
            this.btn_EditLocation.Name = "btn_EditLocation";
            this.btn_EditLocation.Size = new System.Drawing.Size(375, 69);
            this.btn_EditLocation.TabIndex = 15;
            this.btn_EditLocation.Text = "Edit Location";
            this.btn_EditLocation.UseVisualStyleBackColor = true;
            this.btn_EditLocation.Click += new System.EventHandler(this.btn_EditLocation_Click);
            // 
            // tb_editAddress
            // 
            this.tb_editAddress.Location = new System.Drawing.Point(1981, 373);
            this.tb_editAddress.Name = "tb_editAddress";
            this.tb_editAddress.PlaceholderText = "address";
            this.tb_editAddress.Size = new System.Drawing.Size(300, 55);
            this.tb_editAddress.TabIndex = 14;
            this.tb_editAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_location
            // 
            this.dgv_location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_location.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_location.Location = new System.Drawing.Point(865, 200);
            this.dgv_location.Name = "dgv_location";
            this.dgv_location.RowHeadersWidth = 123;
            this.dgv_location.RowTemplate.Height = 57;
            this.dgv_location.Size = new System.Drawing.Size(1021, 450);
            this.dgv_location.TabIndex = 13;
            this.dgv_location.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_location_CellMouseClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "id";
            this.Column6.MinimumWidth = 15;
            this.Column6.Name = "Column6";
            this.Column6.Width = 300;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "name";
            this.Column7.MinimumWidth = 15;
            this.Column7.Name = "Column7";
            this.Column7.Width = 300;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "address";
            this.Column8.MinimumWidth = 15;
            this.Column8.Name = "Column8";
            this.Column8.Width = 300;
            // 
            // cb_CityName
            // 
            this.cb_CityName.FormattingEnabled = true;
            this.cb_CityName.Items.AddRange(new object[] {
            "Rotterdam",
            "Amsterdam",
            "Eindhoven",
            "Utrecht",
            "Den Hag",
            "Groeningen"});
            this.cb_CityName.Location = new System.Drawing.Point(162, 269);
            this.cb_CityName.Name = "cb_CityName";
            this.cb_CityName.Size = new System.Drawing.Size(375, 56);
            this.cb_CityName.TabIndex = 12;
            // 
            // btn_AddLocation
            // 
            this.btn_AddLocation.Location = new System.Drawing.Point(162, 499);
            this.btn_AddLocation.Name = "btn_AddLocation";
            this.btn_AddLocation.Size = new System.Drawing.Size(375, 69);
            this.btn_AddLocation.TabIndex = 11;
            this.btn_AddLocation.Text = "Add Location";
            this.btn_AddLocation.UseVisualStyleBackColor = true;
            this.btn_AddLocation.Click += new System.EventHandler(this.btn_AddLocation_Click);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(162, 373);
            this.tb_address.Name = "tb_address";
            this.tb_address.PlaceholderText = "address";
            this.tb_address.Size = new System.Drawing.Size(375, 55);
            this.tb_address.TabIndex = 9;
            this.tb_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(2129, 458);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 55);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(2129, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 55);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2129, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 55);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2129, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 55);
            this.textBox1.TabIndex = 3;
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
            // tab_status
            // 
            this.tab_status.Controls.Add(this.rb_readyPickup);
            this.tab_status.Controls.Add(this.rb_onway);
            this.tab_status.Controls.Add(this.rb_progress);
            this.tab_status.Controls.Add(this.rb_delivered);
            this.tab_status.Controls.Add(this.btn_editStatus);
            this.tab_status.Controls.Add(this.tb_status);
            this.tab_status.Controls.Add(this.dataGridView1);
            this.tab_status.Location = new System.Drawing.Point(12, 69);
            this.tab_status.Name = "tab_status";
            this.tab_status.Padding = new System.Windows.Forms.Padding(3);
            this.tab_status.Size = new System.Drawing.Size(2650, 928);
            this.tab_status.TabIndex = 3;
            this.tab_status.Text = "Order status";
            this.tab_status.UseVisualStyleBackColor = true;
            this.tab_status.Click += new System.EventHandler(this.tab_status_Click);
            // 
            // rb_onway
            // 
            this.rb_onway.AutoSize = true;
            this.rb_onway.Location = new System.Drawing.Point(2271, 471);
            this.rb_onway.Name = "rb_onway";
            this.rb_onway.Size = new System.Drawing.Size(189, 52);
            this.rb_onway.TabIndex = 5;
            this.rb_onway.TabStop = true;
            this.rb_onway.Text = "On Way";
            this.rb_onway.UseVisualStyleBackColor = true;
            this.rb_onway.CheckedChanged += new System.EventHandler(this.rb_onway_CheckedChanged);
            // 
            // rb_progress
            // 
            this.rb_progress.AutoSize = true;
            this.rb_progress.Location = new System.Drawing.Point(2271, 302);
            this.rb_progress.Name = "rb_progress";
            this.rb_progress.Size = new System.Drawing.Size(241, 52);
            this.rb_progress.TabIndex = 4;
            this.rb_progress.TabStop = true;
            this.rb_progress.Text = "In Progress";
            this.rb_progress.UseVisualStyleBackColor = true;
            this.rb_progress.CheckedChanged += new System.EventHandler(this.rb_progress_CheckedChanged);
            // 
            // rb_delivered
            // 
            this.rb_delivered.AutoSize = true;
            this.rb_delivered.Location = new System.Drawing.Point(2271, 384);
            this.rb_delivered.Name = "rb_delivered";
            this.rb_delivered.Size = new System.Drawing.Size(215, 52);
            this.rb_delivered.TabIndex = 3;
            this.rb_delivered.TabStop = true;
            this.rb_delivered.Text = "Delivered";
            this.rb_delivered.UseVisualStyleBackColor = true;
            this.rb_delivered.CheckedChanged += new System.EventHandler(this.rb_delivered_CheckedChanged);
            // 
            // btn_editStatus
            // 
            this.btn_editStatus.Location = new System.Drawing.Point(1907, 414);
            this.btn_editStatus.Name = "btn_editStatus";
            this.btn_editStatus.Size = new System.Drawing.Size(225, 69);
            this.btn_editStatus.TabIndex = 2;
            this.btn_editStatus.Text = "Edit status";
            this.btn_editStatus.UseVisualStyleBackColor = true;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(1874, 182);
            this.tb_status.Name = "tb_status";
            this.tb_status.PlaceholderText = "status";
            this.tb_status.Size = new System.Drawing.Size(300, 55);
            this.tb_status.TabIndex = 1;
            this.tb_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridView1.Location = new System.Drawing.Point(25, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1626, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.MinimumWidth = 15;
            this.Column9.Name = "Column9";
            this.Column9.Width = 300;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "user";
            this.Column10.MinimumWidth = 15;
            this.Column10.Name = "Column10";
            this.Column10.Width = 300;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "date";
            this.Column11.MinimumWidth = 15;
            this.Column11.Name = "Column11";
            this.Column11.Width = 300;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "deliveryType";
            this.Column12.MinimumWidth = 15;
            this.Column12.Name = "Column12";
            this.Column12.Width = 300;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "status";
            this.Column13.MinimumWidth = 15;
            this.Column13.Name = "Column13";
            this.Column13.Width = 300;
            // 
            // rb_readyPickup
            // 
            this.rb_readyPickup.AutoSize = true;
            this.rb_readyPickup.Location = new System.Drawing.Point(2271, 218);
            this.rb_readyPickup.Name = "rb_readyPickup";
            this.rb_readyPickup.Size = new System.Drawing.Size(319, 52);
            this.rb_readyPickup.TabIndex = 6;
            this.rb_readyPickup.TabStop = true;
            this.rb_readyPickup.Text = "Ready to pickup";
            this.rb_readyPickup.UseVisualStyleBackColor = true;
            this.rb_readyPickup.CheckedChanged += new System.EventHandler(this.rb_readyPickup_CheckedChanged);
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
            this.tabAddLocation.ResumeLayout(false);
            this.tabAddLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_location)).EndInit();
            this.tabViewAllProducts.ResumeLayout(false);
            this.tabViewAllProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tab_status.ResumeLayout(false);
            this.tab_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAddProduct;
        private TabPage tabAddLocation;
        private Button btn_addProduct;
        private TextBox tb_Pprice;
        private TextBox tb_Punit;
        private TextBox tb_iPname;
        private Button btn_AddLocation;
        private TextBox tb_address;
        private TabPage tabViewAllProducts;
        private Button btn_updateItem;
        private Button btn_deleteItem;
        private DataGridView dgvProducts;
        private TextBox tb_Pamount;
        private ComboBox cb_CityName;
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
        private TextBox tb_EditCity;
        private Button btn_EditLocation;
        private TextBox tb_editAddress;
        private DataGridView dgv_location;
        private Button btn_deletLocation;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TabPage tab_status;
        private RadioButton rb_progress;
        private RadioButton rb_delivered;
        private Button btn_editStatus;
        private TextBox tb_status;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private RadioButton rb_onway;
        private RadioButton rb_readyPickup;
    }
}