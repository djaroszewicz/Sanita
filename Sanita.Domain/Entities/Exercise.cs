using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    internal class Exercise : AuditableEntity
    {
        public string Name { get; set; }
    }
}
