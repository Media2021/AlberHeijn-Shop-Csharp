using EntitiesLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace WebApp.DTO
{
    public class Mapper
    {
        public static OrderDTO MapToOrderDTO(Order order)
        {
            OrderDTO orderDTO = new OrderDTO();
         
            orderDTO.Delivery = order.Delivery;
            orderDTO.Status = order.Status;
            return orderDTO;
        }
        //public static Order mapToOrder(OrderDTO orderDTO, User user)
        //{
        //    Order order = new Order(/*orderDTO.Id, orderDTO.User, orderDTO.Products, orderDTO.TotalPrice,*/ orderDTO.DateOfOrder , orderDTO.Delivery, orderDTO.Status);

        //    return order;
        //}
        public static HomeDelivery MapToHomeDelivery(HomeDeliveryDTO homeDeliveryDTO)
        {
            return new HomeDelivery(homeDeliveryDTO.DateOfDelivery, homeDeliveryDTO.Hour, homeDeliveryDTO.Minutes, homeDeliveryDTO.Address);
        }
        public static PickupDelivery MapToPickupDelivery(PickupDeliveryDTO pickupDeliveryDTO,Location location)
        {
            return new PickupDelivery(pickupDeliveryDTO.DateOfDelivery, pickupDeliveryDTO.Hour,pickupDeliveryDTO.Minutes,location );
        }

    }
}
