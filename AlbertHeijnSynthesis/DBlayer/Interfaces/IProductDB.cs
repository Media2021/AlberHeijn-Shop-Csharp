using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer.Interfaces
{
    public  interface IProductDB
    {
        public List<Product> ReadProduct();
        public List<Category> ReadAllCategory();
        public void CreateProduct(Product product);
        public void UpdateProduct(Product product);

        public void DeleteProduct(Product product);




    }
}
