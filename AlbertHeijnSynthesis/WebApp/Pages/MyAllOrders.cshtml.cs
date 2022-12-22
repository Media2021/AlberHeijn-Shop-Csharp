using BusinessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WebApp.DTO;

namespace WebApp.Pages
{
    public class MyAllOrdersModel : PageModel
    {
        PeopleManager peopleManager = new PeopleManager();
        ProductManager productManager = new ProductManager();
        OrderManager orderManager = new OrderManager();

        public int OrderID { get; set; }
        [BindProperty]
        public List<OrderDTO> OrderDTOs { get; set; }
        [BindProperty]

        public List<Order> orders { get; set; }

        public void OnGet( )
        {
            List<Order> filterOrders = orderManager.GetOrders().FindAll(x => x.User.Username == User.Identity.Name);

            orders = new List<Order>();
            foreach (Order order in filterOrders)
            {
                
                orders.Add(order);
            }

        }
    }
}
