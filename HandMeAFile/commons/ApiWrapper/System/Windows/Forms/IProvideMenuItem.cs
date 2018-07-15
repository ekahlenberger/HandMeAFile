using org.ek.HandMeAFile.Model;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public interface IProvideMenuItem
    {
        IMenuItem Provide();
        IMenuItem Provide(string text, object tag = null);
        
    }
}