using LibraryApp.Model;
using System.Linq;
using System.Windows;

namespace LibraryApp.View
{
    public partial class Books : Window
    {
        private Library _library;
        private Book _selectedBook;
        private Users _usersList;


        public Books(Window mainWindow, Library library, Users users)
        {
            _library = library;
            _usersList = users;
            Owner = mainWindow;
            InitializeComponent();
        
            foreach (var booklisting in _library.Books.Select(book => new ItemListing(book)))
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
            _selectedBook = _library.GetBook(index);
            var bookDetails = new BookDetails(this, _selectedBook);
            bookDetails.ShowDialog();
        }
    }
}
