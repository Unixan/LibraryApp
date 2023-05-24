using System.Windows;
using LibraryApp.Model;

namespace LibraryApp.View
{
    public partial class UserDetails : Window
    {
    private User _user;
        public UserDetails(Window owner, User user)
        {
            _user = user;
            Owner = owner;
            InitializeComponent();
            Name.Text = user.GetFullName();
            Address.Text = user.Address;
            LoanCard.Text = _user.GetLoanCardStatus();
            
        }

        private void PopulateLoanedBooksList()
        {
            foreach (var book in _user.LoanedBooks)
            {

            }
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
