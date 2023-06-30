using System.ComponentModel.DataAnnotations;

namespace ClipperCuts.Models
{
    // Selected Services - Already Paid 

    public class BookingService
    {
        public int BookingServiceId { get; set; }

        [Display(Name = "Fee")]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double BookingServiceFee { get; set; }

        [Display(Name = "Duration")]
        [Required(AllowEmptyStrings = false)]
        public int BookingServiceDuration { get; set; } 
        
        // Foreign Keys
        // ServiceID, BookingID
        public int ServiceID { get; set; }

        public int? BookingID { get; set; }

        public Service Service { get; set; } 

        public Booking? Booking { get; set; }
    }
}
