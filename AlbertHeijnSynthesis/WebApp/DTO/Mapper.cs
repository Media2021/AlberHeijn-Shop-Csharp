using LogicLayer;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace WebApp.DTO
{
    public class Mapper
    {
        public static OrderDTO mapToOrderDTO(Order order)
        {
            OrderDTO orderDTO = new OrderDTO();
            orderDTO.Id = order.Id;
            orderDTO.User.Username = order.User.Username;
            orderDTO.Products = order.Products;
            orderDTO.DateOfOrder = order.DateOfOrder;
            orderDTO.TotalPrice = order.TotalPrice;
            orderDTO.Delivery.Id = order.Delivery.Id;
            orderDTO.Status = order.Status;
            return orderDTO;
        }
        public static Order mapToOrder(OrderDTO orderDTO, User user)
        {
            Order order = new Order(orderDTO.Id, orderDTO.User, orderDTO.Products, orderDTO.TotalPrice, orderDTO.DateOfOrder , orderDTO.Delivery, orderDTO.Status);

            return order;
        }
    }
}
