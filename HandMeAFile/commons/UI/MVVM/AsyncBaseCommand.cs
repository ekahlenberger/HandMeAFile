using System;
using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.UI.MVVM
{
    public abstract class AsyncBaseCommand : BaseCommand
    {
        private readonly Action<Exception> m_exceptionHandling;
        private readonly Action m_cleanUp;

        protected AsyncBaseCommand(Action<Exception> exceptionHandling = null, Action cleanUp = null)
        {
            m_exceptionHandling = exceptionHandling;
            m_cleanUp = cleanUp;
        }
        /// <summary>Definiert die Methode, die aufgerufen wird, wenn der Befehl aufgerufen wird.</summary>
        /// <param name="parameter">Vom Befehl verwendete Daten.  Wenn der Befehl keine Datenübergabe erfordert, kann das Objekt auf null festgelegt werden.</param>
        public override async void Execute(object parameter)
        {
            try
            {
                await ExecuteSafeAsync(parameter);
            }
            catch (Exception ex)
            {
                if (m_exceptionHandling == null) throw;
                m_exceptionHandling(ex);
            }
            finally
            {
                m_cleanUp?.Invoke();
            }
        }

        protected abstract Task ExecuteSafeAsync(object parameter);
    }
}