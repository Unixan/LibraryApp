using System.Windows;
using LibraryApp.Model;

namespace LibraryApp.View
{
    public partial class LoanCardWindow : Window
    {
        private User _user;
        public LoanCardWindow(Window owner, User user)
        {
            //_user = user;
            //Owner = owner;
            InitializeComponent();
            //Id.Content = _user.Id;
            //Name.Content = _user.GetFullName();
            //LoanCard.Content = _user.GetLoanCardStatus();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonIssueLoanCard_OnClick(object sender, RoutedEventArgs e)
        {
            if (_user.HasLoanCard)
            {
                MessageBox.Show("Bruker har allerede lånekort!");
            }
            else
            {
                _user.IssueLoanCard();
                MessageBox.Show("Lånekort tildelt for 1 år");
                Close();
            }
        }

        private void ButtonRevokeLoanCard_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_user.HasLoanCard)
            {
                MessageBox.Show("Bruker har ikke lånekort!");
            }
            else
            {
                _user.RevokeLoanCard();
                MessageBox.Show("Lånekort inndratt");
                Close();
            }
        }
    }
}
