using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Domain.Exceptions
{
    internal class MineralException : Exception
    {
        public MineralException(Exception ex) : base($"Some of mineral values is invalid.", ex)
        {

        }
    }
}
