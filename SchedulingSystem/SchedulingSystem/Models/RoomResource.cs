using System.Security.AccessControl;

namespace SchedulingSystem.Pages.Models
{
    public class RoomResource
    {
        public int RoomResourceID { get; set; }
        public int ResourceID { get; set; }
        public int RoomID { get; set; }
        public int Quantity { get; set; }
    }
}