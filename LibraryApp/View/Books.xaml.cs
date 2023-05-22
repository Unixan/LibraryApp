using LibraryApp.Model;
using System.Linq;
using System.Windows;

namespace LibraryApp.View
{
    public partial class Books : Window
    {
        public Library Library;
        public Book SelectedBook;
        public Books(Window mainWindow)
        {
            Owner = mainWindow;
            InitializeComponent();
            Library = new Library();
            Library.AddBook(new Book("Harry Potter og de vises stein", "J. K. Rowling", "Fantasi", "Harry Potter har ikke opplevd mye magi i sitt liv. Han bor i et kott under trappa hos den ekle familien Dumling, og han har ikke feiret bursdagen sin på elleve år. Men alt dette endrer seg når en ugle leverer et mystisk brev med innbydelse til Galtvort høyere skole for hekseri og trolldom ? et utrolig sted som Harry og alle som leser om ham aldri vil glemme. Her får Harry venner, og magien gjennomsyrer alt fra skoletimer til måltider. Men et skjebnesvangert møte venter ham. Vil Harry, gutten med sikksakkarret, leve opp til forventningene alle har til ham?"));
            Library.AddBook(new Book("Hobbiten, eller Fram og tilbake igjen", "J. R. R. Tolkien", "Fantasi", "Bilbo Lommelun lever et behagelig liv i hobbithullet sitt i Bakken, og det er sjelden han beveger seg lenger enn til spiskammeret. Så en dag dukker trollmannen Gandalv opp sammen med tretten dverger, og vil ha ham med på en reise «fram og tilbake igjen». Dvergenes plan er å røve den veldige skatten som voktes av Smaug, en enorm og svært farlig drage."));
            Library.AddBook(new Book("Tørst", "Jo Nesbø", "Drama", "Et drapsoffer blir funnet i sitt hjem med bitemerker i halsen. Kroppen er tappet for blod. Kan det være vamyprisme - et svært omdiskutert felt i psykiatrien. Tidligere etterforsker Harry Hole vet bedre enn noen at flere av krimhistoriens verste seriemordere har vært diagnostisert som nettopp vampyrister. Men Harry har et annet motiv for å bistå politiet - morderen som slapp unna."));
            foreach (var booklisting in Library.Books.Select(book => new BookListing(book)))
            {
                BookList.Items.Add(booklisting);
            }
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ButtonDetails_OnClick(object sender, RoutedEventArgs e)
        {
            var index = BookList.SelectedIndex;
            if (index < 0) return;
            SelectedBook = Library.GetBook(index);
            var bookDetails = new BookDetails(this);
            bookDetails.ShowDialog();
        }


    }
}
