using System.Collections.ObjectModel;
using LibraryApp.Model;
using System.Windows;
using LibraryApp.ViewModel;

namespace LibraryApp.View
{
    public partial class UsersWindow : Window
    {
        private Library _library;
        private User _selectedUser;
        private ObservableCollection<User> _users;
        public UsersWindow(Window mainWindow, Library library, ObservableCollection<User> users)
        {
            _users = users;
            var vm = new UsersWindowViewModel(this, _users);
            DataContext = vm;
            _library = library;
            Owner = mainWindow;
            InitializeComponent();
          
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
    }
}
