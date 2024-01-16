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


            builder.Property(p => p.Heigth).IsRequired();
            builder.Property(p => p.Weigth).HasDefaultValue(0.0);
        }
    }
}
