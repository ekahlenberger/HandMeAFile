using System;
using System.Windows;

namespace org.ek.HandMeAFile.commons.Tools.SingleInstance
{
    public interface IRunTheAppOnce
    {
        event EventHandler<SecondInstanceEventArgs> SecondInstanceStarted;
        bool Run(StartupEventArgs args);
    }
}