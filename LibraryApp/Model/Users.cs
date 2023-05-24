using System.Collections.Generic;

namespace LibraryApp.Model;

public class Users
{
    public List<User> UsersList { get; set; }

    public Users()
    {
        UsersList = new List<User>();
    }

    public void AddUser(User user)
    {
        UsersList.Add(user);
    }
}