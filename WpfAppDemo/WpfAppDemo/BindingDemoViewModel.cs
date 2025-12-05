using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppDemo
{
    public class BindingDemoViewModel
    {
        public BindingDemoViewModel()
        {
            BindingDemoMyCommand = new BindingDemoMyCommand(Show);
        }
        public BindingDemoMyCommand BindingDemoMyCommand { get; set; }
        public void Show()
        {
            MessageBox.Show("点击了按钮");
        }
    }
}
