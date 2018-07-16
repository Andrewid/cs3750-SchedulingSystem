using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class DayBlock
    {
        public int  DayBlockID  { get; set; }
        public bool	Sunday  	{ get; set; }
        public bool	Monday   	{ get; set; }
        public bool	Tuesday	    { get; set; }
        public bool	Wednesday	{ get; set; }
        public bool	Thursday	{ get; set; }
        public bool	Friday	    { get; set; }
        public bool	Saturday	{ get; set; }
        public bool	Online  	{ get; set; }
        /// <summary>
        /// This is an 8 bit int for Dewey's fancy bitwise functionality
        /// </summary>
        public byte DaysCode { get; set; }
    }
}
