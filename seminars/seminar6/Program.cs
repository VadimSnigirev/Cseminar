// //Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// //а первый - на последнем и т.д.)

// //[1 2 3 4 5] -> [5 4 3 2 1]
// //[6 7 3 6] -> [6 3 7 6]

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

// int[] sortingArray(int[] array)
// {
//     for (int i=0;i<array.Length/2; i++)
//     {
//         int temp = array[i];
//            array[i] = array[array.Length-1-i];
//            array[array.Length-1-i] = temp;
//     }
//     return array;
// }
// Console.WriteLine("Введите размер массива");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int minNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int maxNum = Convert.ToInt32(Console.ReadLine());
// int[] newAr = CreateRandomArray(length, minNum,maxNum);
// ShowArray(newAr);
// sortingArray(newAr);
// ShowArray(newAr);

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// Boolean checkTriangle (int x, int y, int z)
// {
//     if (x+y>z && x+z>y && z+y>x)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
    

// }
// Console.WriteLine("Введите длину первой стороны:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину второйстороны:");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину третьей стороны:");
// int z = Convert.ToInt32(Console.ReadLine());
// if (checkTriangle(x,y,z) == true)
// {
//     Console.WriteLine($"Треугольник со сторонами длиной {x},{y},{z} существует");
// }
// else
// {
//     Console.WriteLine($"Треугольник со сторонами длиной {x},{y},{z} не существует");
// }


// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последующие это сумма двух передыдущих
// [0, 1, 1, 2, 3, 5, 8, 13, ... ]
// f(n) = f(n-1) + f(n-2)

// int[] fibonacciArray(int size, int a, int b)
// {
//     int[] array = new int[size+1];
//     array[0] = a;
//     array[1] = b;
//     for (int i=2; i<array.Length;i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
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

// Console.WriteLine("Какое количество чисел последовательности Фибоначчи, после введенных 2 чисел, необходимо вывести на экран?:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число последовательности:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число последовательности:");
// int b = Convert.ToInt32(Console.ReadLine());

// ShowArray(fibonacciArray(size,a,b));


// Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

string TenToTwo(int n)
{
    string rezult = string.Empty;
    while (n != 0)
    {
        rezult = n % 2 + rezult;
        n = n / 2;
    }
    return rezult;
}
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n} - это {TenToTwo(n)} в двоичной системе");