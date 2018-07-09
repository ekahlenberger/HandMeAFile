namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public interface IProvideContextMenu
    {
        IContextMenu Provide(IMenuItem[] items);
    }
}