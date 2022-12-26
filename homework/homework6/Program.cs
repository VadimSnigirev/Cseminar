// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] createArray(string inputArray) //функция из прошлых дз, переводит строку в массив чисел
// {
//     int i = 0;
//     int size = 0;
//     inputArray = inputArray + " ";
//     while (i < inputArray.Length - 1) //узнаю длину нового массива чисел, так как не знаю можно ли задать динамический размер массиву
//     {
//         if (Char.IsDigit(inputArray[i]) == true)
//         {
//             int j = 1;
//             while (Char.IsDigit(inputArray[i + j]) == true)
//             {
//                 j++;

//             }
//             i = i + j + 1;
//             size = size + 1;
//         }
//         else
//         {
//             i++;
//         }

//     }
//     int[] numArray = new int[size]; // объявляю массив нужного размера и заполняю его
//     size = 0;
//     i = 0;
//     while (i < inputArray.Length)
//     {
//         if (Char.IsDigit(inputArray[i]) == true || inputArray[i] == '-')
//         {
//             int j = 1;
//             string temp = $"{inputArray[i]}";
//             while (Char.IsDigit(inputArray[i + j]) == true) 
//             {
//                 temp = temp + inputArray[i + j];
//                 j++;
//             }
//             numArray[size] = Convert.ToInt32(temp);
//             i = i + j;
//             size = size + 1;
//         }
//         else
//         {
//             i++;
//         }

//     }
//     return numArray;
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

// int checkPositiveNum(int[] array)
// {
//     int rezult = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             rezult++;
//         }
//     }
//     return rezult;
// }

// Console.WriteLine("Введите элементы массива (например 1,5,6,11):");
// int[] inputArray = createArray(Console.ReadLine());
// ShowArray(inputArray);
// Console.WriteLine($"{checkPositiveNum(inputArray)} - положительных чисел ввел пользователь");

// __________________________________________________________________________________________________________________

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] pointOfIntersection(double b1, double k1, double b2, double k2)
{
    double[] result = new double[3];
    if (k1 != k2)
    {
        result[0] = Math.Round((-b1 + b2) / (k1 - k2), 2);
        result[1] = Math.Round((k1 * result[0] + b1), 2);
        result[2] = 1;
        return result;
    }
    else
    {
        if (b1 != b2)
        {
            result[2] = 2;
            return result;
        }
        else
        {
            result[2] = 0;
            return result;
        }
    }
}
Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double[] IntPoint = pointOfIntersection(b1, k1, b2, k2);

if (IntPoint[2] == 1)
{
    Console.WriteLine($"({IntPoint[0]}, {IntPoint[1]}) - точка переcечения двух прямых заданных уравнениями:");
    Console.WriteLine($"y = {k1}x + {b1}");
    Console.WriteLine($"y = {k2}x + {b2}");
}
else
{
    if (IntPoint[2] == 0)
    {
        Console.WriteLine("Прямые заданные уравнениями ниже - совпадают");
        Console.WriteLine($"y = {k1}x + {b1}");
        Console.WriteLine($"y = {k2}x + {b2}");
    }
    else
    {
        Console.WriteLine("Прямые заданные уравнениями ниже - не пересекаются");
        Console.WriteLine($"y = {k1}x + {b1}");
        Console.WriteLine($"y = {k2}x + {b2}");
    }
}


