using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(th=>th.id);

            builder.Property(th => th.first_name)
                   .HasMaxLength(20)
                   .IsRequired();
            builder.Property(th => th.last_name)
                   .HasMaxLength(20)
                   .IsRequired();
            builder.Property(th => th.middle_name)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(th=>th.specialization)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.HasIndex(th => new { th.first_name, th.last_name, th.middle_name, th.specialization })
                   .IsUnique();

            builder.Property(th=>th.qualification)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(th=>th.workload)
                   .IsRequired();
            builder.ToTable(t => t.HasCheckConstraint("CK_Teacher_workload", "[workload] > 0"));
        }
    }
}
