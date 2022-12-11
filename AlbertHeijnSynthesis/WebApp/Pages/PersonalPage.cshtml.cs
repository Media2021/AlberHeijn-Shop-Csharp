using BusinessLayer;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppSynthesis.Pages
{
    [Authorize(Policy = "OnlyUserAccess")]
    public class PersonalPageModel : PageModel
    {
        ProductManager productManager = new ProductManager();

        [BindProperty]
        public List<Product >? products { get; set; }
        public void OnGet()
        {
            products = productManager.GetProducts();
        }
    }
}
