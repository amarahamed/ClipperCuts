

using System.ComponentModel.DataAnnotations;

namespace ClipperCuts.Models
{
    // Temp Selected Services - Not Paid 
    public class ServiceCart
    {
        public int ServiceCartID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name= "Fee")]
        [Range(1, 9999999)]
        public string ServiceFee { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Duration")]
        public string ServiceDuration { get; set; }

        // Foreign Keys  

        // ServiceID, UserID 
        public int ServiceID { get; set; }

        public string UserID { get; set; }

        // represents par obj - Service 
        public Service Service { get; set; }

    }
}
