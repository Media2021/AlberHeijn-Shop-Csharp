﻿using EntitiesLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public List<Order> ReadOrders()
        {
            string sql = "SELECT * FROM [dbi499087].[dbo].[Order] as o inner join OrderProducts as op on o.id = op.orderId inner join Product as pr on pr.id = op.productId inner join MyUsers1 as us on us.id = o.userId inner join Category as ca on ca.id = pr.categoryId inner join Delivery as de on de.id = o.deliveryId ";

            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Order> ReadOrder = new List<Order>();




            while (dr.Read())
            {
                //List<Delivery> AllDelivery = GetAllDeliveries();
                //List<User> users = personDB.ReadUser();

                if (ReadOrder.Exists(x=>x.Id== Convert.ToInt32(dr[0])))
                {
                    ReadOrder.Find(x => x.Id == Convert.ToInt32(dr[0])).AddProduct(new Product(Convert.ToInt32(dr[8]), Convert.ToString(dr[9]), Convert.ToString(dr[10]), Convert.ToDecimal(dr[11]), Convert.ToDecimal(dr[12]),new Category( Convert.ToInt32(dr[13]), Convert.ToString(dr[21]))));
                }
                else
                {
                    User user =  new  User(Convert.ToInt32(dr[14]), Convert.ToString(dr[15]), Convert.ToString(dr[16]), Convert.ToString(dr[17]), Convert.ToString(dr[18]), (UserRole)Convert.ToInt32(dr[19]));
                   Product product =  new Product(Convert.ToInt32(dr[8]), Convert.ToString(dr[9]), Convert.ToString(dr[10]), Convert.ToDecimal(dr[11]), Convert.ToDecimal(dr[12]), new Category(Convert.ToInt32(dr[13]), Convert.ToString(dr[21])));
                    if (Convert.ToString(dr[23])== "homeDelivery")
                    {
                      
                        HomeDelivery homeDelivery = new HomeDelivery(Convert.ToInt32(dr[22]), (Convert.ToDateTime(dr[24])), Convert.ToInt32(dr[25]), Convert.ToString(dr[26]), Convert.ToString(dr[27]));
                    ReadOrder.Add(new Order(Convert.ToInt32(dr[0]), user, new List<Product>{ product } , Convert.ToDecimal(dr[2]), Convert.ToDateTime(dr[3]), homeDelivery));
                    }
                    //else
                    //{
                    //    Location location = new Location(Convert.ToInt32(dr[29]), Convert.ToString(dr[30]), Convert.ToString(dr[31]));
                    //   PickupDelivery pickupDelivery = new  PickupDelivery(Convert.ToInt32(dr[22]), (Convert.ToDateTime(dr[24])), Convert.ToInt32(dr[25]), Convert.ToString(dr[26]), location);
                    //    ReadOrder.Add(new Order(Convert.ToInt32(dr[0]), user, new List<Product> { product }, Convert.ToDecimal(dr[3]), Convert.ToDateTime(dr[4]), pickupDelivery));

                    //}

;
                }

              
            }
            conn.Close();
            return ReadOrder;
        }

        public List<Order> ReadPickupOrders()
        {
            string sql = "SELECT * FROM [dbi499087].[dbo].[Order] as o inner join OrderProducts as op on o.id = op.orderId inner join Product as pr on pr.id = op.productId inner join MyUsers1 as us on us.id = o.userId inner join Category as ca on ca.id = pr.categoryId inner join Delivery as de on de.id = o.deliveryId inner join pickupLocation as lo on lo.id = de.pickupLocation";

            SqlCommand cmd = new SqlCommand(sql, this.conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Order> ReadOrder = new List<Order>();




            while (dr.Read())
            {
                //List<Delivery> AllDelivery = GetAllDeliveries();
                //List<User> users = personDB.ReadUser();

                if (ReadOrder.Exists(x => x.Id == Convert.ToInt32(dr[0])))
                {
                    ReadOrder.Find(x => x.Id == Convert.ToInt32(dr[0])).AddProduct(new Product(Convert.ToInt32(dr[8]), Convert.ToString(dr[9]), Convert.ToString(dr[10]), Convert.ToDecimal(dr[11]), Convert.ToDecimal(dr[12]), new Category(Convert.ToInt32(dr[13]), Convert.ToString(dr[21]))));
                }
                else
                {
                    User user = new User(Convert.ToInt32(dr[14]), Convert.ToString(dr[15]), Convert.ToString(dr[16]), Convert.ToString(dr[17]), Convert.ToString(dr[18]), (UserRole)Convert.ToInt32(dr[19]));
                    Product product = new Product(Convert.ToInt32(dr[8]), Convert.ToString(dr[9]), Convert.ToString(dr[10]), Convert.ToDecimal(dr[11]), Convert.ToDecimal(dr[12]), new Category(Convert.ToInt32(dr[13]), Convert.ToString(dr[21])));
                   
                    if(Convert.ToString(dr[23]) == "pickupLocation")
                    {
                        Location location = new Location(Convert.ToInt32(dr[29]), Convert.ToString(dr[30]), Convert.ToString(dr[31]));
                        PickupDelivery pickupDelivery = new PickupDelivery(Convert.ToInt32(dr[22]), (Convert.ToDateTime(dr[24])), Convert.ToInt32(dr[25]), Convert.ToString(dr[26]), location);
                        ReadOrder.Add(new Order(Convert.ToInt32(dr[0]), user, new List<Product> { product }, Convert.ToDecimal(dr[2]), Convert.ToDateTime(dr[3]), pickupDelivery));

                    }

;
                }


            }
            conn.Close();
            return ReadOrder;
        }

        public void CreateOrder(Order order)
        {
            createHomeDelivery((HomeDelivery)order.Delivery);
           int id1 =  findLastHomeDeliveryId();
            order.Delivery.Id = id1;
            string sql = "insert into [dbi499087].[dbo].[Order] (userId,totalPrice,date,deliveryId) values (@userId,@totalPrice,@date,@deliveryId);";
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
        //public int CreateOrder(Order order)
        //{


        //    string sql = "begin declare @orderID int insert into [dbi499087].[dbo].[Order] (userId,totalPrice,date,deliveryId) values(@userId,@totalPrice,@date,@deliveryId) select @orderID = @@identity SELECT CAST(@orderID AS int)" + (char)10 + " end " + (char)10 + " go ";
        //    SqlCommand cmd = new SqlCommand(sql, this.conn);



        //    cmd.Parameters.AddWithValue("@userId", order.User.Id);
        //    cmd.Parameters.AddWithValue("@totalPrice", order.TotalPrice);
        //    cmd.Parameters.AddWithValue("@date", order.DateOfOrder);
        //    cmd.Parameters.AddWithValue("@deliveryId", order.Delivery.Id);
        //    conn.Open();
        //    int resul = (int)cmd.ExecuteScalar();
        //    conn.Close();
        //    return resul;
        //}


        private int findLastId()
        {
            string sql = "SELECT TOP 1 * FROM [dbi499087].[dbo].[Order] ORDER BY id DESC ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);



            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }

       
        public void DeleteOrder(Order order)
        {
            string sql = "DELETE FROM [dbi499087].[dbo].[Order]  WHERE OrderId = @id;";

            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id", order.Id );
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateOrder(Order order)
        {
            string sql = "UPDATE [dbi499087].[dbo].[Order]  SET Myproducts = @Myproducts  WHERE OrderId = @id;";

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
            string sql = "insert into Delivery (type,date,hour,minutes,address) values (@type,@date,@hour,@minutes,@address);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            //cmd.Parameters.AddWithValue("@Id", homeDelivery.Id);
            cmd.Parameters.AddWithValue("@type", "homeDelivery");

            cmd.Parameters.AddWithValue("@date", homeDelivery.DateOfDelivery);
            cmd.Parameters.AddWithValue("@hour", homeDelivery.Hour);
            cmd.Parameters.AddWithValue("@minutes", homeDelivery.Minutes);
            cmd.Parameters.AddWithValue("@address", homeDelivery.Address);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private int findLastHomeDeliveryId()
        {
            string sql = "SELECT TOP 1 * FROM Delivery ORDER BY id DESC ;";
            SqlCommand cmd = new SqlCommand(sql, this.conn);



            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }
        public void createLocationDelivery(PickupDelivery pickup)
        {
            string sql = "insert into Delivery (type,date,hour,minutes,pickupLocation) values (@type,@date,@hour,@minutes,@pickupLocation);";
            SqlCommand cmd = new SqlCommand(sql, this.conn);

            //cmd.Parameters.AddWithValue("@Id", pickup.Id);
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
               


                pickupDeliveries.Add(new PickupDelivery(Convert.ToInt32(dr[0]), Convert.ToDateTime(dr[1]), Convert.ToInt32(dr[2]), Convert.ToString(dr[3]), locations.Find(x => x.Id == Convert.ToInt32(dr[4]))));   

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
               


                HomeDeliveries.Add(new HomeDelivery(Convert.ToInt32(dr[0]), Convert.ToDateTime(dr[1]), Convert.ToInt32(dr[2]), Convert.ToString(dr[3]),  Convert.ToString(dr[4])));

            }
            conn.Close();
            return HomeDeliveries;
        }
    }
}
