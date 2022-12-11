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

        public OrderDTO() { }   

        public int Id { get => id; }
        public User User { get => user; }
        public List<Product> Products { get => products; }
        public decimal TotalPrice { get => totalPrice; }
        public DateTime DateOfOrder { get => dateOfOrder; }
        public Delivery Delivery { get => delivery; }
    }
}
