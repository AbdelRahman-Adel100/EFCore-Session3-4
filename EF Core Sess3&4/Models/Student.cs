using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();

    }
}
