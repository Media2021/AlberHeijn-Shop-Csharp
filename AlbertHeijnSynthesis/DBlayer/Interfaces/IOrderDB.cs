using EntitiesLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer.Interfaces
{
    public  interface IOrderDB
    {
        public List<Order> ReadOrders();
        public List<Order> ReadPickupOrders();
        public void CreateOrder(Order order);
        public void CreateOrderPickup(Order order);
        public void UpdateOrderStatus(Order order);
        public void createOrderProducts(int id, Order order);
        public void createHomeDelivery(HomeDelivery homeDelivery);
        public void createPickupDelivery(PickupDelivery pickup);
        public List<Delivery> GetAllDeliveries();
        public List<PickupDelivery> ReadLocationDelivery();
        public List<HomeDelivery> ReadHomeDelivery();












    }
}
