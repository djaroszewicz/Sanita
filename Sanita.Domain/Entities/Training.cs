using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    public class Training : AuditableEntity
    {
        public string Name { get; set; }
        public int TrainingId { get; set; }  
        public int ExerciseId { get; set; }
        public List<Exercise> Exercises { get; private set; } = new List<Exercise>();
    }
}
