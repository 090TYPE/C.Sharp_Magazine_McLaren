using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace PragoMcLaren
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void KAB(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        private void INF(object sender, RoutedEventArgs e)
        {
            INF inf = new INF();
            inf.Show();
        }
        private void POKUPKA(object sender, RoutedEventArgs e)
        {
            CARS cars = new CARS();
            cars.Show();
        }

        private void Test_Drive(object sender, RoutedEventArgs e)
        {

        }
        private void AdmPan(object sender, RoutedEventArgs e)
        {
            PasswordDialog dialog = new PasswordDialog();
            dialog.Show();
        }
    }
}
