// Задайте двумерный массив, напишите программу, которая меняет местами любые две строки массива

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

// int[,] ChangePositionRows(int[,] array, int numFirstRow, int numSecondRow)
// {
//     if 
//         (numFirstRow < array.GetLength(0) || numFirstRow >= array.GetLength(0) ||
//         numSecondRow < array.GetLength(0) || numSecondRow >= array.GetLength(0))
//         {
//             Console.WriteLine ("Массив не изменен. Введите корректные номера строк для обмена");
//             return array;
//         }
//     else
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             int temp = array[numFirstRow, i];
//             array[numFirstRow, i] = array[numSecondRow, i];
//             array[numSecondRow, i] = temp;
//         }
//         return array;
//     }
// }
// Console.WriteLine("Введите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первый номер строки массива для обмена:");
// int firstRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второй номер строки массива для обмена:");
// int SecondRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] newRandomArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(newRandomArray);
// Console.WriteLine();
// newRandomArray = ChangePositionRows(newRandomArray, firstRow, SecondRow);
// Show2DArray(newRandomArray);

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы, если это не возможно - программа
// должна вывести сообщение для пользователя

// int[,] ChangeRowsOnColumns(int[,] array)
// {
//     int[,] changedArray = new int[array.GetLength(1), array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             { changedArray[j,i] = array[i,j]; }
//         }
//     return changedArray;
// }
// Console.WriteLine("Введите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] newRandomArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(newRandomArray);
// Console.WriteLine();
// newRandomArray = ChangeRowsOnColumns(newRandomArray);
// Show2DArray(newRandomArray);

// Из двумерного массива целых чисел удалить строку и столбец на пересечении которых расположен наименьший элемент

int [,] DeleteRowColumnWithMinNum (int[,] array)
{
    int min = array[0,0];
    int rowMinNum = 0;
    int columnMinNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i,j])
            {
                min = array[i,j];
                rowMinNum = i;
                columnMinNum = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(1); i++)
    { array[rowMinNum,i] = 0; }
    for (int i = 0; i < array.GetLength(0); i++)
    { array[i,columnMinNum] = 0; }
    return array;
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
int[,] newRandomArray = Create2DRandomArray(m, n, min, max);
Show2DArray(newRandomArray);
Console.WriteLine();
newRandomArray = DeleteRowColumnWithMinNum(newRandomArray);
Show2DArray(newRandomArray);