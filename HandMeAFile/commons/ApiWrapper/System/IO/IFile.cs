using System.IO;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public interface IFile
    {
        bool Exists(string path);
        IFileStream Open(string path, FileMode mode, FileAccess access, FileShare share);
        void Delete(string path);
    }
}