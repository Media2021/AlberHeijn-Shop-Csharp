using DBlayer.Interfaces;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer
{
    public class MockUser : IUser
    {
        

        public bool Login(string password)
        {
           return true; 
        }


       

    }
}
