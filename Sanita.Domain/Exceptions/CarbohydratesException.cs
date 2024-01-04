using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Exceptions
{
    internal class CarbohydratesException : Exception
    {
        public CarbohydratesException(Exception ex) : base($"Some of carbohydrates mail is invalid.", ex)
        {

        }
    }
}
