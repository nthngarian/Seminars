// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [5, 5];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine($"Значение элемента {n} строки {m} столбца:");
    Console.WriteLine("Такого элемента в массиве НЕТ.");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки {m} столбца:");
    Console.WriteLine(numbers[n-1, m-1]);
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void AvarageOfColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++) 
    {
        double sum = 0; // Среднее арифм.
        for (int j = 0; j < array.GetLength(0); j++)
        {
            
            sum = sum + array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца:"); 
        Console.WriteLine(Math.Round(sum / array.GetLength(0), 1));
    }
}
AvarageOfColumn(numbers);
*/
