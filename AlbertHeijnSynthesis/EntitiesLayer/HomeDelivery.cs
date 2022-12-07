using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class HomeDelivery : Delivery
    {
        private string address;

        public HomeDelivery(int id, DateOnly dateOfDelivery, int hour, string minutes,string address) : base(id, dateOfDelivery, hour, minutes)
        {
            this.address = address;
        }
        public HomeDelivery( DateOnly dateOfDelivery, int hour, string minutes, string address) : base( dateOfDelivery, hour, minutes)
        {
            this.address = address;
        }
        public string Address { get => address; set => address = value; }
    }
}
