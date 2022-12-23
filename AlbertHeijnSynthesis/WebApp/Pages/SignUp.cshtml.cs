using BusinessLayer;
using DBlayer;
using EntitiesLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppSynthesis.DTO;

namespace WebAppSynthesis.Pages
{
    
    public class SignUpModel : PageModel
    {
        PeopleManager peopleManager = new PeopleManager();
        
        [BindProperty]

        public UserDTO userDTO { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
           


            if (ModelState.IsValid == true)
            {
                User  savedUser = new User(userDTO.Name, userDTO.Surname, userDTO.Username, userDTO.Password,UserRole.Customer,"");
                peopleManager.AddUser(savedUser);
                
                    ViewData["Message"] = "Hello "   +   userDTO.Username   +  " Your account has been created ";


                }
                else
                {
                ViewData["Message"] = "Hello "   +   userDTO.Name   +  " username is already taken try again ";

                    return Page();
                }
               

               
                return new RedirectToPageResult("/Login");
            
            

        }
    }
}
