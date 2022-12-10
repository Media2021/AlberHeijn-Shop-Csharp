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
        PersonDB personDB = new PersonDB();
        public User user  { get; set; }
        public Employee employee{ get; set; }

        [BindProperty]

        public UserDTO userDTO { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            //    bool result = peopleManager.LoginEMP(userDTO.Username, userDTO.Password);

            //    if (result )
            //    {
            //        employee = peopleManager.GetLoggedInEMP(userDTO.Password);
            //        List<Claim> claims = new List<Claim>();
            //        claims.Add(new Claim(ClaimTypes.Actor, userDTO.Password));
            //        claims.Add(new Claim("id", "" + employee.Id));




            //        if (employee is Employee)
            //        {
            //            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            //        }
            //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            //        HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
            //        if (employee.Role == "Admin")
            //        {

            //            return new RedirectToPageResult("/OnlyAdmin");
            //        }


            //    }
            //    else
            //    {



            //        return new RedirectToPageResult($"/PersonalPage");

            //    }
            return Page();

        }
    }
}
