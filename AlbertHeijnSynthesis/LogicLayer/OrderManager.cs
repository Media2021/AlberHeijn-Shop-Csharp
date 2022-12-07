using DBlayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class OrderManager
    {
        OrderDB orderDB = new OrderDB();
        List<Order> orders = new List<Order>();


        public OrderManager() 
        { 

        }

        public List<Order> GetOrders()
        { 
            return orders;
        }

        public void UpdateOrderList()
        {
            orders.Clear();
            orders.AddRange(orderDB.ReadOrders());

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
        public void UpdateOrder(Order order)
        {
            orders.Clear();
            orderDB.UpdateOrder(order);


        }
    }
}
