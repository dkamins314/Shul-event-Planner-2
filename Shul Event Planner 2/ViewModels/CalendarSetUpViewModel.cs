using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shul_Event_Planner_2.ViewModels
{
    public class CalendarSetUpViewModel
    {
        [Key]
        [Required(ErrorMessage= "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage= "City is required")]
        public string City { get; set; }

        [Required (ErrorMessage = "Zip Code or Postal Code is required"),Display(Name = "Zip Code or Postal Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage= "Country is required")]
        public string Country { get; set; }

        [Display(Name = "Location Coordinates")]
        public double GeolocationCoordinates { get; set; }

        public CalendarSetUpViewModel() { }


    }
}
