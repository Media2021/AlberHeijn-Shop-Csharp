using BusinessLayer;
using DBlayer;
using LogicLayer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using WebAppSynthesis.DTO;

namespace WebAppSynthesis.Pages
{
    public class LoginModel : PageModel
    {
        PeopleManager peopleManager = new PeopleManager();
      
        public User user  { get; set; }
      

        [BindProperty]

        public UserDTO userDTO { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            bool result = peopleManager.LoginUser(userDTO.Username, userDTO.Password);

            if (result)
            {
                user = peopleManager.GetLoggedInUser(userDTO.Username);
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userDTO.Username),
                    new Claim("id", "" + user.Id)
                };




                if (user != null)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Customer"));
                }
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                if (user.UserRole.ToString() == "Customer")
                {

                    return new RedirectToPageResult("/PersonalPage");
                }


            }
            else
            {
                return new RedirectToPageResult("/OnlyAdmin");




            }
            return Page();

        }
    }
}
