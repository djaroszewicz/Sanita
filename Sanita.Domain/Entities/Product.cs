using Sanita.Domain.Common;
using Sanita.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Kcal { get; set; }
        public Protein Protein { get; set; }
        public Fat Fat { get; set; }
        public Carbohydrates Carbohydrates { get; set; }

        //public decimal? Fat { get; set;}
        //public decimal? SaturatedFattyAcids { get; set;}
        //public decimal? TransFattyAcids { get; set; }
        //public decimal? Cholesterol { get; set; }
        //public decimal? Sodium { get; set; }
        //public decimal? Potassium { get; set; }
        //public decimal? Carbohydrates { get; set; }
        //public decimal? Fiber { get; set; }
        //public decimal? Sugars { get; set; }
        //public Protein Protein { get; set; }
        //public decimal? AscorbicAcid { get; set; }
        //public decimal? Iron { get; set; }
        //public decimal? VitaminB6 { get; set; } 
        //public decimal? VitaminB12 { get; set; }
        //public decimal? VitaminD { get; set; }
        //public decimal? Magnesium { get; set; }
        //public decimal? Calcium { get; set; }



    }
}
