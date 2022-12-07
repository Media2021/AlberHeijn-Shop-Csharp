using DBlayer;
using LogicLayer;

namespace BusinessLayer
{
    public class PeopleManager
    {
        PersonDB personDB = new PersonDB();
        List<Employee> employees = new List<Employee>();
        List<User> users = new List<User>();

        public PeopleManager()
        {
            employees.Clear();
            users.Clear();
            UpdateEMPList();
            UpdateUserList();



        }

        public List<Employee> ReadEMP()
        {
            return employees;
        }

        public void UpdateEMPList()
        {
            employees.Clear();
            List<Employee> AllEMP = personDB.ReadEMP();

            foreach (var person in AllEMP)
            {
                employees.Add(person);
            }
        }


        public void AddEMP(Employee person)
        {
            employees.Add(person);
            personDB.CreateEMP(person);
        }
     
        public void DeleteEMP(Employee person)
        {
            employees.Remove(person);
            personDB.CreateEMP(person);
        }
        public bool LoginEMP(string username, string password)
        {
            bool isTrue = employees.Exists(x => x.Username == username);

            if (isTrue)
            {
                Employee loggedEMP = employees.Find(x => x.Username == username);


                return loggedEMP.Login(password);

                


            }
            
            return false;

        }
        public Employee GetLoggedInEMP(string password)
        {
            Employee loggedEMP = employees.Find(x => x.Password == password);
            return loggedEMP;
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