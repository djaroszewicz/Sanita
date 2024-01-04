using Sanita.Domain.Common;
using Sanita.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.ValueObjects
{
    public class Carbohydrates : ValueObject
    {
        public decimal CarbohydratesNetto { get; set; }
        public decimal Sugars { get; set; }
        public decimal Fiber { get; set; }
        public decimal Salt { get; set; }   
        public decimal Choresterol { get; set; }   
        public decimal Caffeine { get; set; }

        public static Carbohydrates For(decimal carbohydratesNetto, decimal sugars, decimal fiber, decimal salt, decimal choresterol, decimal caffeine)
        {
            var carbohydratesnObj = new Carbohydrates();
            try
            {
                carbohydratesnObj.CarbohydratesNetto = carbohydratesNetto;
                carbohydratesnObj.Sugars = sugars;
                carbohydratesnObj.Fiber = fiber;
                carbohydratesnObj.Salt = salt;
                carbohydratesnObj.Choresterol = choresterol;
                carbohydratesnObj.Caffeine = caffeine;
                //proteinObj.Total = animal + plant;

            }
            catch (Exception ex)
            {
                throw new CarbohydratesException(ex);
            }

            return carbohydratesnObj;
        }


        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
