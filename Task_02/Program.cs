Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()); 

Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()); 

if (n > m)
    Console.Write($"max = {n}");
else
    Console.Write($"max = {m}");