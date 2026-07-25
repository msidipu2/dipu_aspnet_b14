int  numberoOfinput= Convert.ToInt32(Console.ReadLine());
int count = 0;
while (numberoOfinput-- > 0)
{
    string value = Console.ReadLine();

    if (value[1] == '+')
    {
        count++;
    }
    if (value[1] == '-')
    {
        count--;
    }



}

Console.WriteLine(count);

