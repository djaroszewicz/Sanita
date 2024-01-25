using Microsoft.EntityFrameworkCore;
using Sanita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.Common.Interfaces
{
    public interface ISanitaDbContext
    {
        DbSet<BodyParameter> BodyParameters { get; set; }
        DbSet<Exercise> Exercises { get; set; }
        DbSet<ExerciseType> ExerciseTypes { get; set; }
        DbSet<Fridge> Fridges { get; set; }
        DbSet<Meal> Meals { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductInfo> ProductInfo { get; set; }
        DbSet<Training> Trainings { get; set; }
        DbSet<TrainingType> TrainingTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
