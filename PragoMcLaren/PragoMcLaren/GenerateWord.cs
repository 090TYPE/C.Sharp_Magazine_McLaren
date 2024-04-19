using System;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Office.Interop.Word;

namespace PragoMcLaren
{
    internal class GenerateWord
    {
        private readonly McLarenEntities1 _dbContext;

        public GenerateWord(McLarenEntities1 dbContext)
        {
            _dbContext = dbContext;
        }

        public void GenerateDocumentFromCarData()
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(desktopPath, "Автомобили.docx");
            // Получение данных из таблицы "Автомобили"
            var cars = _dbContext.Автомобили.ToList();

            // Создание нового Word-документа
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();

            // Добавление заголовка
            var paragraph = doc.Paragraphs.Add();
            paragraph.Range.Text = "Список автомобилей";
            paragraph.Range.InsertParagraphAfter();

            // Добавление информации об автомобилях
            foreach (var car in cars)
            {
                paragraph = doc.Paragraphs.Add();
                paragraph.Range.Text = $"Модель: {car.Модель}, Год: {car.Год}, Цвет: {car.Цвет}, Мощность: {car.Мощность}, Цена: {car.Цена}";
                paragraph.Range.InsertParagraphAfter();
            }

            // Сохранение документа
            doc.SaveAs2(filePath);
            doc.Close();

            // Закрытие приложения Word
            wordApp.Quit();
        }
    }
}