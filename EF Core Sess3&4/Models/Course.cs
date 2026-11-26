using EF_Core_Sess3_4.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public CourseLevel Level { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }
        public Category Category { get; set; }  
        public Instructor Instructor { get; set; }  
        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }   
    }
}
