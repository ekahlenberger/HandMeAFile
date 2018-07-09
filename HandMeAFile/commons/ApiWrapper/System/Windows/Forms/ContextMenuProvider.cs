using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class ContextMenuProvider : IProvideContextMenu
    {
        [Pure]
        public IContextMenu Provide(IMenuItem[] items)
        {
            List<MenuItem> castedItems = items?.Cast<IProvideOrgMenuItem>().Select(omi => omi.OrgMenuItem).ToList();
            return new ContextMenuWrapper(new ContextMenu(castedItems?.ToArray()));
        }
    }
}