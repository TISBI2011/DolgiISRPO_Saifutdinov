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

namespace DolgiISRPO2Practica.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddJanorPage.xaml
    /// </summary>
    public partial class AddJanorPage : Page
    {
        Janor contextJanor;
        public AddJanorPage(Janor janor)
        {
            InitializeComponent();
            contextJanor = janor;
            DataContext = contextJanor;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextJanor.Id ==0)
            {
                App.DB.Janor.Add(contextJanor);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }
        
        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
