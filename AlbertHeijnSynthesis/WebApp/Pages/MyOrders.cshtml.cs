using BusinessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;

namespace WebApp.Pages
{
    public class MyOrdersModel : PageModel
    {
        ProductManager productManager = new ProductManager();

        [BindProperty]
        public List<Product>? products { get; set; }
        [BindProperty]
        public Order order { get; set; }
        [BindProperty]
        public int Id { get; set; }    

        public Product product { get; set; }
        [BindProperty]

        public OrderDTO orderDTO { get; set; }  
        public void OnGet(int Id )
        {
            List<Product> products = productManager.GetProducts();
            this.Id = Id;
            product = products.Find(x => x.Id == Id);
        }
    }
}
