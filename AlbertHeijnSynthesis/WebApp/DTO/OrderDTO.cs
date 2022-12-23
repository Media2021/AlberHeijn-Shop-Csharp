using EntitiesLayer;
using LogicLayer;

namespace WebApp.DTO
{
    public class OrderDTO
    {
      
        private List<Product> products;
        private decimal totalPrice;
        private DateTime dateOfOrder;
        private Delivery delivery;
        private string status;

        public OrderDTO() { }

     
        public List<Product> Products { get => products; set => products = value; }
        public decimal TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime DateOfOrder { get => dateOfOrder; set => dateOfOrder = value; }
        public Delivery Delivery { get => delivery; set => delivery = value; }

        public string Status { get => status; set => status = value; } 
    }
}
