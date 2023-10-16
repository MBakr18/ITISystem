using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ITISystem.ViewModel.Commands
{
    public class CustomCommand : ICommand
    {
        public Action<object> action { get; set; }
        public Predicate<object> canExecute { get; set; }

        public CustomCommand(Action<object> action, Predicate<object> canExecute)
        {
            this.action = action;

            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute(parameter!);
        }

        public void Execute(object? parameter)
        {
            action(parameter!);
        }
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
