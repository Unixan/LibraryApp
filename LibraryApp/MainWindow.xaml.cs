using System.Windows;
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
    }
}
