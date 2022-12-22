// //Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.

// //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindMinSum(int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sumPositive = sumPositive + array[i];
//         }
//         else
//         {
//             sumNegative = sumNegative + array[i];
//         }
//     }
//     Console.WriteLine($"Сумма положительных элементов {sumPositive}");
//     Console.WriteLine($"Сумма отрицательных элементов {sumNegative}");
// }
// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int minNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int maxNum = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, minNum, maxNum);
// ShowArray(newArray);
// FindMinSum(newArray);

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] changePositiveNegative(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }
// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int minNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int maxNum = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, minNum, maxNum);
// ShowArray(newArray);
// newArray = changePositiveNegative(newArray);
// ShowArray(newArray);

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

// // int[] CreateRandomArray(int size, int minValue, int maxValue)
// // {
// //     int[] newArray = new int[size];
// //     for (int i = 0; i < size; i++)
// //     {
// //         newArray[i] = new Random().Next(minValue, maxValue + 1);
// //     }
// //     return newArray;
// // }

// // void ShowArray(int[] array)
// // {
// //     Console.WriteLine("Полученный массив: ");
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// //     Console.WriteLine();
// // }

// // Boolean checkNum (int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int minNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int maxNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число, которое необходимо найти в массиве");
// int findnum = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, minNum, maxNum);
// ShowArray(newArray);
// if (checkNum (newArray,findnum) == true)
// {
//     Console.WriteLine ($"Число {findnum} присутствует во введенном ранее массиве");
// }
// else
// {
//     Console.WriteLine ($"Число {findnum} отсутствует во введенном ранее массиве");
// }


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int checkNumberDigits(int[] array, int digits)
{
    int rezult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int j = 0;
        if (array[i] == 0)
        {
            j = 1;
        }
        else
        {
            while (array[i] > 0)
            {
            j++;
            array[i] = array[i] / 10;
            }
        }
        if (digits == j)
        {
            rezult = rezult + 1;
        }
    }
    return rezult;
}

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива");
int maxNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число знаков, количество которых нужно посчитать в массиве (2 - если найти нужно двузначные, 3 - трехзначные и т.д.)");
int numdigits = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(length, minNum, maxNum);
ShowArray(newArray);
Console.WriteLine($"В заданном массиве {checkNumberDigits(newArray, numdigits)} {numdigits}-значных чисел");
