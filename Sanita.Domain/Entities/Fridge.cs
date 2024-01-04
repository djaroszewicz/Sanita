using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    public class Fridge : AuditableEntity
    {
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
