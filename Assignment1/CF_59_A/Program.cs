string s = Console.ReadLine();

int upperCount = 0;
int lowerCount = 0;

for (int i = 0; i < s.Length; i++)
{
    if (char.IsUpper(s[i]))
    {
        upperCount++;
    }
    else
    {
        lowerCount++;
    }
}

if (upperCount > lowerCount)
{
    Console.WriteLine(s.ToUpper());
}
else
{
    Console.WriteLine(s.ToLower());
}