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

namespace TaimerApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void whenTimeGotFocus(object sender, RoutedEventArgs e)
        {
            whenTime.Text = "";
        }

        public void ShowMessage(object text)
        {
            timer = null;
        }

        private void onButtonClick(object sender, RoutedEventArgs e)
        {
            int res;
            DateTime dres;
            if (int.TryParse(interval.Text, out res) && DateTime.TryParse(whenTime.Text, out dres) && messageRemember.Text.Length >= 1)
            {
                
            }
        }

        private void offButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
