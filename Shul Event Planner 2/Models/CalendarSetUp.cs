using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shul_Event_Planner_2.Models
{
    public class CalendarSetUp
    {
        [Key]
        public int  Id { get; set; }
        public string NameofSchedule { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public double GeolocationCoordinates { get; set; }
    }
}
