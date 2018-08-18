using System;

namespace org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation
{
    public interface ICreateCommands<TProgressUiInfo>
    {
        IExecCommand CreateInitial<TResult>(Func<IProgress<ProgressNotification<TProgressUiInfo>>, TResult> backgroundAction, Action<TResult> foregroundResultProcessor);
        IExecCommand CreateProcessing<TCall, TResult>(Func<TCall, IProgress<ProgressNotification<TProgressUiInfo>>, TResult> backgroundAction, Action<TResult> foregroundResultProcessor = null);
    }
}