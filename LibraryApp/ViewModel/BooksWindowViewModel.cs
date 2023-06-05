using System.Collections.ObjectModel;
using System.Windows;
using LibraryApp.Model;
using LibraryApp.MVVM;
using LibraryApp.View;

namespace LibraryApp.ViewModel;

public class BooksWindowViewModel : ViewModelBase
{
    public RelayCommand AddBookCommand => new RelayCommand(execute => AddBook());
    public RelayCommand DeleteBookCommand => new RelayCommand(execute => DeleteSelectedBook(), canExecute => SelectedBook != null);
    public RelayCommand BookDetailsCommand => new RelayCommand(execute => OpenBookDetailsWindow(), canExecute => SelectedBook != null);
    public RelayCommand CloseCommand => new RelayCommand(execute => CloseWindow(_window));


    private Window _window;
    public ObservableCollection<Book> Books { get; set; }
    
    private Book _selectedBook;
    public Book SelectedBook
    {
        get { return _selectedBook; }
        set
        {
            _selectedBook = value; 
            OnPropertyChanged();
        }
    }
    public BooksWindowViewModel(Window window, ObservableCollection<Book> books)
    {
        _window = window;
        Books = books;
    }
    private void OpenBookDetailsWindow()
    {
        var bookDetailsWindow = new BookDetailsWindow(_window, SelectedBook);
        bookDetailsWindow.ShowDialog();
    }
    private void DeleteSelectedBook()
    {
        var choice = MessageBox.Show("Er du sikker?", $"Slette {SelectedBook.Title} permanent?", MessageBoxButton.YesNo);
        if (choice == MessageBoxResult.Yes)
        {
            Books.Remove(SelectedBook);
        }   
    }
    private void AddBook()
    {
        var addBookWindow = new AddBookWindow(_window, Books);
        addBookWindow.ShowDialog();
    }
}