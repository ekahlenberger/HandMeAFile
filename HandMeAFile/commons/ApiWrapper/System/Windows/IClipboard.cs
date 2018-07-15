using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows
{
    public interface IClipboard
    {
        bool ContainsFileDropList();
        StringCollection GetFileDropList();
        void SetFileDropList(StringCollection fileDropList);
        void SetFileDropList(IEnumerable<string> fileDropList);
        void SetFileDropList(IEnumerable<Path> fileDropList);
        Path[] GetFileDropListPaths();
    }
}