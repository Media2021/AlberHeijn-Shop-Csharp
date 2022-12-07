using BusinessLayer;
using DBlayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppSynthesis.DTO;

namespace WebAppSynthesis.Pages
{
    
    public class SignUpModel : PageModel
    {
        PeopleManager peopleManager = new PeopleManager();
        PersonDB personDB = new PersonDB();
        [BindProperty]

        public UserDTO userDTO { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {


            if (ModelState.IsValid == true)
            {
                User  savedUser = new User(userDTO.Name, userDTO.Surname, userDTO.Username, userDTO.Password);

                peopleManager.AddUser(savedUser);

                ViewData["Message"] = "Hello" + userDTO.Name + " Your account has been created ";
                return new RedirectToPageResult("/Login");
            }
            return RedirectToPage("/Login");

        }
    }
}
