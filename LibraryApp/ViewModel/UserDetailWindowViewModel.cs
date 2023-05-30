using System.Collections.ObjectModel;
using System.Windows;
using LibraryApp.Model;
using LibraryApp.MVVM;

namespace LibraryApp.ViewModel;

public class UserDetailWindowViewModel : ViewModelBase
{
    private User _user;
    public ObservableCollection<Book> Books => _user.LoanedBooks;
    private Book _book;
    private Window _window;

    public Book Book
    {
        get { return _book; }
        set
        {
            _book = value;
            OnPropertyChanged();
        }
    }
    public User User
    {
        get { return _user; }
        set
        {
            _user = value; 
            OnPropertyChanged();
        }

    }
    public UserDetailWindowViewModel(Window window, User user)
    {
        _window = window;
        _user = user;
    }
}