using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models.Configuration
{
    public class AuditoryConfiguration : IEntityTypeConfiguration<Auditory>
    {
        public void Configure(EntityTypeBuilder<Auditory> builder)
        {
            builder.HasKey(a=>a.id);

            builder.HasIndex(a=>a.title)
                   .IsUnique();
            builder.Property(a=>a.title)
                   .HasMaxLength(10)
                   .IsRequired();

            builder.Property(a=>a.capacity).IsRequired();
            builder.ToTable(t => t.HasCheckConstraint("CK_Auditory_capacity", "[capacity] > 0"));

            builder.HasOne(a => a.AudienceSpecialization)
                   .WithMany(aus => aus.Auditories)
                   .HasForeignKey(a => a.AudienceSpecializationId);

        }
    }
}
