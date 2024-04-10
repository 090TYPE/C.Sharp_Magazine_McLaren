using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для DataBase.xaml
    /// </summary>
    public partial class DataBase : Window
    {
        private McLarenEntities1 db; // Предполагается, что McLarenEntities - это ваш контекст базы данных

        public DataBase()
        {
            InitializeComponent();
            db = new McLarenEntities1(); // Инициализация контекста
            db.Автомобили.Load(); // Загрузка данных
            db.АвтомобилиИЗапчасти.Load();
            db.Запчасти.Load();
            db.Клиенты.Load();
            db.Пользователи.Load();
            db.Продажи.Load();
            db.СервисныеВизиты.Load();
            db.СкладАвтомобилей.Load();
            db.Сотрудники.Load();
            db.ТестДрайвы.Load();
            db.ФинансовыеУсловия.Load();
            DataGrid1.ItemsSource = db.Автомобили.Local;
            DataGrid2.ItemsSource = db.АвтомобилиИЗапчасти.Local;
            DataGrid3.ItemsSource = db.Запчасти.Local;
            DataGrid4.ItemsSource = db.Клиенты.Local;
            DataGrid5.ItemsSource = db.Пользователи.Local;
            DataGrid6.ItemsSource = db.Продажи.Local;
            DataGrid7.ItemsSource = db.СервисныеВизиты.Local;
            DataGrid8.ItemsSource = db.СкладАвтомобилей.Local;
            DataGrid9.ItemsSource = db.Сотрудники.Local;
            DataGrid10.ItemsSource = db.ТестДрайвы.Local;
            DataGrid11.ItemsSource = db.ФинансовыеУсловия.Local;
        }
        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.SaveChanges(); // Сохранение изменений для основного контекста
                MessageBox.Show("Изменения сохранены успешно.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
