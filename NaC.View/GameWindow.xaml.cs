using System;
using System.Windows;
using System.Windows.Controls;
using NaC.ViewModel;
using NaC.ViewModel.Views;

namespace NaC.View
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window, IGameView
    {

        public event EventHandler<FieldButtonEventArgs> FieldButtonClicked;

        public GameWindow()
        {
            InitializeComponent();
            this.Hide();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Click += FieldBtn_Click;

                    Set(i, j, btn);
                }
            }
        }

        private void FieldBtn_Click(Object sender, RoutedEventArgs e)
        {
            if (!(sender is UIElement)) throw new ArgumentException("sender is nit UIElement");

            FieldButtonClicked?.Invoke(sender, 
                new FieldButtonEventArgs(
                    Grid.GetRow((UIElement)sender), 
                    Grid.GetColumn((UIElement)sender)
                    ));
        }

        internal UIElement FindElement(Int32 row, Int32 column)
        {
            if (!(row >= 0 && row <= 2 && column >= 0 && column <= 2)) throw new ArgumentOutOfRangeException("row or column");

            foreach (UIElement element in GameField.Children)
                if (Grid.GetRow(element) == row && Grid.GetColumn(element) == column)
                    return element;
            return null;
        }

        internal void Set(Int32 row, Int32 column, UIElement elem)
        {
            UIElement lastElement = FindElement(row, column);

            if (lastElement != null) 
                GameField.Children.Remove(lastElement);

            GameField.Children.Add(elem);
            Grid.SetRow(elem, row);
            Grid.SetColumn(elem, column);
        }

        public void Set(Int32 row, Int32 column, VMCell elem)
        {
            switch (elem)
            {
                case VMCell.Empty:
                    Button btn = new Button();
                    btn.Click += FieldBtn_Click;
                    Set(row, column, btn);
                    break;
                case VMCell.Cross:
                    Set(row, column, new Label(){Content = "X"});
                    break;
                case VMCell.Nought:
                    Set(row, column, new Label(){Content = "O"});
                    break;
                default: break;
            }
        }

        public void GameEnd(VMCell winner)
        {
            MessageBox.Show("Winner is " + winner.ToString());
            this.Close();
        }
    }
}
