using System.Xml.Linq;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq
{
    public class XDocumentProvider : IProvideXDocument
    {
        public IXDocument Load(string file)
        {
            return new XDocumentWrapper(XDocument.Load(file));
        }
        public IXDocument Parse(string text)
        {
            return new XDocumentWrapper(XDocument.Parse(text));
        }

        public IXDocument Provide()
        {
            return new XDocumentWrapper(new XDocument());
        }
    }
}