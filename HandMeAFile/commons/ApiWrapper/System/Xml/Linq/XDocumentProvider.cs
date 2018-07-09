using System.Xml.Linq;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq
{
    public class XDocumentProvider : IProvideXDocument
    {
        public IXDocument Provide(string file)
        {
            return new XDocumentWrapper(XDocument.Load(file));
        }
    }
}