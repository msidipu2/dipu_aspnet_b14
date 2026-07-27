using System;

int x = Convert.ToInt32(Console.ReadLine());

int steps = x / 5;
if (x % 5 != 0)
{
    steps++;
}

Console.WriteLine(steps);