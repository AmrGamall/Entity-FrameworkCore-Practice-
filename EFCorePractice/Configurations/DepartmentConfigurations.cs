using EFCorePractice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10,10);

            builder.Property(D => D.HiringDate).HasComputedColumnSql("GETDATE()");


            //// One To Many

            builder.HasMany(D => D.Instructors)
                    .WithOne(I => I.WorkForDepartment)
                    .IsRequired(false)
                    .HasForeignKey(I => I.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade);


            // One To One
            builder.HasOne(D => D.Manager)
                    .WithOne(E => E.ManageDepartment)
                    .HasForeignKey<Department>(D => D.ManagerId)
                    .IsRequired(false);

        }
    }
}
