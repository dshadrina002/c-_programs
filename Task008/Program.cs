// Задача 8 -  Вывод четных чисел от 1 до N
Console.Write("Enter the number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("The even numbers from 1 to " + num1 + " are: ");
for (int i = 2; i <= num1; i = i + 2)
{
    Console.Write(i + " ");
}
