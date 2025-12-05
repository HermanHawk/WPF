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
    /// DataTemplateDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemplateDemo : Window
    {
        public DataTemplateDemo()
        {
            InitializeComponent();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Items.Add(new ListBoxItem()
            //    {
            //        Content = new TextBlock()
            //        {
            //            Text = i.ToString()
            //        }
            //    });
            //}
            List<Color> test = new List<Color>();
            test.Add(new Color() { Code = "#FFB6C1", Name = "浅粉红" });
            test.Add(new Color() { Code = "#FFCOCB", Name = "粉红" });
            test.Add(new Color() { Code = "#DC143C", Name = "深红(猩红)" });
            test.Add(new Color() { Code = "#FFFOF5", Name = "淡紫红" });
            grid.ItemsSource = test;
        }
    }

    public class Color
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

}
