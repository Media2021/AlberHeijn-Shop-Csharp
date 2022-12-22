using DBlayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
   public  class LocationManager
    {
          LocationDB locationDB = new LocationDB();
        List<Location> locations = new List<Location>();
        public LocationManager() 
        {

            UpdateLocationList();


        }

        public List<Location> GetLocations()
        {
            return locations;
        }
        public void UpdateLocationList()
        {
            locations.Clear();
            locations.AddRange(locationDB.ReadLocations()); 

        }
        public List<Location> ReadLocations()
        {
            locations.AddRange(locationDB.ReadLocations());
            return locations;
        }
        public void AddLocation(Location location)
        {
            locations.Add(location);
            locationDB.CreateLocation(location);


        }
        public void DeleteLocation(Location location)
        {
            locations.Remove(location);
            locationDB.DeleteLocation(location);    


        }
        public void UpdateLocation(Location location)
        {
            locationDB.UpdateLocation(location);    


        }
    }
}
