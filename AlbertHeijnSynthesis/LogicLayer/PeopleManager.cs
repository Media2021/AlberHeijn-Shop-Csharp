using DBlayer;
using LogicLayer;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class PeopleManager
    {
        PersonDB personDB = new PersonDB();
       
        List<User> users = new List<User>();

        public PeopleManager()
        {
           
            users.Clear();
        
            UpdateUserList();



        }


        //private static string HashPassword()
        //{

        //    using var sha = SHA256.Create();
        //    var asByte = Encoding.Default.GetBytes(password);
        //    var hashed = sha.ComputeHash(asByte);
        //    return Convert.ToBase64String(hashed);
        //}
        //private static int GenerateSalt(string password)
        //{

        //    Random random = new();
        //    int salt = random.Next(100000, 1000000);
        //    return salt;
        //}


        public bool LoginUser(string username, string password)
        {
            bool isTrue = users.Exists(x => x.Username == username);

            if (isTrue)
            {
               User loggedUser = users.Find(x => x.Username == username);

                string HashedPassword = Security.HashPassword(password, loggedUser.Salt);
                bool v = loggedUser.Password == HashedPassword;
                return loggedUser.Login(password);




            }

            return false;

        }
        public User GetLoggedInUser(string username)
        {
            User  loggedUser = users.Find(x => x.Username== username);

            return loggedUser;
        }

     
        public void AddUser(User user )
        {
            string salt = Security.GenerateSalt();
            string HashedPassword = Security.HashPassword(user.Password,salt);
            
            user.Password= HashedPassword;
            user.Salt= salt;    
            users.Add(user);
            personDB.CreateUser(user);
        }
        public void DeleteUser(User user)
        {
            users.Remove(user);
            personDB.DeleteUser(user);
        }

    
        public List<User> ReadUser()
        {
            return users;
        }
        public void UpdateUserList()
        {
            users.Clear();
            List<User> AllUsers = personDB.ReadUser();

            foreach (var person in AllUsers)
            {
                users.Add(person);
            }
        }
        public void UpdateUser(User user )
        {
            personDB.UpdateUser(user);


        }


    }
}