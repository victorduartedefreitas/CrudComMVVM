using System;
using System.Windows.Input;

namespace CrudComMVVM.Core
{
    public class BaseCommand : ICommand
    {
        #region Local Variables

        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        private readonly Action RaiseCanExecuteChangedAction;

        #endregion

        #region Constructors and Destructors

        public BaseCommand(Action execute)
            : this(execute, null)
        {
        }

        public BaseCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
            RaiseCanExecuteChangedAction = RaiseCanExecuteChanged;
            CommandManager.AddRaiseCanExecuteChangedAction(ref RaiseCanExecuteChangedAction);
        }

        ~BaseCommand()
        {
            RemoveCommand();
        }

        #endregion

        #region Public Methods

        public void RemoveCommand()
        {
            CommandManager.RemoveRaiseCanExecuteChangedAction(RaiseCanExecuteChangedAction);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        #endregion

        #region ICommand Members

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => _canExecute != null || _canExecute();
        public void Execute(object parameter)
        {
            _execute();
            CommandManager.RefreshCommandStates();
        }

        #endregion
    }
}
