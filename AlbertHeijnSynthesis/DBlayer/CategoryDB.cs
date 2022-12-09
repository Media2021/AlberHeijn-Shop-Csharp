using LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer
{
    public  class CategoryDB
    {
        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");

        public List<Category> ReadAllCategory()
        {
            string sql = "SELECT * FROM Category;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Category> categories = new List<Category>();

            while (dr.Read())
            {
                categories.Add(new Category(Convert.ToInt32(dr[0]), Convert.ToString(dr[1])));

            }


            conn.Close();
            return readAllSubCategory(categories);
            ////return categories;
        }
        private List<Category> readAllSubCategory(List<Category> categories)
        {
            string sql = "SELECT * FROM SubCategory;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Category> SubCategorib = new List<Category>();

            while (dr.Read())
            {
                SubCategorib.Add(new Category(Convert.ToInt32(dr[0]), Convert.ToString(dr[1])));
                int catId = Convert.ToInt32(dr[1]);

                int subCatId = Convert.ToInt32(dr[2]);
                //find  subcategorry and add it in subCategory list inside category
                categories.Find(x => x.Id == catId).AddSubCategory(categories.Find(y => y.Id == subCatId));
            }


            conn.Close();
            return categories;
        }
    }
}
