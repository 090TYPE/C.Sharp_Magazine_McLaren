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

namespace PragoMcLaren
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void DataBase(object sender, RoutedEventArgs e)
        {
            DataBase DBwindow = new DataBase();
            DBwindow.Show();
        }
        private void AddProduct(object sender, RoutedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }
        private void Otchet(object sender, RoutedEventArgs e)
        {
            UploadingAReport uploadingAReport = new UploadingAReport();
            uploadingAReport.Show();
        }
    }
}
