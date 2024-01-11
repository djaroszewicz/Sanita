using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Persistance
{
    internal class SanitaDbContextFactory : DesignTimeDbContextFactoryBase<SanitaDbContext>
    {
        protected override SanitaDbContext CreateNewInstance(DbContextOptions<SanitaDbContext> options)
        {
            return new SanitaDbContext(options);
        }
    }
}
