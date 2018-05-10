using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace TaimerApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer;
        private TimeSpan delay;
        private TimeSpan interval;
        public MainWindow()
        {
            InitializeComponent();
            timer = null;
        }

        public void ShowMessage(object text)
        {
            TextBox message = (TextBox)text;
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                (ThreadStart)delegate ()
                {
                    if (message.Text == "")
                    {
                        MessageBox.Show("Что то надо было!");
                    }
                    else
                    {
                        MessageBox.Show(message.Text);
                    }
                }
            );


        }

        private void onButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (timer != null)
                {



                    MessageBox.Show("Вы не удалили текущее напоминание");
                }
                else
                {
                    delay = new TimeSpan(int.Parse(startDay.Text), int.Parse(startMin.Text), int.Parse(startSec.Text));
                    interval = new TimeSpan(int.Parse(intervalDay.Text), int.Parse(intervalMin.Text), int.Parse(intervalSec.Text));
                    timer = new Timer(new TimerCallback(ShowMessage), messageRemember, delay, interval);
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели данные неверно");
            }
        }

        private void offButtonClick(object sender, RoutedEventArgs e)
        {
            if (timer == null)
            {
                MessageBox.Show("Напоминание не установлено");
            }
            else
            {
                timer = null;
            }
        }
    }
}
