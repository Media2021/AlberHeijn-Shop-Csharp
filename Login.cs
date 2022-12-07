using BusinessLayer;
using DBlayer;
using LogicLayer;
using PresentationLayer;

namespace Synthesis
{
    public partial class Login : Form
    {
        PeopleManager peopleManager = new PeopleManager();
        PersonDB personDB = new PersonDB();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            bool result = peopleManager.LoginEMP(username, password);

                Employee person = new Employee();
            if (result)
            {
                Employee loggedEMP = peopleManager.GetLoggedInEMP(password);
                if (loggedEMP != null)
                {

                    if (loggedEMP.Role == "Admin")
                    {
                        this.Hide();
                        AddProduct addProduct = new AddProduct();
                        addProduct.Show();


                    }

                }
            }
            else
                    {
                        MessageBox.Show("you are not the admin");
                    }

        }
    }
}