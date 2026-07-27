string vowels = "aeiouy";

string output = "";

string input = Console.ReadLine().ToLower();

foreach (char c in input)
{
    if (!vowels.Contains(c))
    {
        output += "." + c;
    }
}

Console.WriteLine(output);