using EF_Core_Sess3_4.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Models
{
    internal class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public decimal ProgressPercentage { get; set; }
        public EnrollmentStatus Status { get; set; }
        public decimal? FinalGrade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }


       
    }
}
