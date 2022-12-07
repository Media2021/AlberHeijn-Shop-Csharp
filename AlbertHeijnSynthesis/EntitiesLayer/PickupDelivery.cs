using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class PickupDelivery : Delivery
    {
        private string pickupLocation;
        public PickupDelivery(int id, DateOnly dateOfDelivery, int hour, string minutes, string pickupLocation) : base(id, dateOfDelivery, hour, minutes)
        {
            this.pickupLocation = pickupLocation;
        }
        public PickupDelivery( DateOnly dateOfDelivery, int hour, string minutes, string pickupLocation) : base( dateOfDelivery, hour, minutes)
        {
            this.pickupLocation = pickupLocation;
        }
        public string PickupLocation { get => pickupLocation; set => pickupLocation = value; }
    }
}
