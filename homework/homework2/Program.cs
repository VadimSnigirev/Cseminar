// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// int SecondNumeral(int num)
// {
//     int SecondNum = (num - (num/100*100 + num % 10))/10;
//     return SecondNum;
// }

// Console.WriteLine("Введите трехзначное число");
// int NumOfThrees = Convert.ToInt32(Console.ReadLine());
// int result = SecondNumeral(NumOfThrees);
// Console.WriteLine($"{result} - вторая цифра числа {NumOfThrees}");

// __________________________________________________________________________________________________________________

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// String CheckThreesNum (int num)
// {
//     if (num < 100)
//     {
//         return $"В числе {num} третьей цифры нет";
//     }
//     else
//     {
//         int temp = num;
//         while (temp > 1000)
//         {
//             temp = temp / 10;
//         }
//         return $"{temp % 10} - 3 цифра числа {num}";
//     }
// }
// Console.WriteLine("Введите число");
// int InpNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CheckThreesNum(InpNum));

// __________________________________________________________________________________________________________________

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Boolean CheckWeekend(int num)
{
    if (num != 6 && num != 7)
    {
        return false;
    }
    else 
    {
        return true;
    }  
}

Console.WriteLine("Введите цифру");
int InpNum = Convert.ToInt32(Console.ReadLine());
if (CheckWeekend(InpNum) == false)
{
    Console.WriteLine($"{InpNum} - рабочий день");
}
else
{
    Console.WriteLine($"{InpNum} - выходной день");
}