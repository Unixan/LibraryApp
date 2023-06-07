using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Automation;
using LibraryApp.Model;
using LibraryApp.MVVM;

namespace LibraryApp.ViewModel;

public class AddUserWindowViewModel : ViewModelBase
{
    public ObservableCollection<User> Users { get; set; }
    private string _userFirstName;

    public string UserFirstName
    {
        get { return _userFirstName; }
        set
        {
            _userFirstName = value;
            OnPropertyChanged();
        }
    }
    private string _userLastName;

    public string UserLastName
    {
        get { return _userLastName; }
        set
        {
            _userLastName = value;
            OnPropertyChanged();
        }
    }
    private string _userAddress;

    public string UserAddress
    {
        get { return _userAddress; }
        set
        {
            _userAddress = value;
            OnPropertyChanged();
        }
    }

    public RelayCommand AddUserCommand => new RelayCommand(execute => AddUser(), canExecute => !string.IsNullOrWhiteSpace(UserFirstName) && !string.IsNullOrWhiteSpace(UserLastName) && !string.IsNullOrWhiteSpace(UserAddress));
    public RelayCommand EmptyFieldsCommand => new RelayCommand(execute => EmptyFields(), canExecute => !string.IsNullOrWhiteSpace(UserFirstName) || !string.IsNullOrWhiteSpace(UserLastName) || !string.IsNullOrWhiteSpace(UserAddress));

    public AddUserWindowViewModel(Window window, ObservableCollection<User> users)
    {
        Users = users;
    }
    private void AddUser()
    {
        var exists = CheckIfExists();
        if (exists)
        {
            MessageBox.Show("Brukeren finnes fra før!");
            EmptyFields();
            return;
        }
        var newUser = new User(UserFirstName, UserLastName, UserAddress);
        Users.Add(newUser);
        MessageBox.Show($"{newUser.FullName}\n{newUser.Address}\nBle lagt til");
        EmptyFields();
    }

    private bool CheckIfExists()
    {
        return Users.Where(user => user.FirstName.ToLower() == UserFirstName.ToLower()).Where(user => user.LastName.ToLower() == UserLastName.ToLower()).Any(user => user.Address.ToLower() == UserAddress.ToLower());
    }

    private void EmptyFields()
    {
        UserFirstName = "";
        UserLastName = "";
        UserAddress = "";

    }

}