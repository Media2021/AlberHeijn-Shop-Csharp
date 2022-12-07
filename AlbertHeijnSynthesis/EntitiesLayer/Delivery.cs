using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract  class Delivery
    {
        private int id;
        private DateOnly dateOfDelivery;
        private int hour;
        private string minutes;

      

        public  Delivery(int id, DateOnly dateOfDelivery, int hour, string minutes)
        {
            this.id = id;
            this.dateOfDelivery = dateOfDelivery;
            this.hour = hour;
            this.minutes = minutes;
        }
        public Delivery( DateOnly dateOfDelivery, int hour, string minutes)
        {
            
            this.dateOfDelivery = dateOfDelivery;
            this.hour = hour;
            this.minutes = minutes;
        } 
        public int Id { get => id; }
        public DateOnly DateOfDelivery { get => dateOfDelivery;  }
        public int Hour { get => hour; /*set => hour = value; */}
        public string Minutes { get => minutes; /*set => minutes = value;*/ }
      
    }
}
