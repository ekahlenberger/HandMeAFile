using System.Windows.Forms;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class ContextMenuStripWrapper : IContextMenuStrip, IProvideOrgContextMenuStrip
    {
        private readonly ContextMenuStrip m_orgStrip;
        public ContextMenuStrip OrgStrip => m_orgStrip;

        public ContextMenuStripWrapper(ContextMenuStrip orgStrip)
        {
            m_orgStrip = orgStrip;
        }

        
    }
}