// Программа принимает на вход число А и выдает сумму чисел от 1 до А
int GetSum(int n)
{
    int sum = 0;
    for(int i = 0; i <= n; i++)
    {
        sum += i; //sum = sum + i;
    }
    return sum;
}
Console.Write("Enter the number: ");
int A = int.Parse(Console.ReadLine()!);
int result = GetSum(A);
Console.Write($"Sum from 1 to {A} is {result}");