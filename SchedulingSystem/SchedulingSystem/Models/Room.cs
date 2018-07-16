using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Pages.Models
{
    public class Room
    {
        [Key] public int RoomID { get; set; }
        [Required]
        public Location LocationID { get; set; }
        [Display(Name = "Number")]
        [StringLength(30)] public string RoomNumber { get; set; }
        [Display(Name = "Description")]
        [StringLength(50)] public string RoomDescription { get; set; }
        [Display(Name = "Capacity")]
        public byte RoomCapacity { get; set; }
        public ICollection<RoomResource> RoomResource { get; set; }

    }
}
