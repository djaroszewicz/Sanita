using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sanita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Persistance.Configurations
{
    public class ProductInfoConfiguration : IEntityTypeConfiguration<ProductInfo>
    {
        public void Configure(EntityTypeBuilder<ProductInfo> builder)
        {
            builder.OwnsOne(p => p.Protein).Property(p => p.Plant).HasColumnName("PlantProtein").IsRequired();
            builder.OwnsOne(p => p.Protein).Property(p => p.Animal).HasColumnName("AnimalProtein").IsRequired();

            builder.OwnsOne(p => p.Fat).Property(p => p.Saturated).HasColumnName("Saturated").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Fat).Property(p => p.Monounsaturated).HasColumnName("Monounsaturated").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Fat).Property(p => p.Polyunsaturated).HasColumnName("Polyunsaturated").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Fat).Property(p => p.Omega3Acid).HasColumnName("Omega3Acid").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Fat).Property(p => p.Omega6Acid).HasColumnName("Omega6Acid").HasDefaultValue(0.00);

            builder.OwnsOne(p => p.Carbohydrates).Property(p => p.CarbohydratesNetto).HasColumnName("CarbohydratesNetto").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Carbohydrates).Property(p => p.Sugars).HasColumnName("Sugars").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Carbohydrates).Property(p => p.Fiber).HasColumnName("Fiber").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Carbohydrates).Property(p => p.Salt).HasColumnName("Salt").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Carbohydrates).Property(p => p.Choresterol).HasColumnName("Choresterol").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Carbohydrates).Property(p => p.Caffeine).HasColumnName("Caffeine").HasDefaultValue(0.00);

            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminA).HasColumnName("VitaminA").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminB1).HasColumnName("VitaminB1").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminB2).HasColumnName("VitaminB2").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminB5).HasColumnName("VitaminB5").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminB6).HasColumnName("VitaminB6").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminB12).HasColumnName("VitaminB12").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.FolidAcid).HasColumnName("FolidAcid").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.Biotin).HasColumnName("Biotin").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminC).HasColumnName("VitaminC").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminD).HasColumnName("VitaminD").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminE).HasColumnName("VitaminE").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminPP).HasColumnName("VitaminPP").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Vitamin).Property(p => p.VitaminK).HasColumnName("VitaminK").HasDefaultValue(0.00);


            builder.OwnsOne(p => p.Mineral).Property(p => p.Zinc).HasColumnName("Zinc").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Phosphorus).HasColumnName("Phosphorus").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Iodine).HasColumnName("Iodine").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Magnesium).HasColumnName("Magnesium").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Copper).HasColumnName("Copper").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Potassium).HasColumnName("Potassium").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Selenium).HasColumnName("Selenium").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Sodium).HasColumnName("Sodium").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Calcium).HasColumnName("Calcium").HasDefaultValue(0.00);
            builder.OwnsOne(p => p.Mineral).Property(p => p.Iron).HasColumnName("Iron").HasDefaultValue(0.00);
        }
    }
}
