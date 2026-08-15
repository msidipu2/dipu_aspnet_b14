namespace LibraryManagementSystem;

public class BorrowRecord
{
    public Book Book { get; set; }
    public Member Member { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; private set; }

    public bool IsReturned
    {
        get
        {
            return ReturnDate.HasValue;
        }
    }

    public BorrowRecord(
        Book book,
        Member member,
        DateTime borrowDate,
        DateTime dueDate)
    {
        Book = book;
        Member = member;
        BorrowDate = borrowDate;
        DueDate = dueDate;
    }

    public void MarkAsReturned()
    {
        ReturnDate = DateTime.Today;
    }

    public int GetOverdueDays()
    {
        DateTime endDate = ReturnDate ?? DateTime.Today;

        if (endDate <= DueDate)
        {
            return 0;
        }

        return (endDate - DueDate).Days;
    }
}