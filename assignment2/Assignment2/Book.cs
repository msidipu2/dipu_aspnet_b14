namespace LibraryManagementSystem;

public class Book : IBorrowable
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public bool IsBorrowed { get; private set; }

    public Book(int bookId, string title, string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        IsBorrowed = false;
    }

    public virtual void Borrow()
    {
        if (!IsBorrowed)
        {
            IsBorrowed = true;
            Console.WriteLine($"'{Title}' has been borrowed.");
        }
        else
        {
            Console.WriteLine($"'{Title}' is already borrowed.");
        }
    }

    public virtual void Return()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"'{Title}' has been returned.");
        }
        else
        {
            Console.WriteLine($"'{Title}' was not borrowed.");
        }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book ID: {BookId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Borrowed: {IsBorrowed}");
    }
}