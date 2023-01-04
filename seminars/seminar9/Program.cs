//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintAllNaturalNumbers (int num)
// {
//     if (num > 1) 
//     {
//         PrintAllNaturalNumbers(num-1);
//         Console.Write($", {num}"); 
//     }
//     else
//     { 
//         Console.Write($"{num}");  
//     }
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// PrintAllNaturalNumbers(num);

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int SumOfDigits(int num)
// {
//     if (num > 9)
//     {
//        return SumOfDigits(num/10) + num%10;
//     }
//     else { return num;}
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine($"{SumOfDigits(num)} - сумма цифр числа {num}");

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void PrintNumberFromMintoMax (int minValue, int maxValue)
// {
//     if (minValue < maxValue) 
//     {
//         Console.Write($"{minValue}, ");
//         PrintNumberFromMintoMax(minValue+1,maxValue); 
//     }
//     else
//     { 
//         Console.Write($"{maxValue}");  
//     }
// }
// Console.WriteLine("Введите первое число:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M < N) { PrintNumberFromMintoMax(M,N); }
// else { PrintNumberFromMintoMax(N,M); }

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Exponentiate(int numbers, int degreeOf)
{
    if (degreeOf != 0)
    {
        if (degreeOf > 1)
        return Exponentiate(numbers, degreeOf-1) * numbers;
        else  return numbers; 
    }
    else return 1;
}
Console.WriteLine("Введите число, которое нужно возвести в степень:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень в которую нужно возвести число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exponentiate(a,b));


