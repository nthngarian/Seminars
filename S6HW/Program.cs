// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length]; // length = 5, 5 нулей
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Массив: [{string.Join("; ", numbers)}]");
Console.WriteLine($"Количество положительных элементов: {count}");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double axisX = (b2 - b1) / (k1 - k2);
double axisY = k1 * axisX + b1;

Console.WriteLine($"Точка пересечения двух прямых = X: {Math.Ceiling(axisX)}, Y: {Math.Ceiling(axisY)}");
*/
