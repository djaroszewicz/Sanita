using Sanita.Domain.Common;
using Sanita.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.ValueObjects
{
    public class Fat : ValueObject
    {
        public decimal Saturated { get; set; }
        public decimal Monounsaturated { get; set; }
        public decimal Polyunsaturated { get; set; }
        public decimal Omega3Acid { get; set; }
        public decimal Omega6Acid { get; set; }

        public static Fat For(decimal saturated, decimal monounsaturated, decimal polyunsaturated, decimal omega3Acid, decimal omega6Acid)
        {
            var fatObj = new Fat();
            try
            {
                fatObj.Saturated = saturated;
                fatObj.Monounsaturated = monounsaturated;
                fatObj.Polyunsaturated = polyunsaturated;
                fatObj.Omega3Acid = omega3Acid;
                fatObj.Omega6Acid = omega6Acid;
                //proteinObj.Total = animal + plant;

            }
            catch (Exception ex)
            {
                throw new ProteinException(ex);
            }

            return fatObj;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Saturated; yield return Monounsaturated; yield return Polyunsaturated; yield return Omega3Acid; yield return Omega6Acid;   
        }
    }
}
