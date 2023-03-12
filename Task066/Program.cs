// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Please enter number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = Sum(M, N);
Console.WriteLine($"The sum of natural numbers from {M} to {N} is {sum}");

int Sum(int m, int n) 
{
    if (m > n) return 0;
    return m + Sum(m + 1, n);
}