//  Напишите программу, которая на вход принимает два числа и выдаёт максимальное.
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3
/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    {
       Console.WriteLine("Число " + firstNumber + " является максимальным числом. ");
    }
else
{
    Console.WriteLine("Число " + secondNumber + " является максимальным числом. ");
}
*/

//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    {
       if (firstNumber > thirdNumber)
       {
            Console.WriteLine("Число " + firstNumber + " является максимальным числом. ");
       }
       else
       {
            Console.WriteLine("Число " + thirdNumber + " является максимальным числом. ");
       }
    }
else
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine("Число " + secondNumber + " является максимальным числом. ");
    }
    else
    {
        Console.WriteLine("Число " + thirdNumber + " является максимальным числом. ");
    }
}
*/

//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0)
{
    Console.WriteLine("Число " + Number + " является чётным числом. ");
}
else
{
    Console.WriteLine("Число " + Number + " не является чётным числом. ");
}
*/

//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
/*
Console.Write("Введите число N: ");
int Number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= Number; i++)
{
    if (i % 2 == 0)
    Console.WriteLine("Число " + i + " является чётным числом. ");
}
*/
