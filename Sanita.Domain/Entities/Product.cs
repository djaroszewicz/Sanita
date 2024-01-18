using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public decimal Weight { get; set; }
        public int ProductInfoId { get; set; }
        public ProductInfo ProductInfo { get; set; }
    }
}
