using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public  class Order 
    {
        private int id;
        private User user;
        private List<Product> products;
        private decimal totalPrice;
        private DateTime dateOfOrder;
        private Delivery delivery;
        private string status;

        public Order(int id, User user, List<Product> products, decimal totalPrice, DateTime dateOfOrder, Delivery delivery, string status)
        {
            this.id = id;
            this.user = user;
            this.products = products;
            this.totalPrice = totalPrice;
            this.dateOfOrder = dateOfOrder;
            this.delivery = delivery;
            this.status = status;
        }
        public Order( User user, List<Product> products, decimal totalPrice, DateTime dateOfOrder, Delivery delivery, string status)
        {
           
            this.user = user;
            this.products = products;
            this.totalPrice = totalPrice;
            this.dateOfOrder = dateOfOrder;
            this.delivery = delivery;
            this.status = status;   
        }
        public Order(int id, User user, decimal totalPrice, Delivery delivery, string status)
        {
           
            this.user = user;
            this.products = new List<Product>();
            this.totalPrice = totalPrice;
            this.dateOfOrder = DateTime.Now;
            this.delivery = delivery;
            this.status = status;   
        }

        public int Id { get => id; }
        public User User { get => user; }
        public List<Product> Products { get => products;  }
        public decimal TotalPrice { get => totalPrice;  }
        public DateTime DateOfOrder { get => dateOfOrder;  }
        public Delivery Delivery { get => delivery;  }
        public string Status { get => status; set => status = value; }

        public void AddProduct(Product product)
        {
            products.Add(product);
            totalPrice += product.Price;

        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
            totalPrice -= product.Price;
        }

      
    }
}
