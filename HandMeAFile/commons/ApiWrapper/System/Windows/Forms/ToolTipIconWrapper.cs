using System.Windows.Forms;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class ToolTipIconWrapper : IToolTipIcon, IProvideOrgToolTipIcon
    {
        public ToolTipIcon OrgIcon { get; }

        public ToolTipIconWrapper(ToolTipIcon orgIcon)
        {
            OrgIcon = orgIcon;
        }
    }
}