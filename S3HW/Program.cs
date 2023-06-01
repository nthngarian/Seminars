// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    Console.WriteLine("Пятизначное число");
    int firstDigit = number / 10000;
    int secondDigit = number % 10000 / 1000;
    int thirdDigit = number % 1000 / 100;
    int fourthDigit = number % 100 / 10;
    int fifthDigit =  number % 10;

    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}  
else
{
    Console.WriteLine("Не пятизначное число");
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками A:({x1},{y1},{z1}) и B:({x2},{y2},{z2}) равно: {Math.Round(d, 1)}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}
*/
