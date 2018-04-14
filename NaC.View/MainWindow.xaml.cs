using System;
using System.Windows;
using System.Windows.Controls;
using NaC.ViewModel;
using NaC.ViewModel.EventArgs;
using NaC.ViewModel.Views;

namespace NaC.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IStartView
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Hide();
        }

        public event EventHandler<NewGameEventArgs> StartGameClicked;

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            if (((Button) sender).Name == "Single")
            {
                StartGameClicked?.Invoke(this, new NewGameEventArgs(GameType.Easy, new GameWindow()));
                MessageBox.Show("Писать AI мне лень, следовательно, только простой, только easycore!");
            }
            else if (((Button) sender).Name == "Multy")
                MessageBox.Show("Мне лень!");
                //StartGameClicked?.Invoke(this, new NewGameEventArgs(GameType.MultiPlayer, new GameWindow()));
        }
    }
}
