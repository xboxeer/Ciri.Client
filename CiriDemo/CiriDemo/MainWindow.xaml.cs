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

namespace CiriDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string userName = "Elendil Zheng";
        public MainWindow()
        {
            InitializeComponent();
            this.TBCiriChat.Visibility = Visibility.Hidden;
            this.TBMyChat.Visibility = Visibility.Hidden;
            this.TBMyChat.KeyDown += TBMyChat_KeyDown;
            this.TBMyChat.KeyUp += TBMyChat_KeyUp;
            
        }

        void TBMyChat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                this.TBCiriChat.Visibility = Visibility.Visible;
                var feedBack = new StringBuilder();
                //feedBack.Append(string.Format("{0}:{1}", userName, this.TBMyChat.Content.ToString()));
                feedBack.AppendLine();
                feedBack.Append("Ciri:Hello");
                this.TBCiriChat.Content = feedBack.ToString();
                this.TBCiriChat.UpdateLayout();
            }
        }

        void TBMyChat_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Enter)
            //{

            //    this.TBCiriChat.Visibility = Visibility.Visible;
            //    var feedBack = new StringBuilder();
            //    feedBack.Append(string.Format("{0}:{1}", userName, this.TBMyChat.Content.ToString()));
            //    feedBack.AppendLine();
            //    feedBack.Append("Ciri:Hello");
            //    this.TBCiriChat.Content = feedBack.ToString();
            //    this.TBCiriChat.UpdateLayout();
            //}
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            App.Current.Shutdown();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void IMGChat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.TBMyChat.Visibility = Visibility.Visible;
            this.CiriMenu.Opacity=1;
        }

        private void border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.TBMyChat.Visibility = Visibility.Hidden;
            this.CiriMenu.Opacity = 0.2;
        }

        private void TBCborder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.TBCiriChat.Visibility = Visibility.Hidden;
        }

        private void TBMyChatBox_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Enter)
            //{

            //    this.TBCiriChat.Visibility = Visibility.Visible;
            //    var feedBack = new StringBuilder();
            //    feedBack.Append(string.Format("{0}:{1}", userName, this.TBMyChat.Content.ToString()));
            //    feedBack.AppendLine();
            //    feedBack.Append("Ciri:Hello");
            //    this.TBCiriChat.Content = feedBack.ToString();
            //    this.TBCiriChat.UpdateLayout();
            //}
        }



    }
}
