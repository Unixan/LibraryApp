using LibraryApp.Model;
using LibraryApp.MVVM;
using System.Collections.ObjectModel;
using System.Windows;

namespace LibraryApp.ViewModel;

public class UserBooksWindowViewModel : ViewModelBase
{
    public RelayCommand CancelCommand => new RelayCommand(execute => CloseWindow(_window));
    private Window _window;
    private ObservableCollection<UserBookItem> _loanedBooks;
    private ObservableCollection<UserBookItem> _tempLoanedBooks;


    public ObservableCollection<UserBookItem> TempLoanedBooks
    {
        get { return _tempLoanedBooks; }
        set
        {
            _tempLoanedBooks = value;
            OnPropertyChanged();
        }
    }

    private ObservableCollection<Book> _libraryBooks;
    private ObservableCollection<Book> _tempLibraryBooks;

    public ObservableCollection<Book> TempLibraryBooks
    {
        get { return _tempLibraryBooks; }
        set
        {
            _tempLibraryBooks = value;
            OnPropertyChanged();
        }
    }
    private string _userName;
    public string UserName
    {
        get { return _userName; }
        set
        {
            _userName = value;
            OnPropertyChanged();
        }
    }

    public UserBooksWindowViewModel(Window window, User user, ObservableCollection<UserBookItem> loanedBooks, ObservableCollection<Book> libraryBooks)
    {
        _window = window;
        _userName = user.FullName;
        _loanedBooks = loanedBooks;
        _libraryBooks = libraryBooks;
        _tempLoanedBooks = new ObservableCollection<UserBookItem>(_loanedBooks);
        _tempLibraryBooks = new ObservableCollection<Book>(_libraryBooks);
    }
}