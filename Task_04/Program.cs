Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()); 

Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()); 

Console.Write("Введите 3-е число: ");
int k = int.Parse(Console.ReadLine()); 

if (n > m && n > k)
    Console.Write($"max = {n}");
else if (m > k)
        Console.Write($"max = {m}");
    else 
        Console.Write($"max = {k}");