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
    public class Car
    {
        public string Model { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// Логика взаимодействия для CARS.xaml
    /// </summary>
    public partial class CARS : Window
    {
        public List<Car> Cars { get; set; }
        public CARS()
        {
            InitializeComponent();

            Cars = new List<Car>
            {
                new Car { Model = "McLaren 720S", ImagePath = "Images/720S.jpg", Description = "Спортивный автомобиль среднего класса." },
                new Car { Model = "McLaren P1", ImagePath = "Images/P1.jpg", Description = "Гибридный суперкар с ограниченным выпуском." },
                // Добавьте другие модели по аналогии
            };

            this.DataContext = this;
        }
     

    }
}
