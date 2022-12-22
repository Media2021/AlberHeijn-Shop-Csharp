using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer.Interfaces
{
    public interface IPersonDB
    {

        public List<User> ReadUser();
        public void CreateUser(User user);

        //public void UpdateUser(User user);
        //public void DeleteUser(User user);
        //public bool IsUsernameTaken(string username);
        //public bool LoginUser(string username, string password);
        //public void UpdateUserList();
        //public User GetLoggedInUser(string username);



    }
}
