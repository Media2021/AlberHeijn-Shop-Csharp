﻿using BusinessLayer;
using DBlayer;
using LogicLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertHeijnSynthesis
{
    public partial class Home1 : Form
    {
        PeopleManager peopleManager = new PeopleManager();
        OrderDB or = new OrderDB();

        public Home1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

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