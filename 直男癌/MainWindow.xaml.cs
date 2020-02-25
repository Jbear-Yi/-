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

namespace 直男癌
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Left = 750;
            this.Top = 300;
            this.Topmost = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("好的，请转给我的微信，谢谢");
            MessageBox.Show("你以为不转账就能关掉吗？");
            this.Hide();
            Window1 Window1 = new Window1();
            Window1.Show();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random ran = new Random();
            int n = ran.Next(-500, 500);
            int m = ran.Next(-500, 500);
            this.Left = System.Math.Abs((this.Left+n)% (1500 - 254));
            this.Top = System.Math.Abs((this.Top + m) % (700 - 107.635));
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("别想关掉！");
            e.Cancel = true;
        }
    }
}
