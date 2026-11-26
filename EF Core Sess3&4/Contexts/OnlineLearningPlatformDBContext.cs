using EF_Core_Sess3_4.Configurations;
using EF_Core_Sess3_4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Contexts
{
    internal class OnlineLearningPlatformDBContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=OnlineLearningPlatform;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
        DbSet<Course> Courses { get; set; }
        //DbSet<Category> Categories { get; set; }
        //DbSet<Enrollment> Enrollments { get; set; }
        //DbSet<Instructor> Instructors { get; set; }
        //DbSet<Student> Students { get; set; }
    }
}
