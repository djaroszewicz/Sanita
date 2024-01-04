using Sanita.Domain.Common;
using Sanita.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.ValueObjects
{
    public class Protein : ValueObject
    {
        public decimal Animal { get; set; }
        public decimal Plant { get; set; }
        //public decimal Total { get; set; } = 0;


        public static Protein For(decimal animal, decimal plant)
        {
            var proteinObj = new Protein();
            try
            {
                proteinObj.Animal = animal;
                proteinObj.Plant = plant;
                //proteinObj.Total = animal + plant;

            }
            catch (Exception ex)
            {
                throw new ProteinException(ex);
            }

            return proteinObj;
        }

        public decimal Total()
        {
            return Animal + Plant;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Animal;
            yield return Plant;
        }
    }
}
