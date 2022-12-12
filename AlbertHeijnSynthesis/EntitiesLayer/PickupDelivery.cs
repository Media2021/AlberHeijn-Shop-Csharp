using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class PickupDelivery : Delivery
    {
        Location location;
        public PickupDelivery(int id, DateTime dateOfDelivery, int hour, string minutes, Location location) : base(id, dateOfDelivery, hour, minutes)
        {
            this.location = location;
        }
        public PickupDelivery(DateTime dateOfDelivery, int hour, string minutes, Location location) : base( dateOfDelivery, hour, minutes)
        {
            this.location = location;
        }
        public Location Location { get => location; set => location = value; }
    }
}
