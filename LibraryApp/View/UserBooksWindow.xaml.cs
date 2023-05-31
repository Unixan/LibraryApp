using System.Collections.ObjectModel;
using System.Windows;
using LibraryApp.Model;
using LibraryApp.ViewModel;

namespace LibraryApp.View
{
    public partial class UserBooksWindow : Window
    {
        private Window _window;
        private ObservableCollection<UserBookItem> _loanedBooks;
        private User _user;
        private ObservableCollection<Book> _library;

        public UserBooksWindow(Window window, User user, ObservableCollection<Book> library)
        {
            Owner = window;
            _window = window;
            _loanedBooks = user.LoanedBooks;
            _user = user;
            _library = library;
            InitializeComponent();
            var vm = new UserBooksWindowViewModel(this, _user, _loanedBooks, _library );
            DataContext = vm;
        }
    }
}
