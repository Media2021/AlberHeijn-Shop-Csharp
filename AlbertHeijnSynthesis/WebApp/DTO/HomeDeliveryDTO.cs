using System.ComponentModel.DataAnnotations;

namespace WebApp.DTO
{
    public class HomeDeliveryDTO
    {
       
        private DateTime dateOfDelivery= DateTime.Now.AddDays(3);
        private int hour;
        private string minutes;
        private string address;
        public HomeDeliveryDTO() { }    
        
      
        public DateTime DateOfDelivery { get => dateOfDelivery; set => dateOfDelivery = value; }
        [Required(ErrorMessage = " please select a preferred hour  when you are at home ")]

        public int Hour { get => hour; set => hour = value; }
        [Required(ErrorMessage = " please select an exact time   when you are at home ")]

        public string Minutes { get => minutes; set => minutes = value; }
        [Required(ErrorMessage = " please enter your postcode , street name and house number ")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "your address can only contain letters and numbers")]
        public string Address { get => address; set => address = value; }
    }
}
