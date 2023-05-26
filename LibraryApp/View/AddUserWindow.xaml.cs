using System.Collections.ObjectModel;
using System.Windows;
using LibraryApp.Model;
using LibraryApp.ViewModel;

namespace LibraryApp.View
{
    public partial class AddUserWindow : Window
    {
        private Window Window;
        public ObservableCollection<User> Users { get; set; }
        public AddUserWindow(Window window, ObservableCollection<User> users)
        {
            Users = users;
            Window = window;
            Owner = Window;
            var vm = new AddUserWindowViewModel(Window, Users);
            DataContext = vm;
            InitializeComponent();
        }
    }
}
