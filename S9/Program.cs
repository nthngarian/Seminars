/*
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // Таблица из m строк и n столбцов 
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам , i < m
    {
        // i,j,m,k 
        for (int j = 0; j < matrix.GetLength(1); j++)// Цикл по стобцам , j < n
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

// Метод, который печатает массив 
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write(array[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine();
    }
}

int GetRowNumber(int[,] matrix)
{
    int rowWithMinSum = 0;
    int minSum = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSum = minSum + matrix[0, i]; // minSum = сумме элементов 0 строчки
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j]; // сумма элементов текущей строчки, начиная от 1
        }
        if (sum < minSum)
        {
            minSum = sum; // Если сумма текущей строчки меньше предп-й мин. суммы, то мы
            // перезаписываем переменную
            rowWithMinSum = i;
        }
    }
    return rowWithMinSum;
}

int[,] matr = GetMatrix(3, 5, 0, 10); // Матрица 5 на 5, элемент - рандомное число от 0 до 10 вклю-то
PrintMatrix(matr);

Console.WriteLine($"Строчка с наименьшей суммой: {GetRowNumber(matr)}");
*/

/*
int[,] GetProductMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    // строчки = кол-во строк из первой матрицы(i), столбцы = кол-во столбцов из второй матрицы(j)
    for (int i = 0; i < firstMatrix.GetLength(0); i++) // строчки первой матрицы
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++) // столбцы второй матрицы
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++) // столбцы первой матрицы
            {
                resMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                // resMatrix = resMatrix + firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resMatrix;

}
*/



// int Factorial(int value)
// {
//     // Базовый случай - случай выхода из рекурсии, бесконечный вызов
//     if (value == 1) return 1;
//     // Рекурсивный случай - задание рекурсии
//     return value * Factorial(value - 1);
// }
// int N = 4;
// Console.WriteLine($"Факториал от числа {N} = {Factorial(N)}");

// C# XML Documentation Comments

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печать чисел от 1 до N
/// </summary>
/// <param name="start"> левая граница (1)</param>
/// <param name="end"> правая граница (N)</param>
/// <returns>строчку с числами от 1 до N</returns>
string GetStringOfNumbers(int start, int end)
{
    // Базовый случай - выход 
    if (start == end) return start.ToString(); // Вернул последнее число N в формате строчки

    // Рекурсивный случай 
    return start + ", " + GetStringOfNumbers(start + 1, end);
}
Console.WriteLine($" '{GetStringOfNumbers(1, N)}' "); // start = 1, end = N
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


