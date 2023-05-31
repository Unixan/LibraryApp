using System.Collections.ObjectModel;
using System.Windows;
using LibraryApp.Model;
using LibraryApp.MVVM;
using LibraryApp.View;

namespace LibraryApp.ViewModel;

public class UsersWindowViewModel : ViewModelBase
{
    private Window _window;
    public ObservableCollection<User> Users { get; set; }

    private ObservableCollection<Book> _library;

    private User _currentUser;

    public User CurrentUser
    {
        get { return _currentUser;}
        set
        {
            _currentUser = value;
            OnPropertyChanged();
        }
    }
    public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteUser(), canExecute => CurrentUser != null);
    public RelayCommand DetailsCommand => new RelayCommand(execute => ShowUserDetails(), canExecute => CurrentUser != null);
    public RelayCommand AddUserCommand => new RelayCommand(execute => AddUser());
    public RelayCommand CloseWindowCommand => new RelayCommand(execute => CloseWindow(_window));
    


    public UsersWindowViewModel(Window window,ObservableCollection<User> users, ObservableCollection<Book> library)
    {
        _window = window;
        Users = users;
        _library = library;
    }

    private void AddUser()
    {
        var addUserWindow = new AddUserWindow(_window, Users);
        addUserWindow.ShowDialog();
    }

    private void ShowUserDetails()
    {
        var userDetailWindow = new UserDetailsWindow(_window, CurrentUser, _library);
        userDetailWindow.ShowDialog();
        ReloadWindow();
    }

    private void DeleteUser()
    {
        var choice = MessageBox.Show("Er du sikker? Brukeren vil bli slettet for godt",
            $"Slette {CurrentUser.LastName}, {CurrentUser.FirstName}?",
            MessageBoxButton.YesNo,
            MessageBoxImage.Question);
        if (choice == MessageBoxResult.Yes)
        {
            Users.Remove(CurrentUser);
        }
    }
}