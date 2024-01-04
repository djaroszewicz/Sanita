using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.ValueObjects
{
    public class Vitamin : ValueObject
    {
        public decimal VitaminA { get; set; }
        public decimal VitaminB1 { get; set; }
        public decimal VitaminB2 { get; set; }
        public decimal VitaminB5 { get; set; }
        public decimal VitaminB6 { get; set; }
        public decimal VitaminB12 { get; set; }
        public decimal FolidAcid { get; set; }
        public decimal Biotin { get; set; }

        public decimal VitaminC { get; set; }
        public decimal VitaminD { get; set; }
        public decimal VitaminE { get; set; }
        public decimal VitaminPP { get; set; }
        public decimal VitaminK { get; set; }



        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
