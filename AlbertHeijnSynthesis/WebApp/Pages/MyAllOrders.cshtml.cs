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

        [BindProperty]

        

        public List<OrderDTO> OrderDTOs { get; set; }

        public void OnGet()
        {
            List<Order> filterOrders = orderManager.GetOrders().FindAll(x => x.User.Name == User.Identity.Name);

            OrderDTOs = new List<OrderDTO>();
            foreach (Order  order  in filterOrders)
            {
                OrderDTOs.Add(Mapper.mapToOrderDTO(order));
            }

        }
    }
}
