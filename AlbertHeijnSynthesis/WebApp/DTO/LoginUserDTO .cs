using System.ComponentModel.DataAnnotations;

namespace WebAppSynthesis.DTO
{
    public class LoginUserDTO
    {
       
        string userame;
        string password;


        public LoginUserDTO()

        {
        }
     
      
        [Required(ErrorMessage = " please enter a username")]
        [MinLength(3, ErrorMessage = "username should be at least 3 letters")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username can only contain letters and numbers")]
        public string Username { get => userame; set => userame = value; }
        [Required(ErrorMessage = " please enter a password")]
        [MinLength(2, ErrorMessage = "password can't be shorte  than 2 characters")]

        [MaxLength(10, ErrorMessage = "password can't be longer than 10 characters")]
        public string Password { get => password; set => password = value; }
      
    }
}
