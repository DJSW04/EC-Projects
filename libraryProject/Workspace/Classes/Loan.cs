using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Workspace.Classes
{
    public class Loan
    {
        public int LoanID { get; private set; }
        public Member Member { get; private set; }
        public Book Book { get; private set; }
        public DateTime LoanDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? ReturnedDate { get; private set; }

        public bool Returned
        {
            get
            {
                if (ReturnedDate == null) { return false; }
                else { return true; }
            }
        }

        public Loan(int loanID, Member member, Book book, DateTime loanDate, DateTime dueDate, DateTime? returnedDate)
        {
            LoanID = loanID;
            Member = member;
            Book = book;
            LoanDate = loanDate;
            DueDate = dueDate;
            ReturnedDate = returnedDate;
        }
    }
}
