using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.Common.Exceptions
{
    public interface IFileStore
    {
        string SafeWriteFile(byte[] content, string sourceFileName, string path)
    }
}
