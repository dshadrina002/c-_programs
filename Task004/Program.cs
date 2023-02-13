//Задача 4 на поиск максимума из 3-х чисел
Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number:");
int num3 = int.Parse(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("The maximum number is: " + max);
