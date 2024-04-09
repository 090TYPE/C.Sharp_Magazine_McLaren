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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password = PasswordTB.Text.Trim();
            string confirmPassword = ConfirmPasswordTB.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароль и подтверждение пароля не совпадают!");
                return;
            }

            using (var context = new McLarenEntities1())
            {
                var existingUser = context.Пользователи.FirstOrDefault(u => u.Логин == login);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }

                var newUser = new Пользователи
                {
                    Логин = login,
                    Пароль = password
                };

                context.Пользователи.Add(newUser);
                context.SaveChanges();
            }

            MessageBox.Show("Пользователь успешно зарегистрирован!");
            LoginTB.Clear();
            PasswordTB.Clear();
            ConfirmPasswordTB.Clear();
        }
        private void Exit_Button_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
