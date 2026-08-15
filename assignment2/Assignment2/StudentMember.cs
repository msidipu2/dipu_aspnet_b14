namespace LibraryManagementSystem;

public class StudentMember : Member
{
    public string StudentId { get; set; }

    public StudentMember(
        string name,
        int memberId,
        string email,
        string studentId)
        : base(name, memberId, email)
    {
        StudentId = studentId;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student Member");
    }
}