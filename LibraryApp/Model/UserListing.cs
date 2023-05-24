using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LibraryApp.Model;

public class UserListing : StackPanel
{
    public User User { get; set; }
    public UserListing(User user)
    {
        User = user;
        Children.Add(new Textitem("ID: " +user.Id, 14, true));
        Children.Add(new Textitem("Etternavn: " + user.LastName, 14, true));
        Children.Add(new Textitem("Fornavn: " + user.FirstName, 14, true));
        Background = new SolidColorBrush(Colors.LightGray);
        Width = 305;
    }
}