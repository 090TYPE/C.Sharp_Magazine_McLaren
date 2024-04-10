using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        private McLarenEntities1 db;
        private byte[] imageData;
        public AddProduct()
        {
            InitializeComponent();
            db = new McLarenEntities1(); // Инициализация контекста базы данных
        }

        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {
            // Открыть диалоговое окно выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                // Прочитать данные изображения из выбранного файла
                byte[] imageData = File.ReadAllBytes(openFileDialog.FileName);

                // Отобразить изображение на форме (не обязательно, если не нужно)
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = new MemoryStream(imageData);
                bitmap.EndInit();
                imgProduct.Source = bitmap; // imgProduct - это элемент Image на вашей форме
                if (txtColor.Text != null && txtEngineType.Text != null && txtModel.Text != null && txtPower.Text != null && txtPrice.Text != null && txtYear.Text != null)
                {
                    var автомобиль = new Автомобили
                    {
                        Модель = txtModel.Text,
                        Год = int.Parse(txtYear.Text),
                        Цвет = txtColor.Text,
                        ТипДвигателя = txtEngineType.Text,
                        Мощность = int.Parse(txtPower.Text),
                        Цена = decimal.Parse(txtPrice.Text),
                        Изображение = imageData
                    };

                    // Добавить объект в коллекцию и сохранить изменения в базе данных
                    db.Автомобили.Add(автомобиль);
                    db.SaveChanges();
                    MessageBox.Show("Товар добавлен");
                }
                else
                {
                    MessageBox.Show("Все поля обязательны к заполнению");
                }
            }
        }
    }

}
