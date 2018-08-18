using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq;
using org.ek.HandMeAFile.commons.Extensions;
using org.ek.HandMeAFile.commons.Tools;
using Path = org.ek.HandMeAFile.commons.Tools.Path;


namespace org.ek.HandMeAFile.Model
{
    public class FilePackSerializer : GenericSerializer<FilePack>
    {
        private readonly IProvideXDocument m_xdocProvider;

        public FilePackSerializer([NotNull] IProvideXDocument xdocProvider)
        {
            Debug.Assert(xdocProvider != null, nameof(xdocProvider) + " != null");
            m_xdocProvider = xdocProvider;
        }
        public override string Serialize(FilePack[] pack)
        {
            if (pack.IsNullOrEmpty()) return null;
            IXDocument doc = m_xdocProvider.Provide();

            XElement root = new XElement("FilePacks");
            doc.Add(root);
            foreach (FilePack filePack in pack)
            {
                XElement packNode = new XElement("FilePack");
                root.Add(packNode);
                packNode.Add(new XElement("Count",filePack.ClipboardCount));
                XElement filesNode = new XElement("Files");
                packNode.Add(filesNode);
                filePack.Run(file => filesNode.Add(new XElement("File", file.ToString())));
            }

            return doc.ToString(SaveOptions.DisableFormatting);
        }

        public override IEnumerable<FilePack> Deserialize(string serialized)
        {
            if (serialized.IsNullOrWhitespace()) yield break;

            IXDocument doc = m_xdocProvider.Parse(serialized);
            
            foreach (XElement filePackNode in doc.Root.XPathSelectElements("//FilePacks/FilePack"))
            {
                int count = filePackNode.Element("Count")?.Value.ConvertToInt() ?? throw new InvalidDataException($"could not parse filePacks / illegal Node: {filePackNode}");
                Path[] files = filePackNode.XPathSelectElements("Files/File").Select(node => node.Value.AsWindowsFilePath()).ToArray();
                yield return new FilePack(files).SetCount(count);
            }
        }
    }
}