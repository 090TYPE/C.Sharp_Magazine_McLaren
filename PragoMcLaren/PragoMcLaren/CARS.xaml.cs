using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace PragoMcLaren
{
    public partial class CARS : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Car> _cars;
        public ObservableCollection<Car> Cars
        {
            get => _cars;
            set
            {
                _cars = value;
                OnPropertyChanged(nameof(Cars));
            }
        }

        private int _selectedRowCount;
        public int SelectedRowCount
        {
            get => _selectedRowCount;
            set
            {
                _selectedRowCount = value;
                OnPropertyChanged(nameof(SelectedRowCount));
                UpdateDisplayedCars(); // Обновляем список машин при изменении количества строк
            }
        }

        public List<int> RowCounts { get; set; } = new List<int> { 3, 6, 12 };

        // Реализация INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CARS()
        {
            InitializeComponent();

            DataContext = this; // Устанавливаем DataContext для привязки данных

            _cars = new ObservableCollection<Car>(); // Инициализация пустой коллекцией

            LoadCars();
        }

        private void LoadCars()
        {
            using (var context = new McLarenEntities1())
            {
                try
                {
                    var carsQuery = context.Автомобили
                                           .Select(car => new Car
                                           {
                                               Модель = car.Модель,
                                               ImagePath = "Resources/" + car.Модель.ToLower() + ".jpg",
                                               Description = car.Модель + " - " + car.ТипДвигателя + " с мощностью " + car.Мощность.ToString(),
                                               Год = car.Год,
                                               Цвет = car.Цвет,
                                               ТипДвигателя = car.ТипДвигателя,
                                               Мощность = car.Мощность,
                                               Цена = car.Цена
                                           }).ToList();

                    Cars = new ObservableCollection<Car>(carsQuery.Take(SelectedRowCount));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при получении данных: " + ex.Message);
                }
            }
        }

        private void UpdateDisplayedCars()
        {
            // Этот метод должен быть изменен для извлечения машин на основе нового количества строк
            // Для простоты он сейчас просто сбрасывает список машин, чтобы вызвать обновление UI
            LoadCars(); // Перезагрузить или обновить машины в соответствии с новым SelectedRowCount
        }

        private void RowCountComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Фактическая логика обработки изменения выбора уже управляется через привязку и сеттер свойства
        }
    }

    // Убедитесь, что ваш класс Car соответствует ожиданиям
    public class Car
    {
        public string Модель { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int? Год { get; set; }
        public string Цвет { get; set; }
        public string ТипДвигателя { get; set; }
        public int? Мощность { get; set; }
        public decimal? Цена { get; set; }
    }
}
