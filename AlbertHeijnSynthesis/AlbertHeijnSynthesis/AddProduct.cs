using BusinessLayer;
using DBlayer;
using EntitiesLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddProduct : Form
    {
        ProductManager productManager = new ProductManager();
        
        List<Product> lisOProduct = new List<Product>();
        CategoryManager categoryManager = new CategoryManager();
        LocationManager locationManager = new LocationManager();
        List<Location> locationList = new List<Location>();

        public AddProduct()
        {
            InitializeComponent();
            AddToDGV();
            updatecats();
            updateProduct();
            updateLocation();
            AddLocationToDGV();


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
        public void AddToDGV()
        {
            dgvProducts.Rows.Clear();
            foreach (var item in productManager.GetProducts())
            {
                dgvProducts.Rows.Add(item.Id,item.Item,item.Unit,item.Amount,item.Price,item.Category.Name);
            }
        }
        private void tabViewAllProducts_Click(object sender, EventArgs e)
        {
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

        private void btn_AddLocation_Click(object sender, EventArgs e)
        {
            if (cb_CityName.Text != " " && tb_address.Text !="")
            {
                string city = cb_CityName.Text;
                string address = tb_address.Text;   

                Location newLocation = new Location( city, address);

                locationManager.AddLocation(newLocation);



                AddLocationToDGV();


                MessageBox.Show(" new location has been saved");

              tb_address.Clear();

            }

            
        }
                
        public void AddLocationToDGV()
        {
            dgv_location.Rows.Clear();
            foreach (var item in locationManager.GetLocations())
            {
                dgv_location.Rows.Add(item.Id,item.Name,item.Address);
            }
        }

        private void updateLocation()
        {
            locationList.Clear();
            foreach (var location in locationManager.GetLocations())
            {
                locationList.Add(location);

            }
        }

        private void btn_deletLocation_Click(object sender, EventArgs e)
        {

            int index = dgv_location.CurrentCell.RowIndex;
            var location = locationList[index];
            locationManager.DeleteLocation(location);
            updateLocation();
            AddLocationToDGV();
        }

        private void btn_EditLocation_Click(object sender, EventArgs e)
        {
            int index = dgv_location.CurrentCell.RowIndex;
            var location = locationList[index];

            location.Name= tb_EditCity.Text; 
            location.Address = tb_editAddress.Text; 
            locationManager.UpdateLocation(location);
            updateLocation();
            AddLocationToDGV();
        }

        private void dgv_location_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int index = dgv_location.CurrentCell.RowIndex;
            var location = locationList[index];
             
            tb_EditCity.Text = location.Name;
            tb_editAddress.Text = location.Address;
        }

        private void tab_status_Click(object sender, EventArgs e)
        {

        }

        private void rb_delivered_CheckedChanged(object sender, EventArgs e)
        {
            tb_status.Text = rb_delivered.Text.ToString();
        }

        private void rb_progress_CheckedChanged(object sender, EventArgs e)
        {
            tb_status.Text = rb_progress.Text.ToString();    
        }

        private void rb_onway_CheckedChanged(object sender, EventArgs e)
        {
            tb_status.Text = rb_onway.Text.ToString();
        }

        private void rb_readyPickup_CheckedChanged(object sender, EventArgs e)
        {
            tb_status.Text = rb_readyPickup.Text.ToString();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category b = new Category(2, "Meat");
            Product a = new Product(2, "apple", "kilo", 2, 3, b);
            Product d= new Product(4, "apple", "kilo", 2, 3, b);
            Product c = new Product(5, "apple", "kilo", 2, 3, b);
            User user = new User(3,"media","hannan","mido","123",UserRole.Customer);
            Order order = new Order(user,new List<Product>{ a, d, c },20,DateTime.Now,new HomeDelivery(DateTime.Now, 5,"15","rotterdam location1"));
            OrderDB orderDB = new OrderDB();    
           orderDB.CreateOrder(order);
            //MessageBox.Show(i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            OrderDB orderDB = new OrderDB();
            List<Order> orders = orderDB.ReadOrders();
           

        }
    }
}
