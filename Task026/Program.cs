// Программа принимает на вход число А и выдает произведение от 1 до N
int GetMul(int n)
{
    int result = 1;
    int i = 2;
    if(n < 0)
    {
        i=n;
        n=-1;
    }
    for(int i = 1; i <= n; i++)
    {
        result *= i; //sum = sum + i;
    }
    return result;
}
Console.Write("Enter the number: ");
int A = int.Parse(Console.ReadLine()!);
int res = GetMul(A);
Console.Write($"Sum from 1 to {A} is {res}");
