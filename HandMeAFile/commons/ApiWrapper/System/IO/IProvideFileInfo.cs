using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public interface IProvideFileInfo
    {
        Task<IFileInfo> Provide(string fileName);
    }
}