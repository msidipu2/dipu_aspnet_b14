string name = Console.ReadLine();

int count = 1; 


for (int i = 0; i < name.Length - 1; i++)
{
    if (name[i] == name[i + 1])
    {
        count++;
        
        if (count == 7)
        {
            Console.WriteLine("YES");
            break;
        }
    }
    else
    {
        count = 1;
    }
}

if (count<7)
{
    Console.WriteLine("NO");
}
