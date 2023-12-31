﻿using DBlayer;
using DBlayer.Interfaces;
using LogicLayer;
using LogicLayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class ProductManager 
    {
        private IProductDB productDB1 ;    
       
        List<Product> products= new List<Product>();

        public ProductManager() : this(new ProductDB())
        {
           
        }
        public ProductManager(IProductDB productDB2)
        {
            this.productDB1 = productDB2;
            UpdateProductList();
        }
        public List<Product> GetProducts() 
        { 
            return products;
        }
        public void UpdateProductList()
        {
            products.Clear();
            products.AddRange(productDB1.ReadProduct());
         
        }

        public void   AddProduct(Product product)
        {
            products.Add(product);
            productDB1.CreateProduct(product);

        }
        public void DeleteProduct(Product product)
        {
            products.Remove(product);
            productDB1.DeleteProduct(product);


        }
        public void UpdateProduct(Product product)
        {
            productDB1.UpdateProduct(product);


        }
        public List<Product> filterProduct(string name )
        {
             List<Product> filtered = new List<Product>();
            if ( String.IsNullOrEmpty(name))
            {
                return products;
            }
            filtered.AddRange(products.FindAll(x=> x.Item.ToUpper().Contains(name.ToUpper())));
            return filtered;    
        }
    }
}
