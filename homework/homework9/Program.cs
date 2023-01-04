// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintAllNaturalNumbers (int num)
// {
//     if (num > 1) 
//     {
//         Console.Write(num+", "); 
//         PrintAllNaturalNumbers(num-1);
//     }
//     else { Console.Write(num);}
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintAllNaturalNumbers(num);

// _______________________________________________________________________________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumBetweenNumbers (int lowerValue, int greaterValue)
// {
//     if (lowerValue < greaterValue) 
//     return SumBetweenNumbers(lowerValue+1,greaterValue)+lowerValue; 
//     else
//     return greaterValue;  
// }
// Console.WriteLine("Введите первое число:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M < N) Console.WriteLine(SumBetweenNumbers(M,N));
// else  Console.WriteLine(SumBetweenNumbers(N,M));

// ___________________________________________________________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//       if ((n != 0) && (m == 0))
//         return Akkerman(n - 1, 1);
//     else
//         return Akkerman(n - 1, Akkerman(n, m - 1));
// }
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
 
Console.WriteLine(Akkerman(2, 3));
Console.WriteLine(Akkerman(3, 2));