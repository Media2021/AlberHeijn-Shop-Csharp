using System.ComponentModel.DataAnnotations;

namespace WebAppSynthesis.DTO
{
    public class UserDTO
    {
        string name;
        string surname;
        string userame;
        string password;


        public UserDTO()
        {
        }
        [Required(ErrorMessage =" please enter your name")]
        [MinLength(2,ErrorMessage ="name should be at least 2 letters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters")]
        public string Name { get => name; set => name = value; }
        [Required(ErrorMessage =" please enter your surname")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters")]
        public string Surname { get => surname; set => surname = value; }
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
