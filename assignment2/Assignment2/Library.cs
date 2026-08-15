namespace LibraryManagementSystem;

public class Library
{
    private List<Book> books;
    private List<Member> members;
    private List<BorrowRecord> borrowRecords;

    private FineCalculator fineCalculator;

    public Library()
    {
        books = new List<Book>();
        members = new List<Member>();
        borrowRecords = new List<BorrowRecord>();
        fineCalculator = new FineCalculator();
    }

    // Method Overloading
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddBook(
        int bookId,
        string title,
        string author)
    {
        Book book = new Book(bookId, title, author);
        books.Add(book);
    }

    public void RegisterMember(Member member)
    {
        members.Add(member);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("\n--- Books ---");

        foreach (Book book in books)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }
    }

    public void DisplayMembers()
    {
        Console.WriteLine("\n--- Members ---");

        foreach (Member member in members)
        {
            Console.WriteLine(
                $"ID: {member.MemberId}, " +
                $"Name: {member.Name}, " +
                $"Email: {member.Email}"
            );
        }
    }

    public void BorrowBook(
        int bookId,
        int memberId)
    {
        Book? book = books.Find(b => b.BookId == bookId);
        Member? member = members.Find(m => m.MemberId == memberId);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (member == null)
        {
            Console.WriteLine("Member not found.");
            return;
        }

        if (book.IsBorrowed)
        {
            Console.WriteLine("Book is already borrowed.");
            return;
        }

        book.Borrow();

        BorrowRecord record = new BorrowRecord(
            book,
            member,
            DateTime.Today,
            DateTime.Today.AddDays(14)
        );

        borrowRecords.Add(record);

        Console.WriteLine(
            $"Due date: {record.DueDate:yyyy-MM-dd}"
        );
    }

    public void ReturnBook(int bookId)
    {
        BorrowRecord? record = borrowRecords.Find(
            r => r.Book.BookId == bookId && !r.IsReturned
        );

        if (record == null)
        {
            Console.WriteLine("Active borrow record not found.");
            return;
        }

        record.Book.Return();
        record.MarkAsReturned();

        int overdueDays = record.GetOverdueDays();

        double fine = fineCalculator.CalculateFine(overdueDays);

        Console.WriteLine($"Overdue days: {overdueDays}");
        Console.WriteLine($"Fine: {fine:C}");
    }
}