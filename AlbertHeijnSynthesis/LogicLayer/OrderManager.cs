using DBlayer;
using EntitiesLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLayer
{
    public  class OrderManager
    {
        OrderDB orderDB = new OrderDB();
        List<Order> orders = new List<Order>();
        List<Delivery> deliveries= new List<Delivery>();

        public OrderManager() 
        {
            UpdateOrderList();
        }

        public List<Order> GetOrders()
        { 
            return orders;
        }
     
        public List<Delivery> GetAllDeliveries()
        {
            List<Delivery> listODelivery = new List<Delivery>();
            listODelivery.AddRange(orderDB.GetAllDeliveries());

           
            return listODelivery;
        }
        public void UpdateOrderList()
        {
            orders.Clear();
            orders.AddRange(orderDB.ReadOrders());
            orders.AddRange(orderDB.ReadPickupOrders());    


        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
            if (order.Delivery is HomeDelivery)
            {
            orderDB.CreateOrder(order);

            }
           else if(order.Delivery is PickupDelivery) 
            {
                orderDB.CreateOrderPickup(order);

            }



        }
      
      
        public void UpdateOrderStatus(Order order)
        {
            orders.Clear();
            orderDB.UpdateOrderStatus(order);


        }
      
      
    }
}
