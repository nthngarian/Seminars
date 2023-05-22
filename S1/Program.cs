/*
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
Наприме:
4 -> 16
-3 -> 9
-7 -> 49
*/
// camelCase
/*
int number = Convert.ToInt32(Console.ReadLine()); // Переменная number - целое число, значение - 5

int result = number * number; // Если number = 5, то result = 5 * 5 (25)

double resultPartTwo = Math.Pow(number, 2); // number ^ 2

Console.WriteLine("Число " + number + " в квадрате: " + result);
Console.WriteLine("Число " + number + " в квадрате: " + resultPartTwo);
*/

/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/
/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()); 

if (firstNumber == secondNumber * secondNumber) // Равно ли 25 числу 5 в квадрате?
{
    // Да, истина
    Console.WriteLine("Число " + firstNumber + " является квадратом числа " + secondNumber);
}
else // Нет
{
    Console.WriteLine("Число " + firstNumber + " НЕ является квадратом числа " + secondNumber);
}
*/

/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
*/
/*
Console.Write("Введите: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1); // -N, N = 5, negativeN = 5 * (-1) = - 5

while (negativeN <= N)
{
    Console.WriteLine(negativeN); // negativeN = -2
    negativeN = negativeN + 1; // negativeN ++ 
}
*/
