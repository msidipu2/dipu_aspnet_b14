namespace LibraryManagementSystem;

public class Member : Person
{
    public int MemberId { get; set; }
    public string Email { get; set; }

    public Member(
        string name,
        int memberId,
        string email)
        : base(name)
    {
        MemberId = memberId;
        Email = email;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Library Member");
    }
}