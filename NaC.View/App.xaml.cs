using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NaC.ViewModel;

namespace NaC.ViewModel
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private StartViewModel startVM;
        protected override void OnStartup(StartupEventArgs e)
        {
            startVM = new StartViewModel(new View.MainWindow());
            base.OnStartup(e);
        }
    }
}
