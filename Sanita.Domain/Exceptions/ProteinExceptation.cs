using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Exceptions
{
    internal class ProteinException : Exception
    {
        public ProteinException(Exception ex) : base($"Some of protein values is invalid.", ex)
        {

        }
    }
}
