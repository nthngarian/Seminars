// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
Console.Write("Введите число А: ");
double A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
double res = 1.0;

if (B < 0)
{
    (A, B) = (1.0 / A, -B);
}
for (; B != 0; A *= A, B /=2)
{
    if (B % 2 != 0)
    {
        res *= A;
    }
}
Console.WriteLine(res);
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number != 0)
{
    sum = sum + number % 10;
    number /= 10; 
}
sum = sum + number;
Console.WriteLine("Сумма цифр в числе равна: " + sum);
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int size = 8;
int[] array = new int[size]; // Массив из 8 элементов: в массиве изначально 8 нулей

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 100);
}
Console.WriteLine($"Массив: [{String.Join("; ",array)}]");
*/
