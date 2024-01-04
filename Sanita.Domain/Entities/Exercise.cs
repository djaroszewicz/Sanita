using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    public class Exercise : AuditableEntity
    {
        public string Name { get; set; }
        public string MovieUrl { get; set; }
        public int ExerciseTypeId { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public List<Muscle> Muscles { get; set; } = new List<Muscle>();

    }
}
