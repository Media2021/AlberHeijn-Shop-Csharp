using DBlayer;
using DBlayer.Interfaces;
using LogicLayer;
using LogicLayer.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class PeopleManager
    {

        private IPersonDB IpersonDB;
       private  List<User> users = new List<User>();


      

        public PeopleManager():this(new PersonDB())
        {

        }

        ///another way to do so that so I just commented it ./
        //public PeopleManager() 
        //{

        //this.IpersonDB = new PersonDB();
        //users.Clear();

        //UpdateUserList();
        //}
        public PeopleManager(IPersonDB IpersonDB)
        {
            this.IpersonDB = IpersonDB;
            users.Clear();

            UpdateUserList();
        }

        public bool LoginUser(string username, string password)
        {
            bool isTrue = users.Exists(x => x.Username == username);

            if (isTrue)
            {
                User loggedUser = users.Find(x => x.Username == username);

                string HashedPassword = Security.HashPassword(password, loggedUser.Salt);
                bool v = loggedUser.Password == HashedPassword;

                return loggedUser.Login(HashedPassword);




            }

            return false;

        }
        public User GetLoggedInUser(string username)
        {
            User loggedUser = users.Find(x => x.Username == username);

            return loggedUser;
        }
        public bool IsUsernameTaken(string username)
        {
            if (users.Exists(x => x.Username == username))
            {
                throw new UserNameIsExistException();
            }
            else
                return false;
        }


        public void AddUser(User user)
        {
            if (users.Exists(x => x.Username == user.Username))
            {
                throw new UserNameIsExistException();

            }
            string salt = Security.GenerateSalt();
            string HashedPassword = Security.HashPassword(user.Password, salt);

            user.Password = HashedPassword;
            user.Salt = salt;
         
              
                    IpersonDB.CreateUser(user);
                    users.Add(user);
            
        }



        public List<User> ReadUser()
        {
            return users;
        }
        public void  UpdateUserList()
        {
            users.Clear();
            List<User> AllUsers = IpersonDB.ReadUser();

            foreach (var person in AllUsers)
            {
                users.Add(person);
            }
            
        }

    }
}