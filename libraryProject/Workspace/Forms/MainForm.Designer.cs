namespace LibraryProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelBooksDescriptionR = new System.Windows.Forms.Label();
            this.textBoxBooksAuthorsR = new System.Windows.Forms.TextBox();
            this.LabelBooksAuthorsR = new System.Windows.Forms.Label();
            this.textBoxBooksTitleR = new System.Windows.Forms.TextBox();
            this.textBoxBooksISBNR = new System.Windows.Forms.TextBox();
            this.LabelBooksTitleR = new System.Windows.Forms.Label();
            this.LabelBooksISBNR = new System.Windows.Forms.Label();
            this.LabelBooksSelectBook = new System.Windows.Forms.Label();
            this.textBoxBooksTitle = new System.Windows.Forms.TextBox();
            this.listBoxBooksSelect = new System.Windows.Forms.ListBox();
            this.buttonBooksNewBook = new System.Windows.Forms.Button();
            this.buttonBooksDeleteBooks = new System.Windows.Forms.Button();
            this.buttonBooksEditBooks = new System.Windows.Forms.Button();
            this.buttonBooksSearchBooks = new System.Windows.Forms.Button();
            this.textBoxBooksAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBooksISBN = new System.Windows.Forms.TextBox();
            this.LabelBooksAuthor = new System.Windows.Forms.Label();
            this.LabelBooksTitle = new System.Windows.Forms.Label();
            this.LabelBooksISBN = new System.Windows.Forms.Label();
            this.BooksLabelTitle = new System.Windows.Forms.Label();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.tabPageLoans = new System.Windows.Forms.TabPage();
            this.tabPageMembers = new System.Windows.Forms.TabPage();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageBooks);
            this.TabControl.Controls.Add(this.tabPageAuthors);
            this.TabControl.Controls.Add(this.tabPageLoans);
            this.TabControl.Controls.Add(this.tabPageMembers);
            this.TabControl.Controls.Add(this.tabPageReports);
            this.TabControl.Location = new System.Drawing.Point(5, 1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(777, 556);
            this.TabControl.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.textBoxDescription);
            this.tabPageBooks.Controls.Add(this.LabelBooksDescriptionR);
            this.tabPageBooks.Controls.Add(this.textBoxBooksAuthorsR);
            this.tabPageBooks.Controls.Add(this.LabelBooksAuthorsR);
            this.tabPageBooks.Controls.Add(this.textBoxBooksTitleR);
            this.tabPageBooks.Controls.Add(this.textBoxBooksISBNR);
            this.tabPageBooks.Controls.Add(this.LabelBooksTitleR);
            this.tabPageBooks.Controls.Add(this.LabelBooksISBNR);
            this.tabPageBooks.Controls.Add(this.LabelBooksSelectBook);
            this.tabPageBooks.Controls.Add(this.textBoxBooksTitle);
            this.tabPageBooks.Controls.Add(this.listBoxBooksSelect);
            this.tabPageBooks.Controls.Add(this.buttonBooksNewBook);
            this.tabPageBooks.Controls.Add(this.buttonBooksDeleteBooks);
            this.tabPageBooks.Controls.Add(this.buttonBooksEditBooks);
            this.tabPageBooks.Controls.Add(this.buttonBooksSearchBooks);
            this.tabPageBooks.Controls.Add(this.textBoxBooksAuthor);
            this.tabPageBooks.Controls.Add(this.textBoxBooksISBN);
            this.tabPageBooks.Controls.Add(this.LabelBooksAuthor);
            this.tabPageBooks.Controls.Add(this.LabelBooksTitle);
            this.tabPageBooks.Controls.Add(this.LabelBooksISBN);
            this.tabPageBooks.Controls.Add(this.BooksLabelTitle);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(769, 528);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Books";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxDescription.Location = new System.Drawing.Point(6, 364);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(748, 150);
            this.textBoxDescription.MaxLength = 0;
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(748, 150);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(748, 150);
            this.textBoxDescription.TabIndex = 22;
            // 
            // LabelBooksDescriptionR
            // 
            this.LabelBooksDescriptionR.AutoSize = true;
            this.LabelBooksDescriptionR.Location = new System.Drawing.Point(6, 346);
            this.LabelBooksDescriptionR.Name = "LabelBooksDescriptionR";
            this.LabelBooksDescriptionR.Size = new System.Drawing.Size(67, 15);
            this.LabelBooksDescriptionR.TabIndex = 21;
            this.LabelBooksDescriptionR.Text = "Description";
            // 
            // textBoxBooksAuthorsR
            // 
            this.textBoxBooksAuthorsR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxBooksAuthorsR.Location = new System.Drawing.Point(6, 320);
            this.textBoxBooksAuthorsR.Name = "textBoxBooksAuthorsR";
            this.textBoxBooksAuthorsR.ReadOnly = true;
            this.textBoxBooksAuthorsR.Size = new System.Drawing.Size(748, 23);
            this.textBoxBooksAuthorsR.TabIndex = 20;
            // 
            // LabelBooksAuthorsR
            // 
            this.LabelBooksAuthorsR.AutoSize = true;
            this.LabelBooksAuthorsR.Location = new System.Drawing.Point(6, 302);
            this.LabelBooksAuthorsR.Name = "LabelBooksAuthorsR";
            this.LabelBooksAuthorsR.Size = new System.Drawing.Size(49, 15);
            this.LabelBooksAuthorsR.TabIndex = 19;
            this.LabelBooksAuthorsR.Text = "Authors";
            // 
            // textBoxBooksTitleR
            // 
            this.textBoxBooksTitleR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxBooksTitleR.Location = new System.Drawing.Point(104, 276);
            this.textBoxBooksTitleR.Name = "textBoxBooksTitleR";
            this.textBoxBooksTitleR.ReadOnly = true;
            this.textBoxBooksTitleR.Size = new System.Drawing.Size(650, 23);
            this.textBoxBooksTitleR.TabIndex = 18;
            // 
            // textBoxBooksISBNR
            // 
            this.textBoxBooksISBNR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxBooksISBNR.Location = new System.Drawing.Point(6, 276);
            this.textBoxBooksISBNR.Name = "textBoxBooksISBNR";
            this.textBoxBooksISBNR.ReadOnly = true;
            this.textBoxBooksISBNR.Size = new System.Drawing.Size(92, 23);
            this.textBoxBooksISBNR.TabIndex = 17;
            // 
            // LabelBooksTitleR
            // 
            this.LabelBooksTitleR.AutoSize = true;
            this.LabelBooksTitleR.Location = new System.Drawing.Point(100, 258);
            this.LabelBooksTitleR.Name = "LabelBooksTitleR";
            this.LabelBooksTitleR.Size = new System.Drawing.Size(29, 15);
            this.LabelBooksTitleR.TabIndex = 16;
            this.LabelBooksTitleR.Text = "Title";
            // 
            // LabelBooksISBNR
            // 
            this.LabelBooksISBNR.AutoSize = true;
            this.LabelBooksISBNR.Location = new System.Drawing.Point(6, 258);
            this.LabelBooksISBNR.Name = "LabelBooksISBNR";
            this.LabelBooksISBNR.Size = new System.Drawing.Size(32, 15);
            this.LabelBooksISBNR.TabIndex = 15;
            this.LabelBooksISBNR.Text = "ISBN";
            // 
            // LabelBooksSelectBook
            // 
            this.LabelBooksSelectBook.AutoSize = true;
            this.LabelBooksSelectBook.Location = new System.Drawing.Point(6, 119);
            this.LabelBooksSelectBook.Name = "LabelBooksSelectBook";
            this.LabelBooksSelectBook.Size = new System.Drawing.Size(68, 15);
            this.LabelBooksSelectBook.TabIndex = 14;
            this.LabelBooksSelectBook.Text = "Select Book";
            // 
            // textBoxBooksTitle
            // 
            this.textBoxBooksTitle.Location = new System.Drawing.Point(104, 64);
            this.textBoxBooksTitle.Name = "textBoxBooksTitle";
            this.textBoxBooksTitle.Size = new System.Drawing.Size(386, 23);
            this.textBoxBooksTitle.TabIndex = 13;
            // 
            // listBoxBooksSelect
            // 
            this.listBoxBooksSelect.FormattingEnabled = true;
            this.listBoxBooksSelect.ItemHeight = 15;
            this.listBoxBooksSelect.Location = new System.Drawing.Point(6, 137);
            this.listBoxBooksSelect.Name = "listBoxBooksSelect";
            this.listBoxBooksSelect.Size = new System.Drawing.Size(574, 109);
            this.listBoxBooksSelect.TabIndex = 12;
            this.listBoxBooksSelect.SelectedIndexChanged += new System.EventHandler(this.listBoxBooksSelect_SelectedIndexChanged);
            // 
            // buttonBooksNewBook
            // 
            this.buttonBooksNewBook.Location = new System.Drawing.Point(586, 195);
            this.buttonBooksNewBook.Name = "buttonBooksNewBook";
            this.buttonBooksNewBook.Size = new System.Drawing.Size(156, 23);
            this.buttonBooksNewBook.TabIndex = 11;
            this.buttonBooksNewBook.Text = "Add New Book";
            this.buttonBooksNewBook.UseVisualStyleBackColor = true;
            this.buttonBooksNewBook.Click += new System.EventHandler(this.buttonBooksNewBook_Click);
            // 
            // buttonBooksDeleteBooks
            // 
            this.buttonBooksDeleteBooks.Location = new System.Drawing.Point(586, 166);
            this.buttonBooksDeleteBooks.Name = "buttonBooksDeleteBooks";
            this.buttonBooksDeleteBooks.Size = new System.Drawing.Size(156, 23);
            this.buttonBooksDeleteBooks.TabIndex = 10;
            this.buttonBooksDeleteBooks.Text = "Delete Selected Book";
            this.buttonBooksDeleteBooks.UseVisualStyleBackColor = true;
            this.buttonBooksDeleteBooks.Click += new System.EventHandler(this.buttonBooksDeleteBooks_Click);
            // 
            // buttonBooksEditBooks
            // 
            this.buttonBooksEditBooks.Location = new System.Drawing.Point(586, 137);
            this.buttonBooksEditBooks.Name = "buttonBooksEditBooks";
            this.buttonBooksEditBooks.Size = new System.Drawing.Size(156, 23);
            this.buttonBooksEditBooks.TabIndex = 9;
            this.buttonBooksEditBooks.Text = "Edit Selected Book";
            this.buttonBooksEditBooks.UseVisualStyleBackColor = true;
            this.buttonBooksEditBooks.Click += new System.EventHandler(this.buttonBooksEditBooks_Click);
            // 
            // buttonBooksSearchBooks
            // 
            this.buttonBooksSearchBooks.Location = new System.Drawing.Point(598, 93);
            this.buttonBooksSearchBooks.Name = "buttonBooksSearchBooks";
            this.buttonBooksSearchBooks.Size = new System.Drawing.Size(156, 23);
            this.buttonBooksSearchBooks.TabIndex = 7;
            this.buttonBooksSearchBooks.Text = "Search Books";
            this.buttonBooksSearchBooks.UseVisualStyleBackColor = true;
            this.buttonBooksSearchBooks.Click += new System.EventHandler(this.buttonBooksSearchBooks_Click);
            // 
            // textBoxBooksAuthor
            // 
            this.textBoxBooksAuthor.Location = new System.Drawing.Point(496, 64);
            this.textBoxBooksAuthor.Name = "textBoxBooksAuthor";
            this.textBoxBooksAuthor.Size = new System.Drawing.Size(258, 23);
            this.textBoxBooksAuthor.TabIndex = 6;
            // 
            // textBoxBooksISBN
            // 
            this.textBoxBooksISBN.Location = new System.Drawing.Point(6, 64);
            this.textBoxBooksISBN.Name = "textBoxBooksISBN";
            this.textBoxBooksISBN.Size = new System.Drawing.Size(92, 23);
            this.textBoxBooksISBN.TabIndex = 4;
            // 
            // LabelBooksAuthor
            // 
            this.LabelBooksAuthor.AutoSize = true;
            this.LabelBooksAuthor.Location = new System.Drawing.Point(496, 46);
            this.LabelBooksAuthor.Name = "LabelBooksAuthor";
            this.LabelBooksAuthor.Size = new System.Drawing.Size(44, 15);
            this.LabelBooksAuthor.TabIndex = 3;
            this.LabelBooksAuthor.Text = "Author";
            // 
            // LabelBooksTitle
            // 
            this.LabelBooksTitle.AutoSize = true;
            this.LabelBooksTitle.Location = new System.Drawing.Point(100, 46);
            this.LabelBooksTitle.Name = "LabelBooksTitle";
            this.LabelBooksTitle.Size = new System.Drawing.Size(29, 15);
            this.LabelBooksTitle.TabIndex = 2;
            this.LabelBooksTitle.Text = "Title";
            // 
            // LabelBooksISBN
            // 
            this.LabelBooksISBN.AutoSize = true;
            this.LabelBooksISBN.Location = new System.Drawing.Point(6, 46);
            this.LabelBooksISBN.Name = "LabelBooksISBN";
            this.LabelBooksISBN.Size = new System.Drawing.Size(32, 15);
            this.LabelBooksISBN.TabIndex = 1;
            this.LabelBooksISBN.Text = "ISBN";
            // 
            // BooksLabelTitle
            // 
            this.BooksLabelTitle.AutoSize = true;
            this.BooksLabelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BooksLabelTitle.Location = new System.Drawing.Point(3, 3);
            this.BooksLabelTitle.Name = "BooksLabelTitle";
            this.BooksLabelTitle.Size = new System.Drawing.Size(61, 25);
            this.BooksLabelTitle.TabIndex = 0;
            this.BooksLabelTitle.Text = "Books";
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthors.Size = new System.Drawing.Size(769, 528);
            this.tabPageAuthors.TabIndex = 1;
            this.tabPageAuthors.Text = "Authors";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            // 
            // tabPageLoans
            // 
            this.tabPageLoans.Location = new System.Drawing.Point(4, 24);
            this.tabPageLoans.Name = "tabPageLoans";
            this.tabPageLoans.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoans.Size = new System.Drawing.Size(769, 528);
            this.tabPageLoans.TabIndex = 2;
            this.tabPageLoans.Text = "Loans";
            this.tabPageLoans.UseVisualStyleBackColor = true;
            // 
            // tabPageMembers
            // 
            this.tabPageMembers.Location = new System.Drawing.Point(4, 24);
            this.tabPageMembers.Name = "tabPageMembers";
            this.tabPageMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembers.Size = new System.Drawing.Size(769, 528);
            this.tabPageMembers.TabIndex = 3;
            this.tabPageMembers.Text = "Members";
            this.tabPageMembers.UseVisualStyleBackColor = true;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Location = new System.Drawing.Point(4, 24);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(769, 528);
            this.tabPageReports.TabIndex = 4;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TabControl);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPageBooks;
        private TabPage tabPageAuthors;
        private TabPage tabPageLoans;
        private TabPage tabPageMembers;
        private TabPage tabPageReports;
        private Label LabelBooksTitle;
        private Label LabelBooksISBN;
        private Label BooksLabelTitle;
        private TextBox textBoxBooksISBN;
        private Label LabelBooksAuthor;
        private Button buttonBooksSearchBooks;
        private TextBox textBoxBooksAuthor;
        private Button buttonBooksNewBook;
        private Button buttonBooksDeleteBooks;
        private Button buttonBooksEditBooks;
        private ListBox listBoxBooksSelect;
        private TextBox textBoxBooksTitle;
        private Label LabelBooksSelectBook;
        private TextBox textBoxBooksTitleR;
        private TextBox textBoxBooksISBNR;
        private Label LabelBooksTitleR;
        private Label LabelBooksISBNR;
        private Label LabelBooksDescriptionR;
        private TextBox textBoxBooksAuthorsR;
        private Label LabelBooksAuthorsR;
        private TextBox textBoxDescription;
    }
}