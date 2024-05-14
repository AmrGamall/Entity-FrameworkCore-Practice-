using EFCorePractice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Salary)
                   .HasColumnType("decimal(18,3)");
            builder.Property(I => I.HourRate)
                   .HasColumnType("decimal(18,3)");
            builder.Property(I => I.Address)
                   .HasDefaultValue("Cairo");

        }
    }
}
