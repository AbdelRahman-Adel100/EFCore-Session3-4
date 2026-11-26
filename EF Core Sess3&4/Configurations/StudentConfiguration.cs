using EF_Core_Sess3_4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            
            builder.HasKey(s => s.StudentId);
            
            builder.Property(s => s.FullName)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(s => s.EmailAddress)
                .IsRequired()
                .HasMaxLength(200);
            
            builder.Property(s => s.DateOfBirth)
                .HasColumnType("date")
                .IsRequired();

            builder.HasMany(s => s.Enrollments)
                .WithOne(e => e.Student);
        }
    
    }
}
