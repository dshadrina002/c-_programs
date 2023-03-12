// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 
Console.Write("Please enter number:");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbers(N);

void PrintNumbers(int n) 
{
    if (n == 0) {
        return;
    }
    Console.Write("{0} ", n);
    PrintNumbers(n - 1);
}
