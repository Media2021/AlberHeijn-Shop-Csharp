﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public  class Location
    {
        private int id;
        private string name;

        [Required(ErrorMessage = " please enter your postcode , street name and house number ")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "your address can only contain letters and numbers")]
        private string address;

     

        public Location(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public Location( string name, string address)
        {
          
            this.name = name;
            this.address = address;
        }
        public int Id { get => id;  }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
      
    }
}
