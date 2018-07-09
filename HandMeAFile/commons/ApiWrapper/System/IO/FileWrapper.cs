using System.IO;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public class FileWrapper : IFile
    {
        public bool Exists(string path)
        {
            return File.Exists(path);
        }
        public IFileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return new FileStreamWrapper(File.Open(path, mode, access, share));
        }
        public void Delete(string path)
        {
            File.Delete(path);
        }
    }
}