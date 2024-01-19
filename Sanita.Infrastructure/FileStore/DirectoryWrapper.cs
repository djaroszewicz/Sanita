using Sanita.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Infrastructure.FileStore
{
    internal class DirectoryWrapper : IDirectoryWrapper
    {
        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
