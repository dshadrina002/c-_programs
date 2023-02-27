// заполняем массив

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    for(int i = 0; i<inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }   
}

int[] array = GetArray(12, -9, 9);
PrintArray(array);

int positiveSum = 0;
int negativeSum = 0;

foreach(int el in array)
{
    if(el>0)
    {
        positiveSum +=el;
    }
    else
    {
        negativeSum +=el;
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел {positiveSum}, Сумма отрицательных элементов {negativeSum}");