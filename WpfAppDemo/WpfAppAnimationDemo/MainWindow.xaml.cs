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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppAnimationDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTestDoubleAnimation_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            //doubleAnimation.From = btnTestDoubleAnimation.Width;  /*起始值*/
            //doubleAnimation.To = btnTestDoubleAnimation.Width - 50; /*结束值*/
            doubleAnimation.By = -50;
            doubleAnimation.Duration = TimeSpan.FromSeconds(5); /*时间*/
            doubleAnimation.AutoReverse = true; //相反
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;  //重复

            BtnTestDoubleAnimation.BeginAnimation(Button.WidthProperty, doubleAnimation);
        }

        //1.线性动画
        //线性动画（From/To/By）
        //    DoubleAnimation - 用于双精度值的动画
        //    ColorAnimation - 用于颜色的动画
        //    PointAnimation - 用于点的动画
        //    ThicknessAnimation - 用于边距、边框等的动画
        //2.关键帧动画
        //    DoubleAnimationUsingKeyFrames
        //    ColorAnimationUsingKeyFrames
        //    PointAnimationUsingKeyFrames
        //    ObjectAnimationUsingKeyFrames（离散值）
        //3.路径动画
        //    DoubleAnimationUsingPath - 沿路径移动并改变双精度值
        //    PointAnimationUsingPath - 沿路径移动点
        //    MatrixAnimationUsingPath - 沿路径移动并应用矩阵变换

    }
}
