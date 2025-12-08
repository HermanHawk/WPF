using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppDemo
{
    public class BindingDemoMyCommand : ICommand
    {
        Action ActionDemo;
        public BindingDemoMyCommand(Action action)
        {
            ActionDemo = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ActionDemo();
        }
    }
}
