using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Photobooth.View
{
    /// <summary>
    /// Logique d'interaction pour UC_Photo.xaml
    /// </summary>
    public partial class UC_Photo : UserControl
    {
        DispatcherTimer timer = new DispatcherTimer();
        int timeLeft = 5;

        public UC_Photo()
        {
            InitializeComponent();
            DispatcherTimerSample();
        }
        public void DispatcherTimerSample()
        {
            InitializeComponent();
            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            lb_Timer.Content = timeLeft.ToString();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //perform these actions at the interval set in the properties.
            lb_Timer.Content = timeLeft.ToString();
            timeLeft -= 1;

            if (timeLeft < 0)
            {
                timer.Stop();
            }
        }
    }
}
