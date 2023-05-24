using System.Linq;
using System.Windows;
using LibraryApp.Model;

namespace LibraryApp.View
{
    public partial class UsersView : Window
    {
    private Library _library;
    public Users UsersList { get; private set; }
        public UsersView(Window mainWindow, Library library, Users usersList)
        {
            _library = library;
            UsersList = usersList;
            Owner = mainWindow;
            InitializeComponent();
            foreach (var user in UsersList.UsersList.Select(user => new UserListing(user)))
            {
                UserList.Items.Add(user);
            }
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
