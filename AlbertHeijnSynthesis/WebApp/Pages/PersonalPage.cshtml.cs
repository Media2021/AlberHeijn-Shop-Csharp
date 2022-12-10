using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppSynthesis.Pages
{
    [Authorize(Policy = "OnlyUserAccess")]
    public class PersonalPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
