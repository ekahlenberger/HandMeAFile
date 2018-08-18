using System;

namespace org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation
{
    public interface IProvideDefaultUiInteraction<TUiInfo>
    {
        Action<Exception>                        UiHandleException { get; }
        IProgress<ProgressNotification<TUiInfo>> Progress          { get; }
    }
}