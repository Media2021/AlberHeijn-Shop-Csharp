using DBlayer.Interfaces;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DBlayer
{
    public class ProductDB : IProductDB
    {
        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");

        SqlConnection conn1 = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();


            return products;
        }

        public List<Product> ReadProduct()
        {
            string sql = "SELECT * FROM Product ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn1);

            conn1.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Product> product = new List<Product>();
            List<Category> categories = ReadAllCategory();

            while (dr.Read())
            {

                product.Add(new Product(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToDecimal(dr[3]), Convert.ToDecimal(dr[4]), categories.Find(x => x.Id == Convert.ToInt32(dr[5]))));

            }


            conn1.Close();
            return product;
        }
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
            return ReadAllSubCategory(categories);
            ////return categories;
        }
        private List<Category> ReadAllSubCategory(List<Category> categories)
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



        public void CreateProduct(Product product)
        {
            string sql = "insert into Product (item,unit,amount,price , categoryId) values ( @item,@unit,@amount,@price,@categoryId);";

            SqlCommand cmd = new SqlCommand(sql, this.conn);


            cmd.Parameters.AddWithValue("@item", product.Item);
            cmd.Parameters.AddWithValue("@unit", product.Unit);
            cmd.Parameters.AddWithValue("@amount", product.Amount);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@categoryId", product.Category.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void DeleteProduct(Product product)
        {
            string sql = "DELETE FROM Product WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", product.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateProduct(Product product)
        {
            string sql = "UPDATE Product SET item = @item , unit=@unit , amount=@amount , price=@price , categoryId = @categoryId  WHERE Id = @id;";


            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("@item", product.Item);
            cmd.Parameters.AddWithValue("@unit", product.Unit);
            cmd.Parameters.AddWithValue("@amount", product.Amount);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@categoryId", product.Category.Id);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
