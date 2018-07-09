using System.IO;
using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public class FileInfoProvider : IProvideFileInfo
    {
        public Task<IFileInfo> Provide(string fileName)
        {
            return Task.Run<IFileInfo>(() => new FileInfoWrapper(new FileInfo(fileName)));
        }
    }
}