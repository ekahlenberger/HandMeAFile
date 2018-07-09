using System.IO;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public class PathWrapper : IPath
    {
        public string Combine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }
        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }
    }
}