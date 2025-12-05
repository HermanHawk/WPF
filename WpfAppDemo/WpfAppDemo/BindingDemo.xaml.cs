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
using System.Windows.Shapes;

namespace WpfAppDemo
{
    /// <summary>
    /// BindingDemo.xaml 的交互逻辑
    /// </summary>
    public partial class BindingDemo : Window
    {
        public BindingDemo()
        {
            InitializeComponent();
            //this.DataContext = new BindingDemoTest() { Name = "Hello WPF Binding!" };
            this.DataContext = new BindingDemoViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("点击了按钮");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    textbox1.Text = slider.Value.ToString();
        //    textbox2.Text = slider.Value.ToString();
        //    textbox3.Text = slider.Value.ToString();
        //}

        //private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (double.TryParse(textbox1.Text, out double value))
        //        slider.Value = value;
        //}
    }
}
