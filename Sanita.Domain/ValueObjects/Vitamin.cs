using Sanita.Domain.Common;
using Sanita.Domain.Exceptions;
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

        public static Vitamin For(decimal vitaminA, decimal vitaminB1, decimal vitaminB2, decimal vitaminB5,
            decimal vitaminB6, decimal vitaminB12, decimal folidAcid, decimal biotin, decimal vitaminC, decimal vitaminD,
            decimal vitaminE, decimal vitaminPP, decimal vitaminK)
        {
            var vitaminObj = new Vitamin();
            try
            {
                vitaminObj.VitaminA = vitaminA;
                vitaminObj.VitaminB1 = vitaminB1;
                vitaminObj.VitaminB2 = vitaminB2;
                vitaminObj.VitaminB5 = vitaminB5;
                vitaminObj.VitaminB6 = vitaminB6;
                vitaminObj.VitaminB12 = vitaminB12;
                vitaminObj.FolidAcid = folidAcid;
                vitaminObj.Biotin = biotin;
                vitaminObj.VitaminC = vitaminC;
                vitaminObj.VitaminD = vitaminD;
                vitaminObj.VitaminE = vitaminE;
                vitaminObj.VitaminPP = vitaminPP;
                vitaminObj.VitaminK = vitaminK;

            }
            catch (Exception ex)
            {
                throw new VitaminException(ex);
            }

            return vitaminObj;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return VitaminA;
            yield return VitaminB1; 
            yield return VitaminB2; 
            yield return VitaminB5; 
            yield return VitaminB6; 
            yield return VitaminB12;
            yield return FolidAcid; 
            yield return Biotin; 
            yield return VitaminC; 
            yield return VitaminD; 
            yield return VitaminE; 
            yield return VitaminPP; 
            yield return VitaminK;
        }
    }
}
