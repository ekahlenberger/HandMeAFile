using System;

namespace org.ek.HandMeAFile.commons.UI.MVVM
{
    public abstract class BaseCommand : IExecCommand
    {
        public event EventHandler CanExecuteChanged;
        private bool m_isExecutable;
        public bool IsExecutable
        {
            get => m_isExecutable;
            set
            {
                if (m_isExecutable == value) return;
                m_isExecutable = value;
                OnCanExecuteChanged();
            }
        }

        /// <summary>Definiert die Methode, die bestimmt, ob der Befehl im aktuellen Zustand ausgeführt werden kann.</summary>
        /// <returns>true, wenn der Befehl ausgeführt werden kann, andernfalls false.</returns>
        /// <param name="parameter">Vom Befehl verwendete Daten. Wenn der Befehl keine Datenübergabe erfordert, kann das Objekt auf null festgelegt werden.</param>
        public virtual bool CanExecute(object parameter)
        {
            return IsExecutable;
        }

        /// <summary>Definiert die Methode, die aufgerufen wird, wenn der Befehl aufgerufen wird.</summary>
        /// <param name="parameter">Vom Befehl verwendete Daten. Wenn der Befehl keine Datenübergabe erfordert, kann das Objekt auf null festgelegt werden.</param>
        public abstract void Execute(object parameter);

        protected virtual void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}