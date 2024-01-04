using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    public class Meal : AuditableEntity
    {
        public string Name { get; set; }
        public int MealProductId { get; set; }
        public List<Product> MealProducts { get; private set; } = new List<Product>();

        public string Description { get; set; }

    }
}
