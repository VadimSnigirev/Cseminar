// //Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
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
// Console.WriteLine("Введите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] NewRandomArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(NewRandomArray);

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int[,] CreateArrayRowsPlusColumns (int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = i + j;
//         }
//     }
//     return newArray;
// }
// Console.WriteLine("Введите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] newArray = CreateArrayRowsPlusColumns(m,n);
// Show2DArray(newArray);


//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81 ** 2 **9**
//8 4 2 4

// int[,] ChangeEvenToSquare(int[,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i+=2)
//     {
//         for (int j = 1; j < array.GetLength(1); j+=2)
//         {
//             { array[i, j] = array[i, j] * array[i, j]; }
//         }
//     }
//     return array;
// }
// Console.WriteLine("Введите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] NewRandomArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(NewRandomArray);
// Console.WriteLine();
// Show2DArray(ChangeEvenToSquare(NewRandomArray));


//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2 Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12

void FindSummMainDiagonal(int[,] array)
{
    Console.Write($"Сумма элементов главной диагонали: {array[0,0]}");
    int size = array.GetLength(0);
    if (array.GetLength(0) > array.GetLength(1))
    { size = array.GetLength(1); }
    int result = array[0, 0];
    for (int i = 1; i < size; i++)
    {
        result = result + array[i, i];
        Console.Write($"+{array[i,i]}");
    }
    Console.WriteLine($" = {result}");
}

Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] NewRandomArray = Create2DRandomArray(m, n, min, max);
Show2DArray(NewRandomArray);
Console.WriteLine();
FindSummMainDiagonal(NewRandomArray);