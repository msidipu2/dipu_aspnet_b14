string[] input = Console.ReadLine().Split(' ');

long k = Convert.ToInt64(input[0]);
long n = Convert.ToInt64(input[1]);
long w = Convert.ToInt64(input[2]);

long totalCost = k * (w * (w + 1) / 2);
long borrow = totalCost - n;

if (borrow > 0)
{
    Console.WriteLine(borrow);
}
else
{
    Console.WriteLine(0);
}