using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Category 
    {
        private int id;
        private string name;
        List<Category> subCategories;

     

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.subCategories = new List < Category >();

        }
        public Category( string name)
        {
            
            this.name = name;
            this.subCategories = new List<Category>();

        }  
        public int Id { get => id; }
        public string Name { get => name; }
        public List<Category> SubCategories { get => subCategories; }


        public void AddSubCategory(Category category)
        {
            if (checkSubCategory (category))
            {
                subCategories.Add(category);
            }
        }
        private bool checkSubCategory(Category category)
        {
            if (category.name == this.name)
            {
                return false;
            }
            foreach (var item in subCategories)
            {
                if (category.name == item.name)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
