int DigitSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n = n/10;
    }
    return sum;
}
Console.Write("Enter the number: ");
int A = int.Parse(Console.ReadLine()!);
int res = DigitSum(A);
Console.Write($"Sum of {A} digits is {res}");