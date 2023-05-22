using System.Windows;

namespace LibraryApp.View
{
    public partial class BookDetails : Window
    {
        public BookDetails (Window books)
        {
            Owner = books;
            InitializeComponent();
        }
    }
}
