// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
if(number < 100)
{
    Console.WriteLine("Your number does not have 3d digits");
}
else
{
char[] digits = number.ToString().ToCharArray();
int[] digitArray = new int[digits.Length];
for (int i = 0; i < digits.Length; i++)
{
    digitArray[i] = int.Parse(digits[i].ToString());
}
//Console.WriteLine("Enter digit number: ");
//int digitnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("3d digit is: " + digitArray[2]);
}