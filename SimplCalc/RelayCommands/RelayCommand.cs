using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimplCalc.RelayCommands
{
    public class RelayCommand: ICommand
    {
        private Action<string> execute;

        //private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<string> execute)
        {
            this.execute = execute;
            //this.canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            //return canExecute == null || canExecute(parameter);
            return true;
        }

        public void Execute(object parameter)
        {

             execute(parameter.ToString());

            
        }
    }
}
