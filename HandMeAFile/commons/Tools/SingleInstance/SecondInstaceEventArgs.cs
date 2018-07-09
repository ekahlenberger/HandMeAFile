using System;

namespace org.ek.HandMeAFile.commons.Tools.SingleInstance
{
    public class SecondInstanceEventArgs : EventArgs
    {
        public string[] Args { get; }

        public SecondInstanceEventArgs(string[] args)
        {
            Args = args;
        }
    }
}