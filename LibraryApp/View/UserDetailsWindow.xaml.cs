using System;
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
            InitializeComponent();
            var vm = new UserDetailWindowViewModel(this, _user);
            DataContext = vm;
            vm.ReloadRequested += vm_ReloadRequested;
        }
        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonLoancard_OnClick(object sender, RoutedEventArgs e)
        {
            var LoanCardWindow = new LoanCardWindow(this, _user);
            LoanCardWindow.ShowDialog();
            ReloadWindow();
        }
        private void vm_ReloadRequested(object? sender, EventArgs e)
        {
            ReloadWindow();
        }

        private void ReloadWindow()
        {
            UserDetailsWindow newWindow = new UserDetailsWindow(Owner, _user);
            Close();
            newWindow.ShowDialog();
        }
    }
}
