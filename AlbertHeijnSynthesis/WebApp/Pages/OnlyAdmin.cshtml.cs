using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppSynthesis.Pages
{
    [Authorize(Policy = "OnlyAdminAccess")]

    public class OnlyAdminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
