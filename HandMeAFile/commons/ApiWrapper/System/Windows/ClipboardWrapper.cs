using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using org.ek.HandMeAFile.commons.Extensions;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows
{
    public class ClipboardWrapper : IClipboard
    {
        public bool ContainsFileDropList() => Clipboard.ContainsFileDropList();
        public StringCollection GetFileDropList() => Clipboard.GetFileDropList();
        public Path[] GetFileDropListPaths() => Clipboard.GetFileDropList().OfType<string>().Select(s => s.AsWindowsFilePath()).ToArray();
        public void SetFileDropList(StringCollection fileDropList) => Clipboard.SetFileDropList(fileDropList);
        public void SetFileDropList(IEnumerable<string> fileDropList)
        {
            StringCollection files = new StringCollection();
            files.AddRange(fileDropList.ToArray());
            Clipboard.SetFileDropList(files);
        }
        public void SetFileDropList(IEnumerable<Path> fileDropList)
        {
            StringCollection files = new StringCollection();
            files.AddRange(fileDropList.Select(p => p.ToString()).ToArray());
            Clipboard.SetFileDropList(files);
        }
    }
}