// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// int firstnum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondnum = Convert.ToInt32(Console.ReadLine());
// if (firstnum > secondnum)
//     {
//     Console.WriteLine($"{firstnum} больше чем {secondnum}");
//     }
// else
//     {
//     Console.WriteLine($"{secondnum} больше чем {firstnum}");
//     }

// __________________________________________________________________________________________________________

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число");
// int firstnum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondnum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int thirdnum = Convert.ToInt32(Console.ReadLine());
// int max = firstnum;
// if (max < secondnum)
//     {
//         max = secondnum;
//         if (max < thirdnum)
//             {
//                 max = thirdnum;
//             }
//     }
// else
//     {
//         if (max < thirdnum)
//             {
//                 max = thirdnum;
//             }
//     }
// Console.WriteLine($"Максимальное число {max}");

// __________________________________________________________________________________________________________

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N % 2 == 0)
//     {
//         Console.WriteLine($"{N} - четное число");
//     }
// else
//     {
//          Console.WriteLine($"{N} - нечетное число");
//     }

// __________________________________________________________________________________________________________

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.WriteLine($"Четные числа от 1 до {N}");
while (i <= N-2)
    {
        Console.Write($"{i}, ");
        i+=2;
        
    }
Console.Write(i);