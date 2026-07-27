string username = Console.ReadLine();

int uniqueCount = username.Distinct().Count();

if (uniqueCount % 2 == 0){
    Console.WriteLine("CHAT WITH HER!");
}
else{
    Console.WriteLine("IGNORE HIM!");
}