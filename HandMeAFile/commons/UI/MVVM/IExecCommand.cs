using System.Windows.Input;

namespace org.ek.HandMeAFile.commons.UI.MVVM
{
    public interface IExecCommand : ICommand
    {
        bool IsExecutable { get; set; }
        void Execute();
    }
}