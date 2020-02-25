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

namespace 直男癌
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.Topmost = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("关不上的哦！");
            e.Cancel = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckPSW();
        }

        private void PSW_GotFocus(object sender, RoutedEventArgs e)
        {
            PSW.Text = "";
        }
        private void CheckPSW()
        {
            if (PSW.Text.Trim() == "mimanicai")
            {
                MessageBox.Show("Congratulation!");
                System.Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("别试了，联系我要密码吧~");
            }
        }

        private void PSW_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                CheckPSW();
                PSW.Text = "";
            }
        }
    }
}
