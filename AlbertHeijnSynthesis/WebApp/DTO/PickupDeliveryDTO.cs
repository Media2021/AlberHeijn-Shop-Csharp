using System.ComponentModel.DataAnnotations;

namespace WebApp.DTO
{
    public class PickupDeliveryDTO
    {
        private readonly int  _id;
        private DateTime dateOfDelivery = DateTime.Now;
        private int hour;
        private string minutes;
        private string location;
        public PickupDeliveryDTO() { }

       
        public int Id { get { return _id; } }
        public DateTime DateOfDelivery { get => dateOfDelivery; set => dateOfDelivery = value; }
        [Required(ErrorMessage = " please select pick up hour ")]

        public int Hour { get => hour; set => hour = value; }
        [Required(ErrorMessage = " please select pick up exact time  ")]

        public string Minutes { get => minutes; set => minutes = value; }
        [Required(ErrorMessage = " please select pick up preferred location ")]

        public string Location { get => location; set => location = value; }
    }
}
