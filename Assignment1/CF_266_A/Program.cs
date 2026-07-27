int numInput = Convert.ToInt32(Console.ReadLine());
string value = Console.ReadLine();
int count = 0;

for (int i = 1; i < value.Length; i++)
{
    if(value[i] == value[i - 1]) {
        
        count++;
    
    }
}

Console.WriteLine(count);