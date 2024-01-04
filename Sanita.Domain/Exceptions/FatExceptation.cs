using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Exceptions
{
    internal class FatException : Exception
    {
        public FatException(Exception ex) : base($"Some of fat values is invalid.", ex)
        {

        }
    }
}
