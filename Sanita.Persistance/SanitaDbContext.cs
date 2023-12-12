using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Persistance
{
    public class SanitaDbContext : DbContext
    {
        public SanitaDbContext(DbContextOptions<SanitaDbContext> options) : base(options)
        {               
                
        }       
    }
}