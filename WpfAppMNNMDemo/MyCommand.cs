using System;
using System.Windows.Input;

namespace WpfAppMNNMDemo
{
    public class MyCommand : ICommand
    {
        public Action Action { get; set; }
        public event EventHandler CanExecuteChanged;
        public MyCommand(Action action)
        {
            Action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Action();
        }
    }
}