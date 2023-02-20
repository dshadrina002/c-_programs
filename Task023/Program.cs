// Задача 23. Вывод таблицы кубов от 1 до N
Console.Write("Enter the number: ");
int N = int.Parse(Console.ReadLine()!);
for (int i=1; i <= N; i++)
{
    Console.Write(Math.Pow(i,3) + " ");
}