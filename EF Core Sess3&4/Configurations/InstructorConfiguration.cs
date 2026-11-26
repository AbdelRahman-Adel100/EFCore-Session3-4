using EF_Core_Sess3_4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Sess3_4.Configurations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");

            builder.HasKey(i => i.InstructorId);

            builder.Property(i => i.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(i => i.EmailAddress)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(i => i.Bio)
                .HasMaxLength(250);

            builder.Property(i => i.JoinDate)
               .HasColumnType("date")
               .IsRequired();

            builder.HasMany(i => i.Courses)
                .WithOne(c => c.Instructor);
               
        }
    
    }
}
