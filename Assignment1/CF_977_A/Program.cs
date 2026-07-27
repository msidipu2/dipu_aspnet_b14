string[] input = Console.ReadLine().Split(' ');

int n = Convert.ToInt32(input[0]);
int k = Convert.ToInt32(input[1]);

for (int i = 0; i < k; i++)
{
    if (n % 10 == 0)
    {
        n /= 10;
    }
    else
    {
        n--;
    }
}

Console.WriteLine(n);