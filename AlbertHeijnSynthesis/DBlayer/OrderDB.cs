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
        LocationDB locationDB = new LocationDB();   
        ProductDB productDB = new ProductDB(); 
        PersonDB personDB = new PersonDB(); 
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            return orders;
        }

        //public List<Order> ReadOrders()
        //{
        //    string sql = "SELECT * FROM Order as or inner join OrderProducts as op on as.id = op.orderId ";

        //    SqlCommand cmd = new SqlCommand(sql, this.conn);

        //    conn.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    List<Order> ReadOrder = new List<Order>();




        //    while (dr.Read())
        //    {
        //        List<Delivery> AllDelivery = GetAllDeliveries();
        //        List<User> users= personDB.ReadUser();
               
              

        //        ReadOrder.Add(new Order(Convert.ToInt32(dr[0]), users.Find(y => y.Id == Convert.ToInt32(dr[1])), Convert.ToString(dr[2]), Convert.ToDecimal(dr[3]), Convert.ToDateTime(dr[4]), AllDelivery.Find(x => x.Id == Convert.ToInt32(dr[5]))));
        //    }
        //    conn.Close();
        //    return ReadOrder;
        //}

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
          
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
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
        private void DeleteOrderProducts(int id, Order order)
        {
            foreach (var item in order.Products)
            {
                string sql = "DELETE FROM OrderProducts  WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(sql, this.conn);
                cmd.Parameters.AddWithValue("@id", item.Id);
               

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

        }

        //public List<Order> ReadAllOrderProduct(int id, Order order)
        //{
        //    //foreach (var item in order.Products )
        //    //{
        //    //    string sql = "SELECT * FROM OrederProducts ";

        //    //    SqlCommand cmd = new SqlCommand(sql, this.conn);

        //    //    conn.Open();
        //    //    SqlDataReader dr = cmd.ExecuteReader();




        //    //    List<Product> products = productDB.ReadProduct();


        //    //    while (dr.Read())
        //    //    {
                   

                    

        //    //    }
        //    //    conn.Close();
        //    //    return ReadAllOrderProduct(order.Products);
        //    //}
        //}
        public void createHomeDelivery(HomeDelivery homeDelivery)
        {
            string sql = "insert into Delivery (Id,type,date,hour,minutes,address) values (@Id,@type,@date,@hour,@minutes,@address);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            cmd.Parameters.AddWithValue("@Id", homeDelivery.Id);
            cmd.Parameters.AddWithValue("@type", "homeDelivery");

            cmd.Parameters.AddWithValue("@date", homeDelivery.DateOfDelivery);
            cmd.Parameters.AddWithValue("@hour", homeDelivery.Hour);
            cmd.Parameters.AddWithValue("@minutes", homeDelivery.Minutes);
            cmd.Parameters.AddWithValue("@address", homeDelivery.Address);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void createLocationDelivery(PickupDelivery pickup)
        {
            string sql = "insert into Delivery (Id,type,date,hour,minutes,pickupLocation) values (@Id,@type,@date,@hour,@minutes,@pickupLocation);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            cmd.Parameters.AddWithValue("@Id", pickup.Id);
            cmd.Parameters.AddWithValue("@type", "pickupLocation");

            cmd.Parameters.AddWithValue("@date", pickup.DateOfDelivery);
            cmd.Parameters.AddWithValue("@hour", pickup.Hour);
            cmd.Parameters.AddWithValue("@minutes", pickup.Minutes);
            cmd.Parameters.AddWithValue("@pickupLocation", pickup.Location.Id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<Delivery> GetAllDeliveries()
        {
            List<Delivery> listODelivery = new List<Delivery>();
            listODelivery.AddRange(ReadLocationDelivery());
            listODelivery.AddRange(ReadLocationDelivery());
            return listODelivery;   
        }

        public List<PickupDelivery> ReadLocationDelivery()
        {
            string sql = "SELECT * FROM Delivery ";

            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<PickupDelivery> pickupDeliveries = new List<PickupDelivery>();
            List<Location> locations = locationDB.ReadLocations();



            while (dr.Read())
            {
                DateTime now = DateTime.Now;
                DateOnly dateOnly = DateOnly.FromDateTime(now);


                pickupDeliveries.Add(new PickupDelivery(Convert.ToInt32(dr[0]), dateOnly, Convert.ToInt32(dr[2]), Convert.ToString(dr[3]), locations.Find(x => x.Id == Convert.ToInt32(dr[4]))));   

            }
            conn.Close();
            return pickupDeliveries;
        }

        public List<HomeDelivery> ReadHomeDelivery()
        {
            string sql = "SELECT * FROM Delivery ";

            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<HomeDelivery> HomeDeliveries = new List<HomeDelivery>();
           



            while (dr.Read())
            {
                DateTime now = DateTime.Now;
                DateOnly dateOnly = DateOnly.FromDateTime(now);


                HomeDeliveries.Add(new HomeDelivery(Convert.ToInt32(dr[0]), dateOnly, Convert.ToInt32(dr[2]), Convert.ToString(dr[3]),  Convert.ToString(dr[4])));

            }
            conn.Close();
            return HomeDeliveries;
        }
    }
}
