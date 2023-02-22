// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Stepen(int A, int B)
{
    int result = 1;
    for(int i = 0; i < B; i++)
    {
        result *= A; //sum = sum + i;
    }
    return result;
}
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine()!);
if(B<0)
{
    Console.Write("Число В не должно быть меньше нуля");
}
else
{
    int result = Stepen(A, B);
    Console.Write($"А в степени В равно {result}");
}