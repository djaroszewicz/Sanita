using Microsoft.EntityFrameworkCore;
using Sanita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyParameter>(b =>
            {
                b.HasData(new BodyParameter()
                {
                    Id = 1,
                    UserId = 1,
                    Created = DateTime.Now

                });
            });
        }
    }
}
