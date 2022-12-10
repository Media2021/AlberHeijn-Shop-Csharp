using DBlayer;
using LogicLayer;

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





        public bool LoginUser(string username, string password)
        {
            bool isTrue = users.Exists(x => x.Username == username);

            if (isTrue)
            {
               User LoggedUser = users.Find(x => x.Username == username);


                return LoggedUser.Login(password);




            }

            return false;

        }
        public User GetLoggedInUser(string password)
        {
            User  loggedUser = users.Find(x => x.Password == password);
            return loggedUser;
        }

        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user )
        {
            users.Add(user);
            personDB.CreateUser(user);
        }
        public void DeleteUser(User user)
        {
            users.Remove(user);
            personDB.DeleteUser(user);
        }

        //public User GetLoggedInUser(string password)
        //{
        //    User loggedUser = users.Find(x => x.Password == password);
        //    return loggedUser;
        //}

        public void UpdateUserList()
        {
            users.Clear();
            List<User> AllUsers = personDB.ReadUser();

            foreach (var person in AllUsers)
            {
                users.Add(person);
            }
        }

        public List<User> ReadUser()
        {
            return users;
        }
    }
}