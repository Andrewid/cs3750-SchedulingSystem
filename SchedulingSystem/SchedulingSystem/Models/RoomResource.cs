using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace SchedulingSystem.Models
{
    public class RoomResource
    {
        public int RoomResourceID { get; set; }
        public int ResourceID { get; set; }
        public int RoomID { get; set; }
        /// <summary>
        /// Using byte because do we really have more than 256?
        /// </summary>
        public byte Quantity { get; set; }

        public Room Room { get; set; }
    }
}