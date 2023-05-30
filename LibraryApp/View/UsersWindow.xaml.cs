using System.Collections.ObjectModel;
using LibraryApp.Model;
using System.Windows;
using LibraryApp.ViewModel;
using System;

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
            InitializeComponent();
            var vm = new UsersWindowViewModel(this, _users);
            DataContext = vm;
            _library = library;
            Owner = mainWindow;
            vm.ReloadRequested += vm_ReloadRequested;

        }
        private void vm_ReloadRequested(object? sender, EventArgs e)
        {
            ReloadWindow();
        }
        private void ReloadWindow()
        {
            UsersWindow newWindow = new UsersWindow(Owner, _library, _users);
            Close();
            newWindow.ShowDialog();
        }
    }
}
