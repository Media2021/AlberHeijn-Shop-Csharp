using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public  class UserNameIsExistException : Exception
    {
        public UserNameIsExistException() :base("the username is already taken")
            {


            }
    }
}
