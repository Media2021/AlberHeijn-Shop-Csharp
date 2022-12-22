using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
   public  class DecimalPriceException : Exception
    {
        public DecimalPriceException() : base("The input price should be decimal")
        {


        }
    }
}
