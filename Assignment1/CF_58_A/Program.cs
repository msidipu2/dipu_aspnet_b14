string word = Console.ReadLine();
string target = "hello";

int targetIndex = 0;

for (int i = 0; i < word.Length; i++)
{
    if (word[i] == target[targetIndex])
    {
        targetIndex++;

        if (targetIndex == target.Length)
        {
            break;
        }
    }
}

if (targetIndex == target.Length)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}