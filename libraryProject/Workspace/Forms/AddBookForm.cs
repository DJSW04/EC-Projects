using LibraryProject.Workspace.Classes;
using LibraryProject.Workspace.Forms;

namespace LibraryProject.Workspace.Forms
{
    public partial class AddBookForm : Form
    {
        Library library = new Library();
        private List<Author> authorsOfBook = new List<Author> { };
        public AddBookForm()
        {
            InitializeComponent();
            comboBoxAddAuthor.DataSource = null;
            List<Author> allAuthors = library.GetAuthors();

            if (allAuthors.Count > 0 ) 
            {
                comboBoxAddAuthor.DisplayMember = "FullName";
                comboBoxAddAuthor.DataSource = allAuthors;
                comboBoxAddAuthor.SelectedIndex = 0;
            }
        }
        private void buttonNewAuthor_Click(object sender, EventArgs e)
        {
            authorsOfBook.Add((Author)comboBoxAddAuthor.SelectedItem);
            UpdateAuthorsListBox();
        }

        private void UpdateAuthorsListBox()
        {
            listBoxSelectAuthor.DataSource = null;
            listBoxSelectAuthor.DataSource = authorsOfBook;
            listBoxSelectAuthor.DisplayMember = "FullName";

        }
    }
}
