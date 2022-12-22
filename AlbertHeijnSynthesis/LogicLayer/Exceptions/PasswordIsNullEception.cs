using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class PasswordIsNullEception : Exception
    {
        public PasswordIsNullEception() : base("password can not be empty")
        {


        }
    }
}
