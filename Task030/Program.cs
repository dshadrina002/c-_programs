void FillArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    collection[i] = new Random().Next(0, 2);
}

void PrintArray(int[] col)
{
    for(int i = 0; i < col.Length; i++)
    Console.Write($"{String.Join(", ", col[i])}");
}
Console.WriteLine("Enter the array length: ");
int N = int.Parse(Console.ReadLine()!);
int [] array = new int[N];
Console.WriteLine("Your array: ");
FillArray(array);
PrintArray(array);