namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq
{
    public interface IProvideXDocument
    {
        IXDocument Load(string file);
        IXDocument Provide();
        IXDocument Parse(string text);
    }
}