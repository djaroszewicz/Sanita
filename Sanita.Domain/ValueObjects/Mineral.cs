using Sanita.Domain.Common;
using Sanita.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.ValueObjects
{
    public class Mineral : ValueObject
    {
        public decimal Zinc { get; set; }
        public decimal Phosphorus { get; set; }
        public decimal Iodine { get; set; }
        public decimal Magnesium { get; set; }
        public decimal Copper { get; set; }
        public decimal Potassium { get; set; }
        public decimal Selenium { get; set; }
        public decimal Sodium { get; set; }
        public decimal Calcium { get; set; }
        public decimal Iron { get; set; }

        public static Mineral For(decimal zinc, decimal phosphorus, decimal iodine, decimal magnesium, 
            decimal copper, decimal potassium, decimal selenium, decimal sodium, decimal calcium, decimal iron,
    decimal vitaminE, decimal vitaminPP, decimal vitaminK)
        {
            var mineralObj = new Mineral();
            try
            {
                mineralObj.Zinc = zinc;
                mineralObj.Phosphorus = phosphorus;
                mineralObj.Iodine = iodine;
                mineralObj.Magnesium = magnesium;
                mineralObj.Copper = copper;
                mineralObj.Potassium = potassium;
                mineralObj.Selenium = selenium;
                mineralObj.Sodium = sodium;
                mineralObj.Calcium = calcium;
                mineralObj.Iron = iron;

            }
            catch (Exception ex)
            {
                throw new MineralException(ex);
            }

            return mineralObj;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Zinc; yield return Phosphorus; yield return Iodine; yield return Magnesium; yield return Copper; yield return Potassium; yield return Selenium;
             yield return Sodium; yield return Calcium; yield return Iron; }
    }
}
