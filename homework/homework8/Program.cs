// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

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

// int[,] DescendingSortRowsArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 1; k < array.GetLongLength(1); k++)
//             {
//                 if (array[i,k-1] < array[i,k])
//                 { 
//                     int temp = array[i,k-1]; 
//                     array[i,k-1] = array[i,k];
//                     array[i,k] = temp;

//                 }
//             }           
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк:");
// int numberOfLines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int numberOfColumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] newRandomArray = Create2DRandomArray(numberOfLines, numberOfColumns, min, max);
// Show2DArray(newRandomArray);
// Console.WriteLine();
// newRandomArray = DescendingSortRowsArray(newRandomArray);
// Show2DArray(newRandomArray);

// _________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void FindRowWithMinSum (int[,] array)
// {
//     int numRow = 0;
//     int minSum = array[0,0];
//     for (int i = 1; i < array.GetLength(1); i++)
//     { minSum = minSum + array[0,i]; }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = array[i,0];
//         for (int j = 1; j < array.GetLength(1); j++)
//         { sum = sum + array[i,j]; }
//         if (minSum > sum)
//         { 
//             minSum = sum;
//             numRow = i;
//         }
//     }
//     Console.WriteLine($"{numRow} строка с наименьшей суммой элементов");
// }
// Console.WriteLine("Введите количество строк:");
// int numberOfLines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int numberOfColumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] newRandomArray = Create2DRandomArray(numberOfLines, numberOfColumns, min, max);
// Show2DArray(newRandomArray);
// Console.WriteLine();
// FindRowWithMinSum(newRandomArray);

// _______________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MatrixMultiplication(int[,] firstArray, int[,] secondArray)
// {
//     if (firstArray.GetLength(1) != secondArray.GetLength(0))
//     {
//         Console.WriteLine("Матрицы не согласованы: количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
//         int[,] result = new int [firstArray.GetLength(0), secondArray.GetLength(1)];
//         return result;
//     }
//     else
//     {
//     int[,] result = new int [firstArray.GetLength(0), secondArray.GetLength(1)];
//     for (int i = 0; i < firstArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondArray.GetLength(1); j++)
//         {
//             int temp = 0;
//             for (int k = 0; k < firstArray.GetLength(1); k++)
//             {
//                 temp = temp + firstArray[i,k] * secondArray[k,j];
//             }
//             result[i,j] = temp;
//         }
//     }
//     return result;
//     }

// }
// Console.WriteLine("Введите количество строк первой матрицы:");
// int numberOfLines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов первой матрицы:");
// int numberOfColumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение первой матрицы:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение первой матрицы:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] firstArray = Create2DRandomArray(numberOfLines, numberOfColumns, min, max);
// Console.WriteLine("Введите количество строк второй матрицы:");
// numberOfLines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов второй матрицы:");
// numberOfColumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение второй матрицы:");
// min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение второй матрицы:");
// max = Convert.ToInt32(Console.ReadLine());
// int[,] secondArray = Create2DRandomArray(numberOfLines, numberOfColumns, min, max);
// Console.WriteLine();
// // int[,] firstArray = new int[,] { {2,4}, {3,2} }; - тест для проверки
// // int[,] secondArray = new int[,] { {3,4}, {3,3} }; - тест для проверки
// Show2DArray(firstArray);
// Console.WriteLine();
// Show2DArray(secondArray);
// Console.WriteLine();
// int[,] resultArray = MatrixMultiplication(firstArray,secondArray);
// Show2DArray(resultArray);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void Show3DArray (int[,,] array3D)
// {
//     for (int z = 0; z < array3D.GetLength(2); z++)
//     {
//         for (int i = 0; i < array3D.GetLength(0); i++)
//         {
//             for (int j = 0; j < array3D.GetLength(1); j++)
//             {
//                 Console.Write($"{array3D[i,j,z]}({i},{j},{z}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// //работает с массивом не более 89 элементов
// int[,,] Create3DArrayTwoDigitNumbers(int rows, int columns, int depth) 
// {
//     int[,,]array3D = new int[rows,columns,depth];
//     Boolean CheckNumInArray (int [,,] array3D, int numberSearch)
//     {
//         for (int z = 0; z < array3D.GetLength(2); z++)
//     {
//         for (int i = 0; i < array3D.GetLength(0); i++)
//         {
//             for (int j = 0; j < array3D.GetLength(1); j++)
//             {
//                if (array3D[i,j,z] == numberSearch)
//                { return true; }
//             }
//         }
//     }
//     return false;
//     }
//     for (int z = 0; z < array3D.GetLength(2); z++)
//     {
//         for (int i = 0; i < array3D.GetLength(0); i++)
//         {
//             for (int j = 0; j < array3D.GetLength(1); j++)
//             {
//                 int temp = new Random().Next(10, 100);
//                 while (CheckNumInArray (array3D, temp) == true)
//                 { temp = new Random().Next(10, 100); }
//                 array3D[i,j,z] = temp;
//             }
//         }
//     }
//     return array3D;
// }
// Console.WriteLine("Введите количество строк:");
// int numberOfLines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int numberOfColumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите глубину трехмерного массива:");
// int depth3DArray = Convert.ToInt32(Console.ReadLine());
// int[,,] array3D = Create3DArrayTwoDigitNumbers(numberOfLines, numberOfColumns, depth3DArray);
// Console.WriteLine();
// Show3DArray(array3D);

//___________________________________________________________________________________________________

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] CreateSpiralArray(int rows, int columns, int minValue)
{
    int [,] array = new int [rows,columns];
    int upperBorderRows = array.GetLength(0);
    int upperBorderColumns = array.GetLength(1);
    int bottomBorderRows = 1;
    int bottomBorderColumns = 0;
    int movementChange = 0;
    int numColumn = 0;
    int numRow = 0;
    int i = 0;
    while (i<(rows*columns))
    {
        if (movementChange == 0)
        {
            while (numColumn < upperBorderColumns)
            { array[numRow,numColumn] = minValue + i; i++; numColumn++; }
            numColumn--;
            numRow++;
            while (numRow < upperBorderRows)
            { array[numRow,numColumn] = minValue + i; i++; numRow++; }
            numColumn--;
            numRow--;
            movementChange = 1;
            upperBorderRows--;
            upperBorderColumns--;
        }
        else 
        {
            while (numColumn >= bottomBorderColumns)
            { array[numRow,numColumn] = minValue + i; i++; numColumn--; }
            numColumn++;
            numRow--;
            while (numRow >= bottomBorderRows)
            { array[numRow,numColumn] = minValue + i; i++; numRow--; }
            numRow++;
            numColumn++;
            movementChange = 0;
            bottomBorderRows++;
            bottomBorderColumns++;
        }
    }
    return array;
}
Console.WriteLine("Введите количество строк:");
int numberOfLines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] newRandomArray = CreateSpiralArray(numberOfLines, numberOfColumns, min);
Show2DArray(newRandomArray);
Console.WriteLine();