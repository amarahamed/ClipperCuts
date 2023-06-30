using System.ComponentModel.DataAnnotations;

namespace ClipperCuts.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime? BookingDate { get; set; }

        [Display(Name = "Total Fee")]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(1, 9999999)]
        public double? TotalFee { get; set; }

        [Display(Name = "Total Duration")]
        [Required(AllowEmptyStrings = false)]
        public int? TotalDuration { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false)]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false)]
        public string? LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string? Phone { get; set; }

        public string Note { get; set; }

        // Foreign Keys  

        [Required]
        public string UserID { get; set; } 

        // Child Reference 
        public List<BookingService>? BookingServices { get; set; } 

    }
}
