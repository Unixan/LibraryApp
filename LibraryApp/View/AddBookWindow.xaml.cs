using System.Collections.ObjectModel;
using System.Windows;
using LibraryApp.Model;
using LibraryApp.ViewModel;

namespace LibraryApp.View
{
    public partial class AddBookWindow : Window
    {
        private ObservableCollection<Book> _books;
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _author;
        private string _description;
        private string _genre;
        public AddBookWindow(Window window, ObservableCollection<Book> books)
        {
            Owner = window;
            InitializeComponent();
            var vm = new AddBookWindowViewModel(_books);
        }
    }
}
