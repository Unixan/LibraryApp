using System.Collections.ObjectModel;
using LibraryApp.Model;
using System.Linq;
using System.Windows;

namespace LibraryApp.View
{
    public partial class BooksWindow : Window
    {
        private ObservableCollection<Book> _library;
        private Book _selectedBook;
        private ObservableCollection<User> _usersList;


        public BooksWindow(Window mainWindow, ObservableCollection<Book> library, ObservableCollection<User> users)
        {
            _library = library;
            _usersList = users;
            Owner = mainWindow;
            InitializeComponent();
        
            foreach (var booklisting in _library.Select(book => new BookListing(book)))
            {
                BookList.Items.Add(booklisting);
            }
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ButtonDetails_OnClick(object sender, RoutedEventArgs e)
        {
            var index = BookList.SelectedIndex;
            if (index < 0) return;
            _selectedBook = _library[index];
            var bookDetails = new BookDetailsWindow(this, _selectedBook);
            bookDetails.ShowDialog();
        }
    }
}
