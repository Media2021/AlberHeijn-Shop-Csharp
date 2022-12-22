using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBlayer.Interfaces
{
    public  interface ILocationDB
    {
        public List<Location> GetAllLocations();
        public List<Location> ReadLocations();
        public void CreateLocation(Location location);
        public void DeleteLocation(Location location);
        public void UpdateLocation(Location location);





    }
}
