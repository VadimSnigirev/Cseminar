// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int multiplication (int a, int b)
// {
//     int rezult = a;
//     for (int i = 1; i < b; i++)
//     {
//         rezult = rezult * a;
//     }
//     return rezult;
// }
// Console.WriteLine("Введите число для возведения в степень:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень, в которую нужно возвести число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{a} в {b} степени равно {multiplication(a,b)}");

//_____________________________________________________________________________________________________________________

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void sumNumber(int num)
// {
//     int rezult = 0;
//     int temp = num;
//     for (int i = 1; temp > 0; i++)
//     {
//         rezult = rezult + temp % 10;
//         temp = temp / 10;
//     }
//     Console.WriteLine($"{rezult} - сумма цифр в числе {num}");
// }
// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// sumNumber(a);

//_____________________________________________________________________________________________________________________

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Решил усложнить задачу. Программа из вводимой строки символов создает массив int и выводит на экран.

//Введите элементы массива (например 1,5,6,11):
// 1,2,5,7,19
// Полученный массив: 
// 1 2 5 7 19

// Введите элементы массива (например 1,5,6,11):
// 313afas34,3421,1 2vas123,11
// Полученный массив: 
// 313 34 3421 1 2 123 11



int[] createArray(string inputArray)
{
    int i = 0;
    int size = 0;
    inputArray = inputArray + " ";
    while (i < inputArray.Length-1) //узнаю длину нового массива чисел, так как не знаю можно ли задать динамический размер массиву
    {
        if (Char.IsDigit(inputArray[i]) == true)
        {
            int j = 1;
            while (Char.IsDigit(inputArray[i + j]) == true)
            {
                j++;

            }
            i = i + j+1;
            size = size + 1;
        }
        else
        {
            i++;
        }

    }
    int[] numArray = new int[size]; // объявляю массив нужного размера и заполняю его
    size = 0;
    i = 0;
    while (i < inputArray.Length)
    {
        if (Char.IsDigit(inputArray[i]) == true)
        {
            int j = 1;
            string temp = $"{inputArray[i]}";
            while (Char.IsDigit(inputArray[i + j]) == true)
            {
                temp = temp + inputArray[i + j];
                j++;

            }
            numArray[size] = Convert.ToInt32(temp);
            i = i + j+1;
            size = size + 1;
        }
        else
        {
            i++;
        }

    }
    return numArray;
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
Console.WriteLine("Введите элементы массива (например 1,5,6,11):");
ShowArray(createArray(Console.ReadLine()));