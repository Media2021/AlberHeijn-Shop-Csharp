using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public  class User
    {
        private int id;
        private string name;
        private string surname;
        private string username;
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

        public virtual string Info()
        {
            return $"My id is {id} ,My name is  {name} ";
        }
    }
}
