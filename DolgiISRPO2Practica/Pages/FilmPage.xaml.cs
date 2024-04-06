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
    /// Логика взаимодействия для FilmPage.xaml
    /// </summary>
    public partial class FilmPage : Page
    {
        public FilmPage()
        {
            InitializeComponent();
            DGFilm.ItemsSource = App.DB.Movies.ToList();
            
        }

        private void BRedaction_Click(object sender, RoutedEventArgs e)
        {
            var selectedFilm = DGFilm.SelectedItems as Movies;
            if (selectedFilm == null)
            {
                MessageBox.Show("Выбрать фильм");
                return;
            }
            NavigationService.Navigate(new AddFilmPage(selectedFilm));
        }

        private void BDeleted_Click(object sender, RoutedEventArgs e)
        {
            var deletedFilm =DGFilm.SelectedItem as Movies;
            if (deletedFilm != null)
            {
                App.DB.Movies.Remove(deletedFilm);
                App.DB.SaveChanges();
                DGFilm.ItemsSource = App.DB.Movies.ToList();
            }
            
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddFilmPage(new Movies()));
        }

        private void TBBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGFilm.ItemsSource = App.DB.Movies.ToList();
        }
    }
}
