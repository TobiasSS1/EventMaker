using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventMaker.Common
{
    class RelayCommand : ICommand
    {
        private readonly Func<bool> _canExecute;
        public event EventHandler CanExecuteChanged;
        private readonly Action _execution;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execution();
        }

        public RelayCommand(Action _execution)
        {
            this._execution = _execution;
        }
    }
}
