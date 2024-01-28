using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanita.Domain.Common;
using Sanita.Domain.Entities;
using Sanita.Domain.ValueObjects;
using System.Reflection;
using Sanita.Application.Common.Interfaces;

namespace Sanita.Persistance
{
    public class SanitaDbContext : DbContext, ISanitaDbContext
    {
        private readonly IDateTime _dateTime;

        public SanitaDbContext(DbContextOptions<SanitaDbContext> options) : base(options)
        {
        }
        public SanitaDbContext(DbContextOptions<SanitaDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;  
        }

        public DbSet<BodyParameter> BodyParameters { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingType> TrainingTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedData();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}