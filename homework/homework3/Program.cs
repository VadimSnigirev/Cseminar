// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

//для себя решил немного заморочиться и сделал алгоритм для любого целого числа
//сделал через string для тренировки, так как дз второго семинара делал задания через поиск цифр (/ и %)

//void CheckPalindrome(string num) 
// {
//     int i = 0;
//     while (num[i] == num[num.Length-1-i])
//     {
//         if (i > num.Length/2)
//         {
//             Console.WriteLine($"{num} - является палиндромом");
//             break;
//         }   
//         i++;
//     }
//     if (i < num.Length/2)
//     {
//          Console.WriteLine($"{num} - не является палиндромом");
//     } 
// }
// Console.WriteLine("Введите число");
// CheckPalindrome(Console.ReadLine());

// _________________________________________________________________________________________________________________________

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double CheckDistance(double x1, double y1, double x2, double y2, double z1, double z2)
// {
//     double result = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
//     return result;
// }
// Console.WriteLine("Координаты x1:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y1:");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z1:");
// double z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты x2:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y2:");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z2:");
// double z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{CheckDistance(x1, y1, x2, y2, z1, z2)} - расстояние между первой точкой (х={x1}, y={y1}), z={z1} и второй точкой (x={x2}, y={y2}, z={z2})");

// _________________________________________________________________________________________________________________________

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeNum(int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
CubeNum(N);