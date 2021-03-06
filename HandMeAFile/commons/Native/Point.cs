﻿using System;
using System.Runtime.InteropServices;

namespace org.ek.HandMeAFile.commons.Native
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}