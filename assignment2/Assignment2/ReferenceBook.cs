namespace LibraryManagementSystem;

public class ReferenceBook : Book
{
    public string ReferenceSection { get; set; }

    public ReferenceBook(
        int bookId,
        string title,
        string author,
        string referenceSection)
        : base(bookId, title, author)
    {
        ReferenceSection = referenceSection;
    }

    public override void Borrow()
    {
        Console.WriteLine($"'{Title}' is a reference book and cannot be borrowed.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Reference Section: {ReferenceSection}");
    }
}