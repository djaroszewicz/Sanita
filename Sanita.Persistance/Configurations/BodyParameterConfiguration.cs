using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sanita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Persistance.Configurations
{
    public class BodyParameterConfiguration : IEntityTypeConfiguration<BodyParameter>
    {
        public void Configure(EntityTypeBuilder<BodyParameter> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.Heigth).HasDefaultValue(0.00);
            builder.Property(p => p.Weigth).HasDefaultValue(0.00);
            builder.Property(p => p.Neck).HasDefaultValue(0.00);
            builder.Property(p => p.Chest).HasDefaultValue(0.00);
            builder.Property(p => p.Waist).HasDefaultValue(0.00);
            builder.Property(p => p.Stomach).HasDefaultValue(0.00);
            builder.Property(p => p.Hips).HasDefaultValue(0.00);
            builder.Property(p => p.Biceps).HasDefaultValue(0.00);
            builder.Property(p => p.Forearm).HasDefaultValue(0.00);
            builder.Property(p => p.Thigh).HasDefaultValue(0.00);
            builder.Property(p => p.Calf).HasDefaultValue(0.00);
        }
    }
}
