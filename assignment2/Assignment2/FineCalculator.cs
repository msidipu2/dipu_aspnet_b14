namespace LibraryManagementSystem;

public class FineCalculator : IFineCalculable
{
    private const double DefaultDailyRate = 5.0;

    public double CalculateFine(int overdueDays)
    {
        return overdueDays * DefaultDailyRate;
    }

    public double CalculateFine(int overdueDays, double dailyRate)
    {
        return overdueDays * dailyRate;
    }
}