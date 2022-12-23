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
     
        OrderManager orderManager = new OrderManager();

        
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
