using System;
using System.Windows;
using org.ek.HandMeAFile.commons.Extensions;
using org.ek.HandMeAFile.commons.UI.WPF.Extensions;

namespace org.ek.HandMeAFile.commons.UI.WPF
{
    public class BaseWindow : Window
    {
        public BaseWindow()
        {
            
        }
        public BaseWindow(IAccessSetting<String> placementSetting)
        {
            SourceInitialized += (sender, args) =>
                                 {
                                     if (!placementSetting.Get().IsNullOrWhitespace())
                                         this.SetPlacement(placementSetting.Get());
                                 };
            Closing += (sender, args) => { placementSetting.Set(this.GetPlacement()); };
        }
    }
}