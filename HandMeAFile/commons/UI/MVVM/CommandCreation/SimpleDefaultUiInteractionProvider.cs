using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation
{
    public class SimpleDefaultUiInteractionProvider<TUiInfo> : IProvideDefaultUiInteraction<TUiInfo>
    {
        [NotNull] public Action<Exception>                        UiHandleException { get; }
        [NotNull] public IProgress<ProgressNotification<TUiInfo>> Progress          { get; }

        public SimpleDefaultUiInteractionProvider([NotNull] Action<Exception> exceptionHandler, [NotNull] IProgress<ProgressNotification<TUiInfo>> progress)
        {
            Debug.Assert(exceptionHandler != null, nameof(exceptionHandler) + " != null");
            Debug.Assert(progress         != null, nameof(progress)         + " != null");
            UiHandleException = exceptionHandler;
            Progress          = progress;
        }
    }
}