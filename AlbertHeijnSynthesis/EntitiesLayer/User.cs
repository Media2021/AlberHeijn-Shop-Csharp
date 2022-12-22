using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public  class User
    {
        private int id;
        [Required(ErrorMessage = " please enter your name")]
        [MinLength(2, ErrorMessage = "name should be at least 2 letters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters")]
        private string name;
        [Required(ErrorMessage = " please enter your surname")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters")]
        private string surname;
        [Required(ErrorMessage = " please enter a username")]
        [MinLength(3, ErrorMessage = "username should be at least 3 letters")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username can only contain letters and numbers")]
        private string username;
        //[Required(ErrorMessage = " please enter a password")]
        //[MinLength(2, ErrorMessage = "password can't be shorte  than 2 characters")]

        //[MaxLength(10, ErrorMessage = "password can't be longer than 10 characters")]
        private string password;
        private UserRole userRole;
        private string salt = "";

        public User(int id, string name, string surname, string username, string password, UserRole userRole, string salt)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.userRole = userRole;
            this.salt = salt;
        }
        public User( string name, string surname, string username, string password, UserRole userRole, string salt )
        {

            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.userRole = userRole;
            this.salt = salt;
        }

        public User()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public UserRole UserRole { get => userRole; set => userRole= value; } 
        public string Salt { get => salt; set => salt = value; }
        public bool Login(string password)
        {
            if (this.Password == password)
            {
                return true;
            }
            return false;
        }

     
    }
}
