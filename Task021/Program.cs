// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Enter X1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter X2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
Console.Write($"Distance between 2 points A({X1}, {Y1}, {Z1}) and B({X2}, {Y2}, {Z2}) is {result}");