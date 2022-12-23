using BusinessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Claims;

namespace WebAppSynthesis.Pages
{
    [Authorize(Policy = "OnlyUserAccess")]
    public class PersonalPageModel : PageModel
    {
        ProductManager productManager = new ProductManager();

        [BindProperty]
        public List<Product > products { get; set; }
     
        [BindProperty]

        public List<Product> cartProducts  { get; set; }
        public void OnGet()
        {
            //products = productManager.GetProducts().ToList();

            cartProducts = new List<Product>();
            if (products == null)
            {

                products = productManager.GetProducts().ToList();

            }
          

        }
         
        public void  OnPost(int idProduct) 
        {
              string listOfProducts = HttpContext.Session.GetString("cart");
                if (listOfProducts == "")
                {
                    listOfProducts += idProduct;
                    HttpContext.Session.SetString("cart", listOfProducts);
                }
                else
                {

                    listOfProducts += "," + idProduct;
                    HttpContext.Session.SetString("cart", listOfProducts);
                }
                products = productManager.GetProducts().ToList();
                OnGet();
           
         

        }
        public void OnPostMinus(int minus1)
        {
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

                    a += ","+item;
                }

            }
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("cart", a);

            


            OnGet();

        }
        public void  OnPostFilter(string searchTerm)
        {
            products = productManager.filterProduct(searchTerm).ToList();

            OnGet();
        }
        public string getsubs(List<Category> list)
        {
            return string.Join(Environment.NewLine, list
                );
        }
    }

}
