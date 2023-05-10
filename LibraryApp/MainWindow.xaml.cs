using System.Windows;
using System.Windows.Input;
using LibraryApp.View;

namespace LibraryApp
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var booksWindow = new Books(this);
            booksWindow.ShowDialog();

        }

        private void ButtonQuit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
