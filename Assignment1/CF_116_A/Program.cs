int stops = Convert.ToInt32(Console.ReadLine());

int current = 0;
int max = 0;

for (int i = 0; i < stops; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int exit = Convert.ToInt32(input[0]);
    int enter = Convert.ToInt32(input[1]);

    current = current - exit + enter;

    if (current > max)
    {
        max = current;
    }
}

Console.WriteLine(max);