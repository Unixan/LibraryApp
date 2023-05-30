using LibraryApp.Model;
using LibraryApp.MVVM;
using System;
using System.Windows;

namespace LibraryApp.ViewModel;

public class LoanCardWindowViewModel : ViewModelBase
{
    public RelayCommand IssueCardCommand => new RelayCommand(execute => IssueLoanCard(), canExecute => _user.LoanCard == null);
    public RelayCommand RevokeCardCommand => new RelayCommand(execute => RevokeLoanCard(), canExecute => _user.LoanCard != null);
    public RelayCommand CloseCommand => new RelayCommand(execute => CloseWindow(_window));
    private Window _window;
    private User _user;
    public Guid ID => _user.Id;
    public string FullName => _user.FullName;
   public string LoanCardStatus => _user.LoanCardStatus;

    public LoanCardWindowViewModel(Window window, User user)
    {
        _window = window;
        _user = user;

    }
    private void IssueLoanCard()
    {
        _user.IssueLoanCard();
        MessageBox.Show("Lånekort tildelt for 1 år");
        ReloadWindow();
    }

    private void RevokeLoanCard()
    {
        _user.RevokeLoanCard();
        MessageBox.Show("Lånekort inndratt");
        ReloadWindow();
    }
}