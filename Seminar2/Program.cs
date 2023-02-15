// int number = new Random().Next(10, 99);
// Console.WriteLine("Random number: " + number);
// int digit1 = Convert.ToInt32(number / 10);
// int digit2 = number % 10;
// if(digit1 == digit2)
//     {
//         Console.WriteLine(digit1);
//     }
//     else
//     {
//         if(digit1 > digit2)
//         {
//             Console.WriteLine("Greater digit is: " + digit1);
//         }
//         else
//         {
//             Console.WriteLine("Greater digit is: " + digit2);
//         }
//     }

// Console.Write("Random number 1:");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Random number 2:");
// int number2 = int.Parse(Console.ReadLine());
// if(number1 % number2 == 0)
//     {
//         Console.WriteLine("Число 1 делится на Число 2 без остатка");
//     }
//     else
//     {
//         Console.WriteLine("Число 1 не делится на Число 2 без остатка");
//         Console.WriteLine("Остаток: " + number1 % number2);
//     }    

// Console.Write("Random number 1:");
// int number1 = int.Parse(Console.ReadLine());
// if(number1 % 7 ==0 && number1 % 23 == 0)
//     {
//         Console.WriteLine("Число 1 делится 23 и 7 без остатка");
//     }
//     else
//     {
//         Console.WriteLine("Число 1 не делится на 23 и 7 без остатка");
//     }

// Console.Write("Random number 1:");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Random number 2:");
// int number2 = int.Parse(Console.ReadLine());
// if(Math.Pow(number1, 2) == number2)
//     {
//         Console.WriteLine("Число 1 делится на Число 2 без остатка");
//     }
//     else
//     {
//         Console.WriteLine("Число 1 не делится на Число 2 без остатка");
//         Console.WriteLine("Остаток: " + number1 % number2);
//     } 



int randomNumber = new Random().Next(100, 1000);
char[] digits = randomNumber.ToString().ToCharArray();
int[] digitArray = new int[digits.Length];
for (int i = 0; i < digits.Length; i++)
{
    digitArray[i] = int.Parse(digits[i].ToString());
}
Console.WriteLine("Random number: " + randomNumber);
Console.WriteLine("Digits: " + string.Join(",", digitArray));