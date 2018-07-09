using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.UI.MVVM
{
    public class ActionCommand<T> : BaseCommand
    {
        private readonly Func<T, Task> m_actionTask;
        private readonly Action<T> m_action;
        

        public ActionCommand([NotNull] Action<T> action)
        {
            m_action = action ?? throw new ArgumentNullException(nameof(action));
        }
        public ActionCommand([NotNull] Func<T, Task> actionTask)
        {
            m_actionTask = actionTask ?? throw new ArgumentNullException(nameof(actionTask));
        }

        /// <summary>Definiert die Methode, die aufgerufen wird, wenn der Befehl aufgerufen wird.</summary>
        /// <param name="parameter">Vom Befehl verwendete Daten.  Wenn der Befehl keine Datenübergabe erfordert, kann das Objekt auf null festgelegt werden.</param>
        public override async void Execute(object parameter)
        {
            if (!CanExecute(parameter)) return;
            if (m_actionTask != null)
            {
                await m_actionTask((T)parameter);
                return;
            }
            m_action((T) parameter);
        }
    }
}