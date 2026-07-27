int moves = 0;

for (int r = 1; r <= 5; r++)
{

    string[] line = Console.ReadLine().Split(' ');

    for (int c = 1; c <= 5; c++)
    {
        if (line[c - 1] == "1")
        {
            moves = Math.Abs(r - 3) + Math.Abs(c - 3);
        }
    }
}

Console.WriteLine(moves);