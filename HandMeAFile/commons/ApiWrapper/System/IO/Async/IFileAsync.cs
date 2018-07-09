using System.IO;
using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO.Async
{
    public interface IFileAsync
    {
        Task<bool> Exists(string path);
        Task<IFileStream> Open(string path, FileMode mode, FileAccess access, FileShare share);
        Task Delete(string path);
    }
}