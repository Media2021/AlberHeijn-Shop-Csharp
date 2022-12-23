using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public  class Product
    {
        private int id;
      
        private string item;
       

        private string unit;
        

        private decimal amount;
        

        private decimal price;
        private  Category category;

     

        public  Product(int id, string item, string unit, decimal amount, decimal price, Category category)
        {
            this.id = id;
            this.item = item;
            this.unit = unit;
            this.amount = amount;
            this.price = price;
            this.category = category;
        }
        public  Product( string item, string unit, decimal amount, decimal price,Category category )
        {

            this.item = item;
            this.unit = unit;
            this.amount = amount;
            this.price = price;
            this.category = category;

        }

        public Product(List<Product> products, int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public string Unit { get => unit; set => unit = value; }
        public decimal Amount { get=> amount; set => amount = value; }
        public decimal Price { get => price; set => price = value; }
        public Category Category { get => category;}
    }
}
