using System;
using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.UI.MVVM
{
    public class AsyncActionCommand<TCall, TProgress, TResult> : AsyncBaseCommand
    {
        private readonly Func<TCall, IProgress<TProgress>, TResult> m_backgroundAction;
        private readonly Action<TResult> m_frontendResultProcessor;
        private readonly IProgress<TProgress> m_progress;
        
        public AsyncActionCommand(Func<TCall, IProgress<TProgress>,TResult> backgroundAction, Action<TResult> frontendResultProcessor = null, IProgress<TProgress> progress = null)
        {
            m_backgroundAction = backgroundAction;
            m_frontendResultProcessor = frontendResultProcessor;
            m_progress = progress;
        }

        protected override async Task ExecuteSafeAsync(object parameter)
        {
            if (!IsExecutable) return;
            TResult result = await Task.Run(() => m_backgroundAction((TCall)parameter, m_progress));
            m_frontendResultProcessor?.Invoke(result);
        }
    }
}