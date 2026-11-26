using EF_Core_Sess3_4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Configurations
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable("Enrollments");
            
            builder.ToTable(x => x.HasCheckConstraint (
                        "Check_Enrollments_FinalGrade","[FinalGrade] IS NULL OR [Status] = 'Completed'"
             ));

            builder.HasKey(e => new {e.CourseId, e.StudentId });

            builder.Property(e => e.EnrollmentDate)
             .HasColumnType("date")
             .IsRequired();

            builder.Property(e => e.ProgressPercentage)
                .HasPrecision(5, 2)
                .IsRequired();

            builder.Property(e => e.Status)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(e => e.FinalGrade)
                .HasPrecision(5, 2)
                .IsRequired(false);

            builder.HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
