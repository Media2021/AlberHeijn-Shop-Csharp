using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public  class Location
    {
        private int id;
        private string name;
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

        public int getId() { return id; }
        public string getName() { return name; }
        public string getAddress() { return address; }
    }
}
