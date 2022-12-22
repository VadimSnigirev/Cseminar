// //Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int sumall(int num)
// {
//     int sum = 1;
//     for (i=2; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число");
// Console.WriteLine($"{sumall(Convert.ToInt32(Console.ReadLine()))}");


//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// int AmountNum(int inputnum)
// {
//     int i = 0;
//     for (i=0;inputnum >= 1; i++)
//     {
//         inputnum = inputnum / 10;
//     }
//     return i;
// }
// Console.WriteLine("Введите число");
// Console.WriteLine($"{AmountNum(Convert.ToInt32(Console.ReadLine()))}");


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4 -> 24
//5 -> 120

// int Fuctorial(int num)
// {
//     int sum = 1;
//     for (int i=1; i <= num; i++)
//     {
//         sum = sum * i;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число");
// Console.WriteLine($"{Fuctorial(Convert.ToInt32(Console.ReadLine()))}");


//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива");
int maxNum = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(lenght, minNum, maxNum));