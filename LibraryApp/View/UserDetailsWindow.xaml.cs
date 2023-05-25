using System.Windows;
using LibraryApp.Model;
using LibraryApp.ViewModel;
using Microsoft.VisualBasic;

namespace LibraryApp.View
{
    public partial class UserDetailsWindow : Window
    {
    private User _user;
        public UserDetailsWindow(Window owner, User user)
        {
            _user = user;
            Owner = owner;
            var vm = new UserDetailWindowViewModel(_user);
            DataContext = vm;
            InitializeComponent();
        }
        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonLoancard_OnClick(object sender, RoutedEventArgs e)
        {
            var LoanCardWindow = new LoanCardWindow(this, _user);
            LoanCardWindow.ShowDialog();
        }
    }
}
