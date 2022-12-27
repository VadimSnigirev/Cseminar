// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomDoubleArray(int rows, int columns, double minValue, double maxValue)
// {
//     double[,] newArray = new double[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = Math.Round(new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue) + 1) + new Random().NextDouble(), 2);
//             while (newArray[i,j] < minValue || newArray[i,j] > maxValue)
//             {
//                 newArray[i,j] = Math.Round(new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue) + 1) + new Random().NextDouble(), 2);
//             }
//         }
//     }
//     return newArray;
// }

// void ShowDouble2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение:");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение:");
// double max = Convert.ToDouble(Console.ReadLine());
// double[,] NewRandomArray = Create2DRandomDoubleArray(m, n, min, max);
// ShowDouble2DArray(NewRandomArray);

// _________________________________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// double[,] Create2DRandomDoubleArray(int rows, int columns, double minValue, double maxValue)
// {
//     double[,] newArray = new double[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = Math.Round(new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue) + 1) + new Random().NextDouble(), 2);
//             while (newArray[i,j] < minValue || newArray[i,j] > maxValue)
//             {
//                 newArray[i,j] = Math.Round(new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue) + 1) + new Random().NextDouble(), 2);
//             }
//         }
//     }
//     return newArray;
// }

// void ShowDouble2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ShowArrayElement(int lineNumber, int columnNumber, double[,] array)
// {
//     if (lineNumber < array.GetLength(0) && columnNumber < array.GetLength(1))
//     { Console.WriteLine($"{array[lineNumber, columnNumber]} - значение элемента массива на позиции [{lineNumber},{columnNumber}]"); }
//     else
//     { Console.WriteLine($"Элемента с позицией [{lineNumber},{columnNumber}] не существует в массиве"); }
// }
// double[,] NewRandomArray = Create2DRandomDoubleArray(6, 8, -9, 9);
// ShowDouble2DArray(NewRandomArray);
// Console.WriteLine();
// Console.WriteLine("Введите номер строки:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца:");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowArrayElement(m,n,NewRandomArray);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void ShowInt2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void arithmeticEachColumn(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        { result = result + array[j, i]; }
        Console.Write($" {Math.Round(result / array.GetLength(0), 2)};");
    }
    Console.WriteLine();
}
// можно было задать методом рандомного заполнения, но для тренировки объявил массив строчкой ниже
int[,] myArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
ShowInt2DArray(myArray);
arithmeticEachColumn(myArray);