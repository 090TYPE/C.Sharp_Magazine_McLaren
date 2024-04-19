using System;
using System.IO;
using System.Linq;
using Microsoft.Office.Interop.Excel;

namespace PragoMcLaren
{
    internal class GenerateExcel
    {
        private readonly McLarenEntities1 _dbContext;

        public GenerateExcel(McLarenEntities1 dbContext)
        {
            _dbContext = dbContext;
        }

        public void GenerateExcelFromCarData(string directoryPath)
        {
            // Получение пути к рабочему столу пользователя
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Создание пути к файлу "Автомобили.xlsx" на рабочем столе
            var filePath = Path.Combine(directoryPath, "Автомобили.xlsx");

            // Получение данных из таблицы "Автомобили"
            var cars = _dbContext.Автомобили.ToList();

            // Создание нового экземпляра приложения Excel
            var excelApp = new Application();
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Worksheet)workbook.Worksheets[1];

            // Запись заголовка
            worksheet.Cells[1, 1] = "Модель";
            worksheet.Cells[1, 2] = "Год";
            worksheet.Cells[1, 3] = "Цвет";
            worksheet.Cells[1, 4] = "Мощность";
            worksheet.Cells[1, 5] = "Цена";

            // Запись данных об автомобилях
            int row = 2;
            foreach (var car in cars)
            {
                worksheet.Cells[row, 1] = car.Модель;
                worksheet.Cells[row, 2] = car.Год;
                worksheet.Cells[row, 3] = car.Цвет;
                worksheet.Cells[row, 4] = car.Мощность;
                worksheet.Cells[row, 5] = car.Цена;
                row++;
            }

            // Сохранение книги Excel
            workbook.SaveAs(filePath);
            workbook.Close();

            // Закрытие приложения Excel
            excelApp.Quit();
        }
    }
}