// //Задание1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// //причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// string CheckQuarter(double x, double y)
// {
//     if (x > 0 && y > 0)
//         return "I";
//     if (x < 0 && y > 0)
//         return "II";
//     if (x < 0 && y < 0)
//         return "III";
//     if (x > 0 && y < 0)
//         return "IV";
//     return "zero";
// }
// Console.WriteLine("Введите X:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y:");
// double y = Convert.ToDouble(Console.ReadLine());

// string result = CheckQuarter(x,y);
// if (result != "zero")
// {
//     Console.WriteLine($"Точка с координатами x = {x}, y = {y} находится в {result} четверти");
// }
// else
// {
//       Console.WriteLine("Вы указали начало координат х = 0, y = 0");
// }

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void CheckCoordinats (int quart)
// {
//     if (quart == 1)
//         Console.WriteLine ("Диапазон координат (х+, у+)");
//     if (quart == 2)
//         Console.WriteLine ("Диапазон координат (х-, у+)");
//     if (quart == 3)
//         Console.WriteLine ("Диапазон координат (х-, у-)");
//     if (quart == 4)
//         Console.WriteLine ("Диапазон координат (х+, у-)");
//     if (quart !=1 && quart !=2 && quart !=3 && quart !=4)
//         Console.WriteLine ($"Четверти {quart} не существует");
// }
// Console.WriteLine("Введите номер четверти:");
// int NumQuart = Convert.ToInt32(Console.ReadLine());
// CheckCoordinats(NumQuart);

//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void QuadNum(int N)
// {
//     int i = 1;
//     while (i <= N)
//     {
//         Console.WriteLine(i*i);
//         i++;
//     }
// }
// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// QuadNum(N);

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 2D пространстве.

double CheckDistance(double x1, double y1, double x2, double y2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)),2);
    return result;
}
Console.WriteLine("Координаты x1:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y1:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты x2:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y2:");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{CheckDistance(x1, y1, x2, y2)} - расстояние между первой точкой (х = {x1}, y = {y1}) и второй точкой (x = {x2}, y = {y2})");




