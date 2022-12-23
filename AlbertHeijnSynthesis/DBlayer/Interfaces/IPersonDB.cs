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

     



    }
}
