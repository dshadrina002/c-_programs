// string text = "KoronaPay создает fintech-продукт нового поколения веб- и мобильное приложение для системы денежных переводов"
//             + "которая интенсивно развивается и выходит на новые рынки."
//             + "Наша цель создавать удобные и доступные финансовые сервисы, чтобы помочь людям быть ближе друг к другу.";

// string Replace(string text, char oldValue, char newValue)
//  {
//     string result = String.Empty;

//     int lenght = text.Lenght;
//     for(int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
    
//     return result;
//  }

//  string newText = Replace(text, ' ', '|');
//  Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPossition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPossition]) minPossition = j;
        }

        int temporary = array[i];
        array[i] = array[minPossition];
        array[minPossition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);