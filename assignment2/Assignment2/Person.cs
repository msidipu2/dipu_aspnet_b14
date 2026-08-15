namespace LibraryManagementSystem;

public abstract class Person
{
    private string name = "";

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
        }
    }

    public Person(string name)
    {
        Name = name;
    }

    public abstract void DisplayRole();
}