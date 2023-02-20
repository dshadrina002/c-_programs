// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine()!);
string numberString = number.ToString();
if(numberString.Length != 5)
{
    Console.Write("Number should contain 5 digits");
}
else
{
    int i = 0;
    if(numberString[0] == numberString[4] && numberString[1] == numberString[3])
    {
        Console.Write("Palindrom");
    }
    else
    {
        Console.Write("NOT Palindrom");
    }
}