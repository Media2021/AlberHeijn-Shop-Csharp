using DBlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public  class CategoryManager
    {
        List<Category> categories = new List<Category>();
        CategoryDB categoryDB = new CategoryDB();

        public CategoryManager()
        {
            UpdateCategories();
        }    
        public List<Category> GetCategories()
        {
            return categories;

        }

        public void  UpdateCategories()
        {
            categories.Clear();
            categories.AddRange(categoryDB.ReadAllCategory());

        }

    }
}
