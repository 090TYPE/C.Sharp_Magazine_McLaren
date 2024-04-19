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
    /// Логика взаимодействия для UploadingAReport.xaml
    /// </summary>
    public partial class UploadingAReport : Window
    {
        public UploadingAReport()
        {
            InitializeComponent();
        }
        private void Word_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Создание экземпляра GenerateWord с передачей контекста базы данных
                var wordGenerator = new GenerateWord(new McLarenEntities1());

                // Выполнение генерации Word-документа
                wordGenerator.GenerateDocumentFromCarData();

                MessageBox.Show("Word-документ успешно сгенерирован и сохранен на рабочем столе.", "Генерация завершена", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при генерации Word-документа: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Exele_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение пути к рабочему столу пользователя
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Создание экземпляра GenerateExcel с передачей контекста базы данных
                var excelGenerator = new GenerateExcel(new McLarenEntities1());

                // Выполнение генерации Excel-файла и сохранение на рабочем столе
                excelGenerator.GenerateExcelFromCarData(desktopPath);

                MessageBox.Show("Excel-файл успешно сгенерирован и сохранен на рабочем столе.", "Генерация завершена", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при генерации Excel-файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
