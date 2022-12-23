using DBlayer;
using DBlayer.Interfaces;
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
        private ILocationDB IlocationDB;
         
        List<Location> locations = new List<Location>();
        public LocationManager(ILocationDB IlocationDB1) 
        {
            this.IlocationDB = IlocationDB1;

            UpdateLocationList();


        }
        public LocationManager() : this(new LocationDB())
        {

        }
        public List<Location> GetLocations()
        {
            return locations;
        }
        public void UpdateLocationList()
        {
            locations.Clear();
            locations.AddRange(IlocationDB.ReadLocations()); 

        }
        public List<Location> ReadLocations()
        {
            locations.AddRange(IlocationDB.ReadLocations());
            return locations;
        }
        public void AddLocation(Location location)
        {
            locations.Add(location);
            IlocationDB.CreateLocation(location);


        }
        public void DeleteLocation(Location location)
        {
            locations.Remove(location);
            IlocationDB.DeleteLocation(location);    


        }
        public void UpdateLocation(Location location)
        {
            IlocationDB.UpdateLocation(location);    


        }
    }
}
