/*
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length]; // length = 5, 5 нулей
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: "); // i = 0
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных элементов: {count}");
*/
/*
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length]; // length = 5, 5 нулей
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Массив: [ {string.Join(";", numbers)} ]");
Console.WriteLine($"Количество положительных элементов: {count}");
*/
/*
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double axisX = (b2 - b1) / (k1 - k2);
double axisY = k1 * axisX + b1;

Console.WriteLine($"Точка пересечения двух прямых = X: {Math.Ceiling(axisX)}, Y: {Math.Ceiling(axisY)}");
*/