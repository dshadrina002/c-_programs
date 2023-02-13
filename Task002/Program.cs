//Задача 2 со сравнением чисел
Console.WriteLine("Enter numberA:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numberB:");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB)
{
    Console.WriteLine("A = B");
}
else
{
    if (numberA > numberB)
    {
        Console.WriteLine("A is greater than B");
    }
    else
    {
        Console.WriteLine("B is greater than A");
    }
}
