// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
Console.WriteLine("Введите количество строк:");
int rowsVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int columnsVol = Convert.ToInt32(Console.ReadLine());

int[,] Numbers = new int[rowsVol, columnsVol];

FillArrayRandomNumbers(Numbers);
Console.WriteLine("Массив:");
PrintArray(Numbers);

for (int i = 0; i < Numbers.GetLength(0); i++)
{
    for (int j = 0; j < Numbers.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < Numbers.GetLength(1) - 1; k++)
        {
            if (Numbers[i, k] < Numbers[i, k + 1])
            {
                int temp = 0;
                temp = Numbers[i, k];
                Numbers[i, k] = Numbers[i, k + 1];
                Numbers[i, k + 1] = temp;
            }
        }
    }
}

Console.WriteLine("Массив с упорядоченными значениями:");
PrintArray(Numbers);

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

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
Console.WriteLine("Введите размер квадратного массива:");
int arrayVol = Convert.ToInt32(Console.ReadLine());

int[,] Numbers = new int[arrayVol, arrayVol];

FillArrayRandomNumbers(Numbers);
Console.WriteLine("Массив:");
PrintArray(Numbers);

int minSum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < Numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < Numbers.GetLength(1); j++)
    {
        sum = sum + Numbers[i, j];        
    }
    if (sum < minSum)
    {
        minSum = sum;
        indexLine++;
    }
}

Console.WriteLine("Номер строки с наименьшей суммой элементов:");
Console.WriteLine(indexLine);
Console.WriteLine($"Сумма элементов {indexLine} строки:");
Console.WriteLine(minSum);

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

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int InputInt(string output)
{
    Console.WriteLine(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int size = InputInt("Введите размер массивов:");
int[,] firstArray = new int[size, size];
int[,] secondArray = new int[size, size];
FillArrayRandomNumbers(firstArray);
FillArrayRandomNumbers(secondArray);
int[,] resultArray = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            resultArray[i, j] = resultArray[i, j] + (firstArray[i, k] * secondArray[k, j]);
        }
    }
}

Console.WriteLine("Массив №1:");
PrintArray(firstArray);
Console.WriteLine("Массив №2:");
PrintArray(secondArray);
Console.WriteLine("Произведение массивов №1 и №2:");
PrintArray(resultArray);
*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int sizeX = InputInt("Введите размерность X: ");
int sizaY = InputInt("Введите размерность Y: ");
int sizeZ = InputInt("Введите размерность Z: ");
int countNumbers = 59;

if (sizeX * sizaY * sizeZ > countNumbers)
{
    Console.WriteLine("Результат:");
    Console.WriteLine("Массив слишком БОЛЬШОЙ!");
    return;
}

int[,,] resultNumbers = Create3DArray(sizeX, sizaY, sizeZ);

Console.WriteLine("Результат:");

for (int i = 0; i < resultNumbers.GetLength(0); i++)
{
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
        for (int k = 0; k < resultNumbers.GetLength(2); k++)
        {
            Console.WriteLine($"{resultNumbers[i, j, k]} ({i}, {j}, {k})");
        }  
    }
    Console.WriteLine();
}

int[,,] Create3DArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] val = new int[countNumbers];
    int Number = 10;
    for (int i = 0; i < val.Length; i++)
        val[i] = Number++;

    for (int i = 0; i < val.Length; i++)
    {
        int randomIndex = new Random().Next(0, val.Length);
        int temp = val[i];
        val[i] = val[randomIndex];
        val[randomIndex] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = val[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{
    Console.WriteLine(output);
    return int.Parse(Console.ReadLine());
}
*/

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[size, size];

int startNumber = 1;
int i = 0;
int j = 0;

while (startNumber <= size * size)
{
    numbers[i, j] = startNumber;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++startNumber;
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    Console.WriteLine("Спирально заполненный массив:");
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