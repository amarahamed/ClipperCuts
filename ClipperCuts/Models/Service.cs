using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ClipperCuts.Models
{
    //  Services 
    public class Service
    {
        public int ServiceId { get; set; }

        // choose from a list of services 
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Service")]
        public string? ServiceName { get; set; }

        // will be automatically selected for the desired service  
        public int ServiceDuration { get; set; }

        // will be selected automatically for the desired service 
        public double ServiceFee { get; set; }

        // Child References 
        // BookingService, ServiceCart
        public List<BookingService> BookingServices { get; set; } 

        public List<ServiceCart> ServiceCarts { get; set; } 
    }
}
