using System.Windows.Forms;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class MenuItemProvider : IProvideMenuItem
    {
        [Pure]
        public IMenuItem Provide()
        {
            return Provide(null);
        }
        [Pure]
        public IMenuItem Provide(string text)
        {
            return new MenuItemWrapper(new MenuItem(text));
        }
    }
}