// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

// void numParity(int[]array)
// {
//     int evenNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             evenNum = evenNum + 1;
//         }
//     }
//     Console.WriteLine($"{evenNum} четных в массиве выше");
// }
// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int minNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int maxNum = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, minNum, maxNum);
// ShowArray(newArray);
// numParity(newArray);

//__________________________________________________________________________________________________________________________________

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// int findSumOddPos(int[] array)
// {
//     int rezult = 0;
//     for (int i = 0; i < array.Length; i += 2)
//     {
//         rezult = rezult + array[i];
//     }
//     return rezult;
// }
// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int minNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int maxNum = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, minNum, maxNum);
// ShowArray(newArray);
// int summOddPos = findSumOddPos(newArray);
// Console.WriteLine($"{summOddPos} - сумма элементов массива на нечетных позициях");

//__________________________________________________________________________________________________________________________________

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateRandomDoubleArray(int size, double minValue, double maxValue) //заполнение массива случайными числами в пределах границ введенных вещественных чисел
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round(new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue) + 1) + new Random().NextDouble(), 2);
        while (newArray[i] < minValue || newArray[i] > maxValue)
        {
            newArray[i] = Math.Round(new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue) + 1) + new Random().NextDouble(), 2);
        }
    }
    return newArray;
}

void ShowDoubleArray(double[] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void differenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
        if (array[i] > max)
        max = array[i];
    }
    Console.WriteLine($"{max - min} - это разница между максимальным элементом массива = {max} и минимальным = {min}");
}

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива");
double minNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива");
double maxNum = Convert.ToDouble(Console.ReadLine());
double[] newArray = CreateRandomDoubleArray(length, minNum, maxNum);
ShowDoubleArray(newArray);
differenceMaxMin(newArray);









// Console.WriteLine($"{Math.Round(5.1 - Math.Floor(5.1),2)}");
// Console.WriteLine($"{Math.Round(5.9 - Math.Floor(5.9),2)}");
// Console.WriteLine($"{Math.Round(-5.3 - Math.Ceiling(-5.3),2)}");
// Console.WriteLine($"{Math.Round(-5.6 - Math.Ceiling(-5.6),2)}");