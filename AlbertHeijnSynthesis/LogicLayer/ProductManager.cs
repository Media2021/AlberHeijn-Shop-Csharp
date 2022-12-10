using DBlayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class ProductManager
    {
        ProductDB productDB = new ProductDB();
        List<Product> products= new List<Product>();

        public ProductManager()
        {
            UpdateProductList();
        }

        public List<Product> GetProducts() 
        { 
            return products;
        }
        public void UpdateProductList()
        {
            products.Clear();
            products.AddRange(productDB.ReadProduct());
         
        }

        public void AddProduct(Product product)
        {
           products.Add(product);
            productDB.CreateProduct(product);


        }
        public void DeleteProduct(Product product)
        {
            products.Remove(product);
            productDB.DeleteProduct(product);


        }
        public void UpdateProduct(Product product)
        {
           productDB.UpdateProduct(product);


        }
    }
}
