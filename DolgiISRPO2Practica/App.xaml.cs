using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DolgiISRPO2Practica.Models;
using DolgiISRPO2Practica.Pages;

namespace DolgiISRPO2Practica
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MoviesEntities DB = new MoviesEntities();
        public static User LoggedUser;
    }
}
