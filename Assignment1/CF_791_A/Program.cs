string[] input = Console.ReadLine().Split(' ');

int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);

int years = 0;

while (a <= b)
{
    a *= 3;
    b *= 2;
    years++;
}

Console.WriteLine(years);