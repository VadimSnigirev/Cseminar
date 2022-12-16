// Console.WriteLine("Введите число");
// int numQ = Convert.ToInt32(Console.ReadLine());
// int y = numQ*numQ;
// Console.WriteLine($"Quad if {numQ} -> {y}");


// Проверка, является ли 1 число квадратом 2

// Console.WriteLine("Введите число а");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b*b)
// {
//     Console.WriteLine($"Число {a} равно {b} в квадрате");
// }
// else
// {
//     Console.WriteLine($"Число {a} не равно {b} в квадрате");
// }

//. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = -N;
// while (i<=N)
//     {
//     Console.Write($"{i}, ");
//     i++;
//     }
// Console.Write(N);

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());
int ost = N % 10;
Console.WriteLine($"Последняя числа нашего прекрасного числа, {ost}");
