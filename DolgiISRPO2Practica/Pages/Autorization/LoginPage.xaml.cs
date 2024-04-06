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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DolgiISRPO2Practica.Models;
using DolgiISRPO2Practica.Pages;

namespace DolgiISRPO2Practica.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TBLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = BLogin.Text;
            string password = BPassword.Text;

            var loggedUser = App.DB.User.FirstOrDefault(X => X.Login == login && X.Password == password);
            if (loggedUser == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            App.LoggedUser =loggedUser;
            if (loggedUser.Id == 1)
            {
                NavigationService.Navigate(new MenuPage());
                MessageBox.Show("Добро Пожаловать!");

            }
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
