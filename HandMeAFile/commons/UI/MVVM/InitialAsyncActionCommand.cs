using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.UI.MVVM
{
    public class InitialAsyncActionCommand<TResult, TProgress> : AsyncBaseCommand
    {
        private readonly Func<IProgress<TProgress>, TResult> m_background;
        private readonly Action<TResult> m_frontendResultProcessor;
        private readonly IProgress<TProgress> m_progress;

        public InitialAsyncActionCommand([NotNull] Func<IProgress<TProgress>,TResult> background, [NotNull] Action<TResult> frontendResultProcessor, IProgress<TProgress> progress = null, Action<Exception> handleException = null, Action cleanUp = null) : base(handleException, cleanUp)
        {
            m_background = background ?? throw new ArgumentNullException(nameof(background));
            m_frontendResultProcessor = frontendResultProcessor ?? throw new ArgumentNullException(nameof(frontendResultProcessor));
            m_progress = progress;
        }

        protected override async Task ExecuteSafeAsync(object parameter)
        {
            TResult result = await Task.Run(() => m_background(m_progress));
            m_frontendResultProcessor(result);
        }
    }
}