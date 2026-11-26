using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Models
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string? Bio { get; set; }
        public DateTime JoinDate { get; set; }
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
