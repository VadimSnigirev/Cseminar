// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int DeleteNumeral (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot*10 + ed;
// }

// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = DeleteNumeral(randomNumber);
// Console.WriteLine(result);

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

String DetMult (int num)
{
    if (num % 7 == 0)
    {
        if (num % 23 == 0)
        {
            return $"{num} кратно 7 и 23";
        }
        else {{return $"{num} не кратно 7 и 23";}}
    }
    else {return $"{num} не кратно 7 и 23";}
}
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number);
Console.WriteLine(DetMult(Number));
