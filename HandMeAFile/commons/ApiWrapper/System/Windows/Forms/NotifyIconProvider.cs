using System.Windows.Forms;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class NotifyIconProvider : IProvideNotifyIcon
    {
        public INotifyIcon Provide()
        {
            return new NotifyIconWrapper(new NotifyIcon());
        }
    }
}