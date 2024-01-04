using Sanita.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Entities
{
    public class BodyParameter : AuditableEntity
    {
        public int UserId { get; set; }
        public decimal? Weigth { get; set; }
        public decimal? Heigth { get; set; }
        public decimal? Neck { get; set; }
        public decimal? Chest { get; set; }
        public decimal? Waist { get; set; }
        public decimal? Stomach { get; set; }
        public decimal? Hips { get; set; }
        public decimal? Biceps { get; set; }
        public decimal? Forearm { get; set; }
        public decimal? Thigh { get; set; }
        public decimal? Calf { get; set; }





    }
}
