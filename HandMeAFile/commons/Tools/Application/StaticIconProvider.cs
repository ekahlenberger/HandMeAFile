using org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing;

namespace org.ek.HandMeAFile.commons.Tools.Application
{
    public class StaticIconProvider : IProvideIcon
    {
        private readonly IIcon m_icon;

        public StaticIconProvider(IIcon icon)
        {
            m_icon = icon;
        }
        public IIcon Get()
        {
            return m_icon;
        }
    }
}