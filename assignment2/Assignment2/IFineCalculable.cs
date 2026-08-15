namespace LibraryManagementSystem;

public interface IFineCalculable
{
    double CalculateFine(int overdueDays);
    double CalculateFine(int overdueDays, double dailyRate);
}