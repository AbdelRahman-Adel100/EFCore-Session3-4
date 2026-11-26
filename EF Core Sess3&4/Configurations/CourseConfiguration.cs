using EF_Core_Sess3_4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
           
            builder.HasKey(c => c.CourseId);
            
            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);
            
            builder.Property(c => c.Description)
                .HasMaxLength(500);
            
            builder.Property(c => c.Price)
                .HasPrecision(10,2)
                .IsRequired();
            
            builder.Property(c => c.Level)
                .HasConversion<string>()
                .IsRequired();
            
            builder.Property(c => c.IsPublished)
                .IsRequired();
            
            builder.Property(c => c.PublishedDate)
                .HasColumnType("date")
                .IsRequired(false);

            builder.HasOne(c => c.Category)
                .WithMany(x => x.Courses)
                .HasForeignKey(f => f.CategoryId);

            builder.HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId);
        }
    }
}
