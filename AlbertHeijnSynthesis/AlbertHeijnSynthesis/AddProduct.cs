using BusinessLayer;
using DBlayer;
using EntitiesLayer;
using LogicLayer;
using LogicLayer.Exceptions;
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
        CategoryManager categoryManager = new CategoryManager();
        LocationManager locationManager = new LocationManager();
        PeopleManager peopleManager = new PeopleManager();
        OrderManager orderManager = new OrderManager();
        List<Product> lisOProduct = new List<Product>();
        List<Location> locationList = new List<Location>();
        List<Order> ordersList = new List<Order>();

       
     
        public AddProduct()
        {
            InitializeComponent();
            AddLocationToDGV();
            AddOrdersToDGV();
            AddToDGV();
            updatecats();
            updateOrders();
            updateProduct();
            updateLocation();




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

                Category cat = categoryManager.GetCategories().Find(x => x.Name == comboBox1.Text);
                string name = tb_iPname.Text;
                string unit = tb_Punit.Text;
             
                decimal amount = 0;
                decimal price = 0;

             


                try
                {

                    price = Convert.ToDecimal(tb_Pprice.Text);
                    amount = Convert.ToDecimal(tb_Pamount.Text);


                    Product newproduct = new Product(name, unit, amount, price, cat);
                    productManager.AddProduct(newproduct);

                    AddToDGV();


                    MessageBox.Show(" new product has been saved");

                    tb_iPname.Clear();
                    tb_Punit.Clear();
                    tb_Pprice.Clear();
                    tb_Pamount.Clear();


                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid decimal numbers for both amount and price.");
                }
            }

        }
        public void AddToDGV()
        {
            dgvProducts.Rows.Clear();
            foreach (var item in productManager.GetProducts())
            {
                dgvProducts.Rows.Add(item.Id, item.Item, item.Unit, item.Amount, item.Price, item.Category.Name);
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
            textBox2.Text = product.Unit;
            textBox3.Text = product.Amount.ToString();
            textBox4.Text = product.Price.ToString();
        }

        private void btn_AddLocation_Click(object sender, EventArgs e)
        {
            if (cb_CityName.Text != " " && tb_address.Text != "")
            {
                string city = cb_CityName.Text;
                string address = tb_address.Text;

                Location newLocation = new Location(city, address);

                locationManager.AddLocation(newLocation);



                AddLocationToDGV();


                MessageBox.Show(" a new location has been saved");

                tb_address.Clear();

            }


        }

        public void AddLocationToDGV()
        {
            dgv_location.Rows.Clear();
            foreach (var item in locationManager.GetLocations())
            {
                dgv_location.Rows.Add(item.Id, item.Name, item.Address);
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

            location.Name = tb_EditCity.Text;
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

    

        private void dgv_ShowOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgv_ShowOrders.CurrentCell.RowIndex;
            var order = ordersList[index];

            tb_status.Text = order.Status;

            MessageBox.Show(" now you should  click on one of the radios button then  edit button to change the status");

        }
        public void AddOrdersToDGV()
        {
            dgv_ShowOrders.Rows.Clear();
            var List = orderManager.GetOrders();
            foreach (var item in orderManager.GetOrders())
            {
                if (item.Delivery is HomeDelivery)
                {
                    var item1 = (HomeDelivery)item.Delivery;
                    dgv_ShowOrders.Rows.Add(item.Id, item.User.Username, item.TotalPrice, item.DateOfOrder, item.Delivery.GetType().Name, item1.Address, "", item.Delivery.DateOfDelivery, item.Delivery.Hour, item.Delivery.Minutes, item.Status);

                }
                else
                {
                    var item2 = (PickupDelivery)item.Delivery;


                    dgv_ShowOrders.Rows.Add(item.Id, item.User.Username, item.TotalPrice, item.DateOfOrder, item.Delivery.GetType().Name, item2.Location.Address, item2.Location.Name, item.Delivery.DateOfDelivery, item.Delivery.Hour, item.Delivery.Minutes, item.Status);

                }
            }
        }
        private void updateOrders()
        {
            ordersList.Clear();
            orderManager.UpdateOrderList();
            foreach (var order in orderManager.GetOrders())
            {
                ordersList.Add(order);

            }
        }

        private void btn_editStatus_Click(object sender, EventArgs e)
        {
            int index = dgv_ShowOrders.CurrentCell.RowIndex;
            var order = ordersList[index];

            order.Status = tb_status.Text;
            orderManager.UpdateOrderStatus(order);
            updateOrders();
            AddOrdersToDGV();

        }

        private void btn_addEMP_Click(object sender, EventArgs e)
        {
            if (tb_empName.Text !="" && tb_empSurname.Text !="" && tb_empUsername.Text !=""&& tb_empPassword.Text !="")
                
             
            {

                string name = tb_empName.Text;
                string surname = tb_empSurname.Text;
                string username = tb_empUsername.Text;
                string password = tb_empPassword.Text;

                User user = new User(name, surname, username, password, UserRole.Employee, "");
                try
                {

                    peopleManager.AddUser(user);


                    MessageBox.Show(" a new employee has been added");

                }
             
                 
                catch (UserNameIsExistException)
                {

                    MessageBox.Show(" username is taken try again");

                }
                catch(Exception )
                {
                    MessageBox.Show("fields can not be empty");
                }
              

            }




            tb_empName.Clear();
            tb_empSurname.Clear();
            tb_empUsername.Clear();
            tb_empPassword.Clear();

        }

        private void tb_empPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_empPassword.Text))
            {
                // Display the error message in a message box
                MessageBox.Show("please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                // Clear the error message
                e.Cancel = false;
            }

        }
    }
}

