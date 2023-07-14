using LibraryProject.Workspace.Classes;
using LibraryProject.Workspace.Forms;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        Library library;
        public MainForm()
        {
            InitializeComponent();
            TabControl.Size = ClientRectangle.Size;
            library = new Library();
        }

        private void buttonBooksSearchBooks_Click(object sender, EventArgs e)
        {
            string ISBN = textBoxBooksISBN.Text;
            string title = textBoxBooksTitle.Text;
            string authorName = textBoxBooksAuthor.Text;

            listBoxBooksSelect.DataSource = null;

            List<Book> BooksFromSearch = library.SearchBook(ISBN, title, authorName);

            if (BooksFromSearch.Count != 0)
            {
                listBoxBooksSelect.DataSource = BooksFromSearch;
                listBoxBooksSelect.DisplayMember = "Title";
                listBoxBooksSelect.SelectedIndex = 0;

            }
        }
        private void listBoxBooksSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
            Book selectedBook = (Book)listBox.SelectedItem;

            textBoxBooksISBNR.Text = selectedBook.ISBN;
            textBoxBooksTitleR.Text = selectedBook.Title;
            textBoxDescription.Text = selectedBook.Description;

            

            string selectedAuthors = "";
            foreach (Author author in selectedBook.Authors)
            {
                selectedAuthors += author.FullName + ", ";
            }
            textBoxBooksAuthorsR.Text = selectedAuthors;

            }
        }

        private void buttonBooksNewBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void buttonBooksEditBooks_Click(object sender, EventArgs e)
        {

        }

        private void buttonBooksDeleteBooks_Click(object sender, EventArgs e)
        {

        }
    }
}