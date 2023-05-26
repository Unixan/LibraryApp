using System.Collections.ObjectModel;
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

    public RelayCommand EmptyFieldsCommand => new RelayCommand(execute => EmptyFields());
    public RelayCommand AddUserCommand => new RelayCommand(execute => AddUser());

    private void AddUser()
    {
        MessageBox.Show("success");
    }

    private void EmptyFields()
    {
        UserFirstName = "";
        UserLastName = "";
        UserAddress = "";

    }

    public AddUserWindowViewModel(Window window, ObservableCollection<User> users)
    {
        Users = users;
    }
}