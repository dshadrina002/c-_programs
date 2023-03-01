// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
int[] StringToArray(string numbers)
{
    string[] str = numbers.Split(" ", StringSplitOptions.None);
    int[] res = new int[str.Length];
    for(int i = 0; i < str.Length; i++)
    {
        res[i] = int.Parse(str[i]);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    Console.Write($"Your array: [ ");
    for(int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.Write($"]");
}

void Counter(int[] outArray)
{
    int count = 0;
    for(int i = 0; i<outArray.Length; i++)
    {
        if(outArray[i]>0) count ++;
    }
    Console.WriteLine($"Кол-во положительных чисел в массиве {count}");
}

Console.Write("Задайте элементы массива через пробел: ");
string elements = Console.ReadLine()!;
int[] array = StringToArray(elements);
PrintArray(array);
Console.WriteLine();
Counter(array);