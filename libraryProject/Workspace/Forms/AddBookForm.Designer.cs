namespace LibraryProject.Workspace.Forms
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddBook = new System.Windows.Forms.Label();
            this.textBoxBooksTitle = new System.Windows.Forms.TextBox();
            this.textBoxBooksISBN = new System.Windows.Forms.TextBox();
            this.LabelAddBooksTitle = new System.Windows.Forms.Label();
            this.LabelAddBooksISBN = new System.Windows.Forms.Label();
            this.LabelAddBooksSelectAuthor = new System.Windows.Forms.Label();
            this.listBoxSelectAuthor = new System.Windows.Forms.ListBox();
            this.labelAddAuthors = new System.Windows.Forms.Label();
            this.comboBoxAddAuthor = new System.Windows.Forms.ComboBox();
            this.buttonNewAuthor = new System.Windows.Forms.Button();
            this.buttonRemoveAuthor = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddNewBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddBook
            // 
            this.labelAddBook.AutoSize = true;
            this.labelAddBook.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddBook.Location = new System.Drawing.Point(12, 9);
            this.labelAddBook.Name = "labelAddBook";
            this.labelAddBook.Size = new System.Drawing.Size(100, 25);
            this.labelAddBook.TabIndex = 1;
            this.labelAddBook.Text = "Add Books";
            // 
            // textBoxBooksTitle
            // 
            this.textBoxBooksTitle.Location = new System.Drawing.Point(114, 65);
            this.textBoxBooksTitle.Name = "textBoxBooksTitle";
            this.textBoxBooksTitle.Size = new System.Drawing.Size(386, 23);
            this.textBoxBooksTitle.TabIndex = 17;
            // 
            // textBoxBooksISBN
            // 
            this.textBoxBooksISBN.Location = new System.Drawing.Point(16, 65);
            this.textBoxBooksISBN.Name = "textBoxBooksISBN";
            this.textBoxBooksISBN.Size = new System.Drawing.Size(92, 23);
            this.textBoxBooksISBN.TabIndex = 16;
            // 
            // LabelAddBooksTitle
            // 
            this.LabelAddBooksTitle.AutoSize = true;
            this.LabelAddBooksTitle.Location = new System.Drawing.Point(110, 47);
            this.LabelAddBooksTitle.Name = "LabelAddBooksTitle";
            this.LabelAddBooksTitle.Size = new System.Drawing.Size(29, 15);
            this.LabelAddBooksTitle.TabIndex = 15;
            this.LabelAddBooksTitle.Text = "Title";
            // 
            // LabelAddBooksISBN
            // 
            this.LabelAddBooksISBN.AutoSize = true;
            this.LabelAddBooksISBN.Location = new System.Drawing.Point(16, 47);
            this.LabelAddBooksISBN.Name = "LabelAddBooksISBN";
            this.LabelAddBooksISBN.Size = new System.Drawing.Size(32, 15);
            this.LabelAddBooksISBN.TabIndex = 14;
            this.LabelAddBooksISBN.Text = "ISBN";
            // 
            // LabelAddBooksSelectAuthor
            // 
            this.LabelAddBooksSelectAuthor.AutoSize = true;
            this.LabelAddBooksSelectAuthor.Location = new System.Drawing.Point(16, 103);
            this.LabelAddBooksSelectAuthor.Name = "LabelAddBooksSelectAuthor";
            this.LabelAddBooksSelectAuthor.Size = new System.Drawing.Size(78, 15);
            this.LabelAddBooksSelectAuthor.TabIndex = 19;
            this.LabelAddBooksSelectAuthor.Text = "Select Author";
            // 
            // listBoxSelectAuthor
            // 
            this.listBoxSelectAuthor.FormattingEnabled = true;
            this.listBoxSelectAuthor.ItemHeight = 15;
            this.listBoxSelectAuthor.Location = new System.Drawing.Point(16, 121);
            this.listBoxSelectAuthor.Name = "listBoxSelectAuthor";
            this.listBoxSelectAuthor.Size = new System.Drawing.Size(245, 109);
            this.listBoxSelectAuthor.TabIndex = 18;
            // 
            // labelAddAuthors
            // 
            this.labelAddAuthors.AutoSize = true;
            this.labelAddAuthors.Location = new System.Drawing.Point(269, 103);
            this.labelAddAuthors.Name = "labelAddAuthors";
            this.labelAddAuthors.Size = new System.Drawing.Size(132, 15);
            this.labelAddAuthors.TabIndex = 20;
            this.labelAddAuthors.Text = "Add Additional Authors";
            // 
            // comboBoxAddAuthor
            // 
            this.comboBoxAddAuthor.FormattingEnabled = true;
            this.comboBoxAddAuthor.Location = new System.Drawing.Point(269, 121);
            this.comboBoxAddAuthor.Name = "comboBoxAddAuthor";
            this.comboBoxAddAuthor.Size = new System.Drawing.Size(231, 23);
            this.comboBoxAddAuthor.TabIndex = 21;
            // 
            // buttonNewAuthor
            // 
            this.buttonNewAuthor.Location = new System.Drawing.Point(269, 150);
            this.buttonNewAuthor.Name = "buttonNewAuthor";
            this.buttonNewAuthor.Size = new System.Drawing.Size(231, 23);
            this.buttonNewAuthor.TabIndex = 22;
            this.buttonNewAuthor.Text = "Add New Author";
            this.buttonNewAuthor.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveAuthor
            // 
            this.buttonRemoveAuthor.Location = new System.Drawing.Point(16, 236);
            this.buttonRemoveAuthor.Name = "buttonRemoveAuthor";
            this.buttonRemoveAuthor.Size = new System.Drawing.Size(245, 23);
            this.buttonRemoveAuthor.TabIndex = 23;
            this.buttonRemoveAuthor.Text = "Remove Selected Author";
            this.buttonRemoveAuthor.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription.Location = new System.Drawing.Point(16, 265);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(484, 150);
            this.textBoxDescription.MaxLength = 0;
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(484, 150);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(484, 150);
            this.textBoxDescription.TabIndex = 24;
            // 
            // buttonAddNewBook
            // 
            this.buttonAddNewBook.Location = new System.Drawing.Point(16, 421);
            this.buttonAddNewBook.Name = "buttonAddNewBook";
            this.buttonAddNewBook.Size = new System.Drawing.Size(484, 23);
            this.buttonAddNewBook.TabIndex = 25;
            this.buttonAddNewBook.Text = "Add New Book";
            this.buttonAddNewBook.UseVisualStyleBackColor = true;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 471);
            this.Controls.Add(this.buttonAddNewBook);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonRemoveAuthor);
            this.Controls.Add(this.buttonNewAuthor);
            this.Controls.Add(this.comboBoxAddAuthor);
            this.Controls.Add(this.labelAddAuthors);
            this.Controls.Add(this.LabelAddBooksSelectAuthor);
            this.Controls.Add(this.listBoxSelectAuthor);
            this.Controls.Add(this.textBoxBooksTitle);
            this.Controls.Add(this.textBoxBooksISBN);
            this.Controls.Add(this.LabelAddBooksTitle);
            this.Controls.Add(this.LabelAddBooksISBN);
            this.Controls.Add(this.labelAddBook);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 510);
            this.MinimumSize = new System.Drawing.Size(528, 510);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddBook;
        private TextBox textBoxBooksTitle;
        private TextBox textBoxBooksISBN;
        private Label LabelAddBooksTitle;
        private Label LabelAddBooksISBN;
        private Label LabelAddBooksSelectAuthor;
        private ListBox listBoxSelectAuthor;
        private Label labelAddAuthors;
        private ComboBox comboBoxAddAuthor;
        private Button buttonNewAuthor;
        private Button buttonRemoveAuthor;
        private TextBox textBoxDescription;
        private Button buttonAddNewBook;
    }
}