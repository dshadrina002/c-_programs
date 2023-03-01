//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Задайте элементы для уравнения y = k1 * x + b1");
Console.Write("Enter k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте элементы для уравнения y = k2 * x + b2");
Console.Write("Enter k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter b2: ");
int b2 = int.Parse(Console.ReadLine()!);
if(k1 == k2) 
{
    Console.WriteLine("Error: k1 and k2 are equal, cannot solve system.");
}
else
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    Console.WriteLine($"Решение уравнения - {x}, {y}");
}

