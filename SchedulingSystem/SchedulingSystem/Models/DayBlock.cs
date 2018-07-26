using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class DayBlock
    {
        public int  DayBlockID  { get; set; }
        [ScaffoldColumn(false)] public bool	Sunday  	{ get; set; }
        [ScaffoldColumn(false)] public bool	Monday   	{ get; set; }
        [ScaffoldColumn(false)] public bool	Tuesday	    { get; set; }
        [ScaffoldColumn(false)] public bool	Wednesday	{ get; set; }
        [ScaffoldColumn(false)] public bool	Thursday	{ get; set; }
        [ScaffoldColumn(false)] public bool	Friday	    { get; set; }
        [ScaffoldColumn(false)] public bool	Saturday	{ get; set; }
        [ScaffoldColumn(false)] public bool	Online  	{ get; set; }
        /// <summary>
        /// This is an 8 bit int for Dewey's fancy bitwise functionality
        /// To be or not to be implemented
        /// Should be null-able.
        /// </summary>
        public byte? DaysCode   { get; set; } 

        public ICollection<InstructorPreference> InstructorPreferences { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}
