using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Workspace.Classes
{
    public class Book
    {
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public List<Author> Authors { get; private set; }
        public string Description { get; private set; }

        public Book(string isbn, string title, string description, List<Author> authors)
        {
            ISBN = isbn;
            Title = title;
            Description = description;
            Authors = new List<Author>();

            foreach (Author author in authors)
            {
                Authors.Add(author);
            }
        }
    }
}
