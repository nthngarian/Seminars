// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine();
Console.WriteLine($"Кол-во чисел в массиве = {numbers.Length}");
Console.WriteLine($"Кол-во чётных чисел в массиве = {count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 1; i < numbers.Length; i += 2)
    sum += numbers[i];

    Console.WriteLine();
    Console.WriteLine($"Кол-во чисел в массиве = {numbers.Length}");
    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = new Random().Next(1,10);
        }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
        {
            Console.Write(numbers[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}

Console.WriteLine();
Console.WriteLine($"Кол-во чисел в массиве = {numbers.Length}");
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int j = 0; j < numbers.Length; j++)
        {
            Console.Write(numbers[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/