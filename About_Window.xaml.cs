using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ShutdownTimer
{
    /// <summary>
    /// Interaction logic for About_Window.xaml
    /// </summary>
    public partial class About_Window : Window
    {
        public About_Window()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        // Social networks buttons
        private void Pic_gmail_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("mailto:alexander.ulianov@gmail.com?subject=ShutdownTimer");
        }

        private void Pic_linkedin_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/alexander-ulianov-419761a0/");
        }

        private void Pic_fb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://www.facebook.com/foster117");
        }

        private void Pic_skype_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("skype:ulianov-alexander?chat");
        }
    }
}
