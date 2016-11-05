using System;
using System.Windows.Input;

namespace SniffIdler
{
    /// <summary>
    /// Command to start KC operation
    /// </summary>
    class SniffCommand : ICommand
    {
        Action _execute;

        public SniffCommand(Action executeMethod)
        {
            _execute = executeMethod;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;


        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
