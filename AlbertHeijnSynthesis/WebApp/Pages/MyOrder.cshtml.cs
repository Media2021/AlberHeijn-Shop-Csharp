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
        public void  OnPostDelivery( )
        {
            if (!string.IsNullOrEmpty(homeDeliveryDTO.Hour.ToString()) & !string.IsNullOrEmpty(homeDeliveryDTO.Minutes) & !string.IsNullOrEmpty(homeDeliveryDTO.Address))
            {



                productsInCart = new List<Product>();

                products = productManager.GetProducts();
                string listProduct = HttpContext.Session.GetString("cart");
                string[] myArray = listProduct.Split(',');
                foreach (var item in myArray)
                {
                    productsInCart.Add(products.Find(x => x.Id == Convert.ToInt32(item)));


                }


                User user = peopleManager.GetLoggedInUser(User.Identity.Name);
                HomeDelivery homeDelivery = Mapper.MapToHomeDelivery(homeDeliveryDTO);

                Order neWorder = new Order(user, DateTime.Now, homeDelivery);
                foreach (var item in productsInCart)
                {
                    neWorder.AddProduct(item);
                }
                orderManager.AddOrder(neWorder);







                ViewData["Message"] = "Hello " + User.Identity.Name + " Your order successfully has been sent ";

               
            }
           
           
        }
        public void  OnPostPickup()
        {
            if (!string.IsNullOrEmpty(pickupDeliveryDTO.Hour.ToString()) & !string.IsNullOrEmpty(pickupDeliveryDTO.Minutes) & !string.IsNullOrEmpty(pickupDeliveryDTO.Location))
            {

                productsInCart = new List<Product>();

                products = productManager.GetProducts();
                string listProduct = HttpContext.Session.GetString("cart");
                string[] myArray = listProduct.Split(',');
                foreach (var item in myArray)
                {
                    productsInCart.Add(products.Find(x => x.Id == Convert.ToInt32(item)));





                }


                User user = peopleManager.GetLoggedInUser(User.Identity.Name);


                Location location = locationManager.GetLocations().Find(x => x.Address == pickupDeliveryDTO.Location);



                PickupDelivery pickupDelivery = Mapper.MapToPickupDelivery(pickupDeliveryDTO, location);

                Order neWorder = new Order(user, DateTime.Now, pickupDelivery);
                foreach (var item in productsInCart)
                {
                    neWorder.AddProduct(item);
                }
                orderManager.AddOrder(neWorder);




            

                ViewData["Message"] = "Hello " + User.Identity.Name + " Your order successfully has been sent ";
               
            }
         


           

        }
        public void OnPostDeleteProduct( int minus1)
        {
            productsInCart = new List<Product>();

            string listProduct = HttpContext.Session.GetString("cart");
            List<string> myArray = listProduct.Split(',').ToList();
            myArray.Remove(minus1.ToString());
            string a = "";
            foreach (var item in myArray)
            {
                if (a == "")
                {
                    a = item;
                }
                else
                {

                    a += "," + item;
                }

            }
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("cart", a);

            OnGet();

        }

    }
}
