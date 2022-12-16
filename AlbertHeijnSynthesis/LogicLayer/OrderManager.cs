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
        public List<Delivery> GetDeliveries() 
        { 
            return deliveries;
        }

        public void UpdateOrderList()
        {
            orders.Clear();
            orders.AddRange(orderDB.ReadOrders());

        }

        public void UpdateDeliveryList()

        {
            deliveries.Clear();
            List<Delivery> deliveryList = new List<Delivery>();

            deliveryList.AddRange(orderDB.GetAllDeliveries());

            foreach (Delivery delivery in deliveryList)
            {
                if (delivery is HomeDelivery)
                {
                    deliveries.Add((HomeDelivery)delivery);

                }
                else
                {
                    deliveries.Add((PickupDelivery)delivery);

                }
            }
        }

        public  void AddDeliveryType(Delivery delivery)
        {
            deliveries.Add(delivery);
           
           
                if (delivery is HomeDelivery)
                {
                    orderDB.createHomeDelivery((HomeDelivery)delivery);

                }
                else
                {
                    orderDB.createLocationDelivery((PickupDelivery)delivery);

                }
           


        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
            orderDB.CreateOrder(order);


        }

      
        public void DeleteOrder(Order order)
        {
            orders.Remove(order);
            orderDB.DeleteOrder(order);


        }
        public void UpdateOrderStatus(Order order)
        {
            orders.Clear();
            orderDB.UpdateOrderStatus(order);


        }

      
    }
}
