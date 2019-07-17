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

namespace ShutdownTimer
{
    /// <summary>
    /// Interaction logic for BalloonFiveMin.xaml
    /// </summary>
    public partial class BalloonFiveMin : UserControl
    {
        MainWindow mw;
        public BalloonFiveMin(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            mw.Activate();
            mw.Topmost = true;
            mw.WindowState = WindowState.Normal;

        }
    }
}
