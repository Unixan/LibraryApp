using System.Windows;
using LibraryApp.Model;

namespace LibraryApp.View
{
    public partial class UsersView : Window
    {
    private Library _library;
    private Users _usersList;
        public UsersView(Window mainWindow, Library library, Users usersList)
        {
            _library = library;
            _usersList = usersList;
            Owner = mainWindow;
            InitializeComponent();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
