using System;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Media;

namespace ShutdownTimer
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        TimeSpan second;
        TimeSpan countdown;
        SoundPlayer player;
        static bool minimizeFlag = false;


        public MainWindow()
        {
            InitializeComponent();
            second = new TimeSpan(0, 0, 1);
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = second;
            
            RegistryChecker regChecker = new RegistryChecker();
            if (!regChecker.CheckIsHibernationOn())
            {
                rb_Hibernate.IsEnabled = false;
                rb_Hibernate.ToolTip = "Hibernate is disabled or not supported";              
            }   
        }


        private void StartCountdown(int hours, int minutes, int seconds)
        {
            progress.Value = 0;
            DisableControls();
            countdown = new TimeSpan(hours, minutes, seconds);
            progress.Maximum = countdown.TotalSeconds;
            timer.Start();
        }

        // Do each second
        public void timer_Tick(object sender, EventArgs e)
        {
            if (countdown.TotalSeconds == 300)
            {
                tbIcon.ShowCustomBalloon(new BalloonFiveMin(this), System.Windows.Controls.Primitives.PopupAnimation.Slide, 10000);
            }
            if (countdown.TotalSeconds != 1)
            {
                countdown -= second;
                if (countdown.TotalHours < 10)
                {
                    tb_hours.Text = "0" + ((int)countdown.TotalHours).ToString();
                }
                else
                {
                    tb_hours.Text = ((int)countdown.TotalHours).ToString();
                }
                if (countdown.Minutes < 10)
                {
                    tb_minutes.Text = "0" + countdown.Minutes.ToString();
                }
                else
                {
                    tb_minutes.Text = countdown.Minutes.ToString();
                }
                if (countdown.Seconds < 10)
                {
                    tb_seconds.Text = "0" + countdown.Seconds.ToString();
                }
                else
                {
                    tb_seconds.Text = countdown.Seconds.ToString();
                }
                toolTipTextBlock.Text = $"{tb_hours.Text} : {tb_minutes.Text} : {tb_seconds.Text}";
                progress.Value++;
            }
            else
            {
                timer.Stop();
                tb_seconds.Text = "00";
                progress.Value++;
                Action action = new Action();
                if ((bool)rb_Shutdown.IsChecked)
                {
                    action.ShutdownOrReboot(false, true);
                }
                if ((bool)rb_Sleep.IsChecked)
                {
                    EnableControls();
                    toolTipTextBlock.Text = "Timer is not running";
                    action.Sleep();
                }
                if ((bool)rb_Hibernate.IsChecked)
                {
                    EnableControls();
                    toolTipTextBlock.Text = "Timer is not running";
                    action.Hibernate();
                }
                if ((bool)rb_Restart.IsChecked)
                {
                    action.ShutdownOrReboot(true, true);
                }
                if ((bool)rb_Lock.IsChecked)
                {
                    EnableControls();
                    toolTipTextBlock.Text = "Timer is not running";
                    action.Lock();
                }
                if ((bool)rb_PlaySound.IsChecked)
                {
                    toolTipTextBlock.Text = "Time is over!";
                    player = new SoundPlayer();
                    player.Stream = Properties.Resources.timerSound;
                    player.PlayLooping();
                }
            }
        }

        private void DisableControls()
        {         
            b_Start.IsEnabled = false;
            tb_hours.IsReadOnly = true;
            tb_hours.Focusable = false;
            tb_minutes.IsReadOnly = true;
            tb_minutes.Focusable = false;
            tb_seconds.IsReadOnly = true;
            tb_seconds.Focusable = false;
        }
        private void EnableControls()
        {
            progress.Value = 0;
            b_Start.IsEnabled = true;
            tb_hours.IsReadOnly = false;
            tb_hours.Focusable = true;
            tb_minutes.IsReadOnly = false;
            tb_minutes.Focusable = true;
            tb_seconds.IsReadOnly = false;
            tb_seconds.Focusable = true;
        }

        private void B_Start_Click(object sender, RoutedEventArgs e)
        {
            progress.Value = 0;
            int hours = Convert.ToInt32(tb_hours.Text);
            int minutes = Convert.ToInt32(tb_minutes.Text);
            int seconds = Convert.ToInt32(tb_seconds.Text);
            if (hours + minutes + seconds != 0)
            {
                StartCountdown(hours, minutes, seconds);
            }
        }

        private void B_Stop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            EnableControls();
            toolTipTextBlock.Text = "Timer is not running";
            tb_hours.Text = "00";
            tb_minutes.Text = "00"; ;
            tb_seconds.Text = "00";
            progress.Value = 0;
            Topmost = false;
            if (player != null)
            {
                player.Stop();
                player = null;
            }
        }

        private void B_0_5hour_Click(object sender, RoutedEventArgs e)
        {
            CheckSound();
            timer.Stop();
            tb_hours.Text = "00";
            tb_minutes.Text = "30";
            tb_seconds.Text = "00";
            StartCountdown(0, 30, 0);
        }

        private void B_1hour_Click(object sender, RoutedEventArgs e)
        {
            CheckSound();
            timer.Stop();
            tb_hours.Text = "01";
            tb_minutes.Text = "00";
            tb_seconds.Text = "00";
            StartCountdown(1, 0, 0);
        }

        private void B_1_5hour_Click(object sender, RoutedEventArgs e)
        {
            CheckSound();
            timer.Stop();
            tb_hours.Text = "01";
            tb_minutes.Text = "30";
            tb_seconds.Text = "00";
            StartCountdown(1, 30, 0);
        }

        private void B_2hour_Click(object sender, RoutedEventArgs e)
        {
            CheckSound();
            timer.Stop();
            tb_hours.Text = "02";
            tb_minutes.Text = "00";
            tb_seconds.Text = "00";
            StartCountdown(2, 0, 0);
        }


        #region INPUT CHECK
        ///////// HOURS text box check

        private void Tb_hours_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_hours.Text != "")
            {
                int hours;
                if (!Int32.TryParse(tb_hours.Text, out hours))
                {
                    tb_hours.Text = "";
                }
            }
        }

        private void Tb_hours_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_hours.Text = "";
        }

        private void Tb_hours_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_hours.Text == "")
            {
                tb_hours.Text = "00";
            }
            else
            {
                if (Convert.ToInt32(tb_hours.Text) < 10)
                {
                    tb_hours.Text = "0" + tb_hours.Text;
                }
            }
        }
        /////////

        ///////// MINUTES text box check
        private void Tb_minutes_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_minutes.Text != "")
            {
                int minutes;
                if (!Int32.TryParse(tb_minutes.Text, out minutes))
                {
                    tb_minutes.Text = "";
                }
             }
        }

        private void Tb_minutes_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_minutes.Text = "";
        }

        private void Tb_minutes_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_minutes.Text == "")
            {
                tb_minutes.Text = "00";
            }
            else
            {
                if (Convert.ToInt32(tb_minutes.Text) < 10)
                {
                    tb_minutes.Text = "0" + tb_minutes.Text;
                }
            }
        }
        /////////

        ///////// SECONDS text box check
        private void Tb_seconds_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_seconds.Text != "")
            {
                int seconds;
                if (!Int32.TryParse(tb_seconds.Text, out seconds))
                {
                    tb_seconds.Text = "";
                }
            }
        }

        private void Tb_seconds_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_seconds.Text = "";
        }

        private void Tb_seconds_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_seconds.Text == "")
            {
                tb_seconds.Text = "00";
            }
            else
            {
                if (Convert.ToInt32(tb_seconds.Text) < 10)
                {
                    tb_seconds.Text = "0" + tb_seconds.Text;
                }
            }
        }
        /////////////////
        #endregion

        private void CheckSound()
        {
            if (player != null)
            {
                player.Stop();
                player = null;
            }
        }

        private void Label_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            About_Window about = new About_Window();
            about.Owner = this;
            about.ShowDialog();
        }

        private void TimerWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (timer.IsEnabled)
            {
               MessageBoxResult result = MessageBox.Show("The timer is running. Are you sure you want to exit the application?", "Warning", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TimerWindow_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
            {
                Topmost = false;
                tbIcon.Visibility = Visibility.Visible;
                this.ShowInTaskbar = false;
                if (minimizeFlag == false)
                {
                    tbIcon.ShowCustomBalloon(new BalloonMinimized(), System.Windows.Controls.Primitives.PopupAnimation.Slide, 2000);
                    minimizeFlag = true;
                }
            }
            if (WindowState == WindowState.Normal)
            {
                tbIcon.Visibility = Visibility.Hidden;
                this.ShowInTaskbar = true;
            }

        }

        private void MExpand_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void MExit_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                this.Activate();
                this.Close();
            }
            else
            {
                Close();
            }
        }

        private void TbIcon_TrayMouseDoubleClick(object sender, RoutedEventArgs e)
        {
            this.Activate();
            this.WindowState = WindowState.Normal;
        }
    }
}
