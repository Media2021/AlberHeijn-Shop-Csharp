using BusinessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace WebAppSynthesis.Pages
{
    [Authorize(Policy = "OnlyUserAccess")]
    public class PersonalPageModel : PageModel
    {
        ProductManager productManager = new ProductManager();

        [BindProperty]
        public List<Product >? products { get; set; }
        [BindProperty]

       public  List<Product> cartProducts  { get; set; }
    public void OnGet()
        {
            products = productManager.GetProducts().ToList();
            cartProducts = new List<Product>();
        }
         
        public void  OnPost(int idProduct) 
        {
            // cartProducts.Add(products.Find(x=>x.Id == idProduct));
            //string name =  User.FindFirst("cart").Value;
           string listOfProducts =  HttpContext.Session.GetString("cart");
            if (listOfProducts=="")
            {
                listOfProducts += idProduct;
                HttpContext.Session.SetString("cart", listOfProducts);
            }
            else
            {

                listOfProducts += "," + idProduct;
                HttpContext.Session.SetString("cart", listOfProducts);
            }

            OnGet();

        }
        
        public IActionResult OnPostOrders()
        {
            return RedirectToPage("/MyOrders");
        }
        //public IActionResult Search(string searchTerm, string searchTerm1 )
        //{


            //var products = productManager.GetProducts().ToList();

            //var ProductFilterName = new List<Product>();



            //if (searchTerm != "")
            //    {
            //        foreach (var  item in products)
            //        {
            //            if (item.Item.Contains(searchTerm)
            //            )
            //            {
            //            ProductFilterName.Add(item);
            //            }
            //        }

            //    }
            //    else
            //    {
            //    ProductFilterName = products;
            //    }
            //    var list2 = new List<Product>();

            //    if (searchTerm1 != "")
            //    {
            //        foreach (var item in ProductFilterName)
            //        {
            //            if (item.Category.Name.Contains(searchTerm1))
            //            {
            //                list2.Add(item);

            //            }
            //        }

            //    }
            //    else
            //    {
            //        list2 = ProductFilterName;
            //    }


            //return list2;

        //}
    }
}
