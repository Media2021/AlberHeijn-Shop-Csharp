using EntitiesLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer
{
    public class OrderDB
    {
        SqlConnection conn = new SqlConnection("server  = mssqlstud.fhict.local;database= dbi499087;User Id = dbi499087; Password=2018Ayham.; ");
        PersonDB productDB = new PersonDB();

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            return orders;
        }

        public List<Order> ReadOrders()
        {
            string sql = "SELECT * FROM Order as or inner join Customer as cu on or.userId = cu.id";

            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Order> order = new List<Order>();

          
           

            while (dr.Read())
            {


                int id = Convert.ToInt32(dr[0]);
                int userId = Convert.ToInt32(dr[1]);
                decimal totalPrice = Convert.ToDecimal(dr[2]);
                DateTime date = Convert.ToDateTime(dr[3]);
                int deliveryId = Convert.ToInt32(dr[4]);

                string name = Convert.ToString(dr[5]);
                string surname = Convert.ToString(dr[6]);
                string userName = Convert.ToString(dr[7]);
                string password = Convert.ToString(dr[8]);


                User user = new User(userId, name, surname, userName, password);
                // I need delivery object!
                //order.Add(new Order(id, user,totalPrice,date,delivery));
            }
            conn.Close();
            return order;
        }

        public void CreateOrder(Order order)
        {
            string sql = "insert into Order (userId,totalPrice,date,deliveryId) values (@userId,@totalPrice,@date,@deliveryId);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            cmd.Parameters.AddWithValue("@userId", order.User.Id);
            cmd.Parameters.AddWithValue("@totalPrice", order.TotalPrice);
            cmd.Parameters.AddWithValue("@date", order.DateOfOrder);
            cmd.Parameters.AddWithValue("@deliveryId", order.Delivery.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            int id = findLastId();
            createOrderProducts(id, order);



        }

        private int findLastId()
        {
            string sql = "SELECT id FROM  Order ORDER BY id DESC LIMIT 1 ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);



            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }

        private void createOrderProducts(int id, Order order)
        {
            foreach (var item in order.Products)
            {
                string sql = "insert into OrderProducts (productId,orderId) values (@productId,@orderId);";
                SqlCommand cmd = new SqlCommand(sql, this.conn);
                cmd.Parameters.AddWithValue("@productId", item.Id);
                cmd.Parameters.AddWithValue("@orderId", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

        }

        public void DeleteOrder(Order order)
        {
            string sql = "DELETE FROM Order WHERE OrderId = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", order.Id );
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateOrder(Order order)
        {
            string sql = "UPDATE Order SET Myproducts = @Myproducts  WHERE OrderId = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", order.Id);
            //I need my products list here.
            //cmd.Parameters.AddWithValue("@addReview", reviewDAL.AddReview);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void createHomeDelivery(HomeDelivery homeDelivery)
        {
            string sql = "insert into Delivery (Id,type,date,hour,minutes,address) values (@Id,@type,@date,@hour,@minutes,@address);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            cmd.Parameters.AddWithValue("@address", homeDelivery.Address);
            cmd.Parameters.AddWithValue("@type", "homeDelivery");
            cmd.Parameters.AddWithValue("@Id", homeDelivery.Id);

            cmd.Parameters.AddWithValue("@date", homeDelivery.DateOfDelivery);
            cmd.Parameters.AddWithValue("@hour", homeDelivery.Hour);
            cmd.Parameters.AddWithValue("@minutes", homeDelivery.Minutes);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void createLocationDelivery(PickupDelivery pickup)
        {
            string sql = "insert into Delivery (Id,type,date,hour,minutes,pickupLocation) values (@Id,@type,@date,@hour,@minutes,@pickupLocation);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            cmd.Parameters.AddWithValue("@pickupLocation", pickup.PickupLocation);
            cmd.Parameters.AddWithValue("@type", "pickupLocation");
            cmd.Parameters.AddWithValue("@Id", pickup.Id);

            cmd.Parameters.AddWithValue("@date", pickup.DateOfDelivery);
            cmd.Parameters.AddWithValue("@hour", pickup.Hour);
            cmd.Parameters.AddWithValue("@minutes", pickup.Minutes);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
