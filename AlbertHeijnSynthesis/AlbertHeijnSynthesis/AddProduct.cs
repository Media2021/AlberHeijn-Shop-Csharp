using BusinessLayer;
using DBlayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddProduct : Form
    {
        ProductManager productManager = new ProductManager();
        //ProductDB productDB = new ProductDB();
        List<Product> lisOProduct = new List<Product>();
        CategoryManager categoryManager = new CategoryManager();

        public AddProduct()
        {
            InitializeComponent();
            AddToDGV();
            updatecats();
            updateProduct();


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updatecats()
        {
            comboBox1.Items.Clear();
            foreach (var item in categoryManager.GetCategories())
            {
                comboBox1.Items.Add(item.Name);
            }

        }
        private void btn_addProduct_Click(object sender, EventArgs e)
        {

            if (tb_iPname.Text != "" && tb_Punit.Text != "" && tb_Pamount.Text != "" && tb_Pprice.Text != "" && comboBox1.SelectedIndex != -1)
            {

                string name = tb_iPname.Text;
                string unit = tb_Punit.Text;
                decimal amount = Convert.ToDecimal(tb_Pamount.Text);
                decimal price = Convert.ToDecimal(tb_Pprice.Text);
                Category cat = categoryManager.GetCategories().Find(x => x.Name == comboBox1.Text);



                Product newproduct = new Product(name, unit, amount, price, cat);
                productManager.AddProduct(newproduct);

                AddToDGV();


                MessageBox.Show(" new product has been saved");

                tb_iPname.Clear();
                tb_Punit.Clear();
                tb_Pprice.Clear();


            }
        }
        private void btn_AddCategory_Click(object sender, EventArgs e)
        {

        }
        public void AddToDGV()
        {
            dgvProducts.Rows.Clear();
            foreach (var item in productManager.GetProducts())
            {
                dgvProducts.Rows.Add(item.Id,item.Item,item.Unit,item.Amount,item.Price,item.Category.Id);
            }
        }
        private void tabViewAllProducts_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            AddToDGV();

        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            int index = dgvProducts.CurrentCell.RowIndex;
            var product = lisOProduct[index];
            productManager.DeleteProduct(product);
            updateProduct();
            AddToDGV();

        }
        private void updateProduct()
        {
            lisOProduct.Clear();
            foreach (var product in productManager.GetProducts())
            {
                lisOProduct.Add(product);

            }
        }

        private void btn_updateItem_Click(object sender, EventArgs e)
        {
            int index = dgvProducts.CurrentCell.RowIndex;
            var product = lisOProduct[index];

            product.Item = textBox1.Text;
            product.Unit = textBox2.Text;
            product.Amount = Convert.ToDecimal(textBox3.Text);
            product.Price = Convert.ToDecimal(textBox4.Text);
            productManager.UpdateProduct(product);
            updateProduct();
            AddToDGV();

        }

        private void tabAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgvProducts.CurrentCell.RowIndex;
            var product = lisOProduct[index];

            textBox1.Text = product.Item;
            textBox2.Text = product.Unit ;
            textBox3.Text = product.Amount.ToString() ;
            textBox4.Text= product.Price.ToString() ;
        }
    }
}
