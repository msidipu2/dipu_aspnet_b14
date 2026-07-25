int numberOfWord = Convert.ToInt32(Console.ReadLine());

while (numberOfWord > 0) { 
    string word = Console.ReadLine();
    int length = word.Length;
    if (length <= 10)
    {
        Console.WriteLine(word);
    }
    else
    {
        Console.WriteLine(word[0] + (length - 2).ToString() + word[length - 1]);
    }
    numberOfWord--;
}
