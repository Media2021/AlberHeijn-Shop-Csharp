using BusinessLayer;
using EntitiesLayer;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.CompilerServices;
using WebApp.DTO;

namespace WebApp.Pages
{
    [Authorize(Policy = "OnlyUserAccess")]

    public class MyOrderModel : PageModel
    {
        PeopleManager peopleManager = new PeopleManager();
        ProductManager productManager = new ProductManager();
        OrderManager orderManager = new OrderManager();
        LocationManager locationManager = new LocationManager();
        [BindProperty]
        public List<Location> Locations { get; set; }
        [BindProperty]
        public List<Product> products { get; set; }
        [BindProperty]
        public List<Product> productsInCart { get; set; }
        
        [BindProperty]

        public List<Delivery> delivery { get; set; }
        [BindProperty]

        public List<Order> orders { get; set; }

        [BindProperty]

        public HomeDeliveryDTO homeDeliveryDTO { get; set; }
        [BindProperty]

        public PickupDeliveryDTO pickupDeliveryDTO { get; set; }
        public void OnGet()
        {
          
            Locations = locationManager.GetLocations();
            delivery = orderManager.GetAllDeliveries();
            orders = orderManager.GetOrders();

            productsInCart = new List<Product>();

            products = productManager.GetProducts();
            string listProduct = HttpContext.Session.GetString("cart");
            string[] myArray = listProduct.Split(',');
            foreach (var item in myArray)
            {
                int productId;
                if (int.TryParse(item, out productId))
                {
                    Product product = products.Find(x => x.Id == productId);
                    if (product != null)
                    {
                        productsInCart.Add(product);
                    }
                }
            }




        }
        public IActionResult OnPost( )
        {
            productsInCart = new List<Product>();

            products = productManager.GetProducts();
            string listProduct = HttpContext.Session.GetString("cart");
            string[] myArray = listProduct.Split(',');
            foreach (var item in myArray)
            {
                productsInCart.Add(products.Find(x => x.Id == Convert.ToInt32(item)));





            }

            //if (ModelState.IsValid == true)
            //{

                User user = peopleManager.GetLoggedInUser(User.Identity.Name);
                HomeDelivery homeDelivery = Mapper.MapToHomeDelivery(homeDeliveryDTO);
                Decimal totalPric = 0;
                foreach (var item in productsInCart)
                {
                    totalPric += item.Price;
                }




                orderManager.AddDeliveryType(homeDelivery);
                Order neWorder = new Order(user, productsInCart, totalPric, DateTime.Now, homeDelivery, "new");

                orderManager.AddOrder(neWorder);
            ViewData["Message"] = "Hello" + User.Identity.Name + " Your order successfully has been sent ";

            return Page();
            //}
            //return RedirectToPage("/Index");
        }
        public IActionResult OnPostPickup()
        {
            productsInCart = new List<Product>();

            products = productManager.GetProducts();
            string listProduct = HttpContext.Session.GetString("cart");
            string[] myArray = listProduct.Split(',');
            foreach (var item in myArray)
            {
                productsInCart.Add(products.Find(x => x.Id == Convert.ToInt32(item)));





            }

            //if (ModelState.IsValid == true)
            //{

                User user = peopleManager.GetLoggedInUser(User.Identity.Name);

                //Location location = locationManager.GetLocations().Find(x => x.Address == pickupDeliveryDTO.Location && x => x.Name == pickupDeliveryDTO.Location);
            Location location = locationManager.GetLocations().Find(x => x.Address == pickupDeliveryDTO.Location);

            PickupDelivery pickupDelivery = Mapper.MapToPickupDelivery(pickupDeliveryDTO, location);
                Decimal totalPric = 0;
                foreach (var item in productsInCart)
                {
                    totalPric += item.Price;
                }




                orderManager.AddDeliveryType(pickupDelivery);
                Order neWorder = new Order(user, productsInCart, totalPric, DateTime.Now, pickupDelivery, "new");

                orderManager.AddOrderPickup(neWorder);
                ViewData["Message"] = "Hello " +User.Identity.Name+ " Your order successfully has been sent ";
                return Page();
            }
        //    return RedirectToPage("/Index");
        //}
        public IActionResult OnPostDeleteProduct( )
        {
            productsInCart = new List<Product>();
            
            products = productManager.GetProducts();
            string listProduct = HttpContext.Session.GetString("cart");
            string[] myArray = listProduct.Split(',');
            foreach (var item in myArray)
            {

                productsInCart.Remove(products.Find(x => x.Id == Convert.ToInt32(item)));

            }
            return Page();  
        }

    }
}
