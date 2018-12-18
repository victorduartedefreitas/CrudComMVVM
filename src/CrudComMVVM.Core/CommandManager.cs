using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CrudComMVVM.Core
{
    public static class CommandManager
    {
        #region Local Variables

        private static List<Action> _raiseCanExecuteChangedActions = new List<Action>();

        #endregion

        #region Public Methods

        public static void AddRaiseCanExecuteChangedAction(ref Action action)
        {
            _raiseCanExecuteChangedActions.Add(action);
        }

        public static void RemoveRaiseCanExecuteChangedAction(Action action)
        {
            _raiseCanExecuteChangedActions.Remove(action);
        }

        public static void AssignOnPropertyChanged(ref PropertyChangedEventHandler eventHandler)
        {
            eventHandler += OnPropertyChanged;
        }

        public static void RefreshCommandStates()
        {
            foreach (var action in _raiseCanExecuteChangedActions)
                action?.Invoke();
        }

        #endregion

        #region Private Methods

        private static void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "CanExecute")
                RefreshCommandStates();
        }

        #endregion
    }
}
