using System;
using System.IO;
using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO.Async
{
    public class FileWrapperAsync : IFileAsync
    {
        private readonly IFile m_fileApi;
        public FileWrapperAsync(IFile fileApi)
        {
            if (fileApi == null) throw new ArgumentNullException(nameof(fileApi));
            m_fileApi = fileApi;
        }
        public Task<bool> Exists(string path)
        {
            return Task.Run(() => m_fileApi.Exists(path));
        }
        public Task<IFileStream> Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return Task.Run(() => m_fileApi.Open(path, mode, access, share));
        }
        public Task Delete(string path)
        {
            return Task.Run(() => m_fileApi.Delete(path));
        }
    }
}