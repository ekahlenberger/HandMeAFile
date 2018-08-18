using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation
{
    public class CommandCreator<TProgressUiInfo> : ICreateCommands<TProgressUiInfo>
    {
        [NotNull] private readonly IProvideDefaultUiInteraction<TProgressUiInfo> m_defaultInteractionProvider;

        public CommandCreator([NotNull] IProvideDefaultUiInteraction<TProgressUiInfo> defaultInteractionProvider)
        {
            Debug.Assert(defaultInteractionProvider != null, nameof(defaultInteractionProvider) + " != null");
            m_defaultInteractionProvider = defaultInteractionProvider;
        }
        public IExecCommand CreateInitial<TResult>(Func<IProgress<ProgressNotification<TProgressUiInfo>>, TResult> backgroundAction, Action<TResult> foregroundResultProcessor)
        {
            return new InitialAsyncActionCommand<TResult, ProgressNotification<TProgressUiInfo>>(backgroundAction,
                                                                                                 foregroundResultProcessor,
                                                                                                 m_defaultInteractionProvider.Progress,
                                                                                                 m_defaultInteractionProvider.UiHandleException){IsExecutable = true};
        }

        public IExecCommand CreateProcessing<TCall, TResult>(Func<TCall, IProgress<ProgressNotification<TProgressUiInfo>>, TResult> backgroundAction,
                                                   Action<TResult> foregroundResultProcessor=null)
        {
            return new AsyncActionCommand<TCall,ProgressNotification<TProgressUiInfo>,TResult>(backgroundAction,foregroundResultProcessor,m_defaultInteractionProvider.Progress,m_defaultInteractionProvider.UiHandleException){IsExecutable = true};
        }
    }
}