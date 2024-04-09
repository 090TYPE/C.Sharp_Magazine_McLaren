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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    /// 
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Vhod_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TxtLogin.Text.Trim();
            string password = TxtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            try
            {
                if (Proverka(login, password))
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    TxtLogin.Clear();
                    TxtPassword.Clear();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка авторизации: " + ex.Message);
            }

        }

        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();

        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




        public bool Proverka(string login, string password)
        {
            try
            {
                using (var context = new McLarenEntities1())
                {
                    var пользователь = context.Пользователи.FirstOrDefault(u => u.Логин == login && u.Пароль == password);
                    return пользователь != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обращении к базе данных: " + ex.Message);
                return false;
            }
        }
    }
}
