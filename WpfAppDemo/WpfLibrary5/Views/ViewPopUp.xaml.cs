using DryIoc;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLibrary5.Event;

namespace WpfLibrary5.Views
{
    /// <summary>
    /// ViewPopUp.xaml 的交互逻辑
    /// </summary>
    public partial class ViewPopUp : UserControl
    {
        private readonly IEventAggregator eventAggregator;

        public ViewPopUp(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            this.eventAggregator = eventAggregator;
            eventAggregator.GetEvent<MessageEvent>().Subscribe(NewMes);
        }

        private void NewMes(String message)
        {
            MessageBox.Show($"收到：{message}");
            eventAggregator.GetEvent<MessageEvent>().Unsubscribe(NewMes); //取消订阅
        }
    }
}
