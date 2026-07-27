string[] input = Console.ReadLine().Split('+');

Array.Sort(input);

int idx = 0;

foreach (string s in input)
{
    Console.Write(s);
    idx++;

    if (idx < input.Length)
    {
        Console.Write("+");
    }
}


