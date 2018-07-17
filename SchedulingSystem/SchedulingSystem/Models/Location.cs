using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulingSystem.Models
{
    public class Location
    {
        [Key] //obviously, but just for fun
        public byte    LocationID             { get; set; }
        [Display(Name = "Name")]
        [StringLength(50)] public string LocationName           { get; set; }
        [Display(Name = "Address")]
        [StringLength(50)] public string LocationStreetAddress  { get; set; }
        [Display(Name = "City")] 
        [StringLength(30)] public string LocationCity           { get; set; }
        [Display(Name = "State")]
        [StringLength( 2)] public string LocationState          { get; set; }
        [Display(Name = "Zip code")]
        [DataType(DataType.PostalCode)]
        [StringLength(11)] public string LocationZipCode        { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public InstructorPreference InstructorPreference { get; set; }
    }
}
