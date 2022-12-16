using BusinessLayer;
using EntitiesLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;

namespace WebApp.Pages
{
    public class MyOrdersModel : PageModel
    {
        ProductManager productManager = new ProductManager();
        OrderManager orderManager = new OrderManager(); 
        [BindProperty]
        public List<Product>? products { get; set; }
        [BindProperty]
        public List<Product>? productsInCart { get; set; }
        [BindProperty]

        public List<Delivery> delivery { get; set; }   
        [BindProperty]

        public HomeDelivery homeDelivery { get; set; }
        [BindProperty]

        public PickupDelivery pickupDelivery { get; set;}
        [BindProperty]
        public Order order { get; set; }
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]

        public Product product { get; set; }
        [BindProperty]

        public OrderDTO orderDTO { get; set; }  
        public void OnGet( )
        {
            //List<Product> products = productManager.GetProducts();
            //this.Id = Id;
            //product = products.FindAll(x => x.Id == Id);
            productsInCart = new List<Product>();

            products = productManager.GetProducts();
            string listProduct = HttpContext.Session.GetString("cart");
            string[] myArray = listProduct.Split(',');
            foreach (var item in myArray)
            {
                productsInCart.Add(products.Find(x => x.Id == Convert.ToInt32(item)));
               // products.Count(x => x.Id == 2);
                

                
            }



        }

        public void OnPostdelete() 
        {

        }
        public void OnPostedit()
        { 

        }

    }
}
