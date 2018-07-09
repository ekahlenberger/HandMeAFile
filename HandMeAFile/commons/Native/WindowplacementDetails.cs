using System;
using System.Runtime.InteropServices;

namespace org.ek.HandMeAFile.commons.Native
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowplacementDetails
    {
        public int length;
        public int flags;
        public int showCmd;
        public Point minPosition;
        public Point maxPosition;
        public Rect normalPosition;
    }
}