using System.Collections.Generic;
using System.IO;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public interface IDirectory
    {
        IDirectoryInfo CreateDirectory(string path);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern = "*", SearchOption searchOption = SearchOption.TopDirectoryOnly);
        bool Exists(string path);
    }
}