using System.Collections.Generic;
using System.IO;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public class DirectoryWrapper : IDirectory
    {
        public IDirectoryInfo CreateDirectory(string path)
        {
            return (DirectoryInfoWrapper)Directory.CreateDirectory(path);
        }
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFiles(path, searchPattern, searchOption);
        }
        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }
    }
}