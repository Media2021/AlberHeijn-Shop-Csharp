using EntitiesLayer;
using LogicLayer;

namespace WebApp.DTO
{
    public class OrderDTO
    {
        private int id;
        private User user;
        private List<Product> products;
        private decimal totalPrice;
        private DateTime dateOfOrder;
        private Delivery delivery;
        private string status;

        public OrderDTO() { }   

        public int Id { get => id; set => id = value; }
        public User User { get => user; set => user = value; }
        public List<Product> Products { get => products; set => products = value ; }
        public decimal TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime DateOfOrder { get => dateOfOrder; set => dateOfOrder = value; }
        public Delivery Delivery { get => delivery; set => delivery = value; }

        public string Status { get => status; set => status = value; } 
    }
}
