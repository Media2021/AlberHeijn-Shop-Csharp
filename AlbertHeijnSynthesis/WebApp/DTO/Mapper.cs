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
        public static HomeDelivery MapToHomeDelivery(HomeDeliveryDTO homeDeliveryDTO)
        {
            return new HomeDelivery(DateTime.Now.AddDays(3), homeDeliveryDTO.Hour, homeDeliveryDTO.Minutes, homeDeliveryDTO.Address);
        }
        public static PickupDelivery MapToPickupDelivery(PickupDeliveryDTO pickupDeliveryDTO,Location location)
        {
            return new PickupDelivery(DateTime.Now.AddDays(2), pickupDeliveryDTO.Hour,pickupDeliveryDTO.Minutes,location );
        }

    }
}
