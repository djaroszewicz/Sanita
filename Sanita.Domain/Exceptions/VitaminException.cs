using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Exceptions
{
    internal class VitaminException : Exception
    {
        public VitaminException(Exception ex) : base($"Some of vitamin values is invalid.", ex)
        {

        }
    }
}
