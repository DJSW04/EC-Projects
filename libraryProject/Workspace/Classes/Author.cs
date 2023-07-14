using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Workspace.Classes
{
    public class Author
    {
        public int AuthorID { get; private set; }
        public string FullName { get; private set; }

        public Author(int authorID, string fullName)
        {
            AuthorID = authorID;
            FullName = fullName;
        }
    }
}
