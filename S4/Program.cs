//19
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    Console.WriteLine("Пятизначное число");
    int firstDigit = number / 10000; //12821 / 10000 = 1

    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
}
else
{
    Console.WriteLine("Не пятизначное число");
}
*/

//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//A = 4: 1 + 2 + 3 + 4 = 3 + 3 + 4 = 6 + 4 = 10
/*
Console.Write("Введите число А: ");

int limit = Convert.ToInt32(Console.ReadLine());

int sum = 0; // Изначально суммы нет
// for (точка входа; условие цикла; увел.счетчика)
for (int i = 1; i <= limit; i++)
{
    sum += i; // sum = sum + i
}

Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (num != 0)
{
    num /= 10;
    i++;

}
Console.WriteLine("количество цифр в числе " + i);
*/
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;// Количеств цифр в числе

while (number != 0)
{
    count++;
    number /= 10; // number = number / 10
}

Console.WriteLine($"количество цифр в числе:  {count} ");
*/

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
/*
int size = 8;
int[] array = new int[size]; // Массив из 8 элементов: в массиве изначально 8 нулей

for (int i = 0; i < size; i++)
{
    // array[i] = new Random().Next(0, 2)
    array[i] = new Random().Next(2);
    // Console.Write(array[i] + " ");
}

Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");
*/
/*
int size = 8;
int[] array = new int[size]; // Массив из 8 элементов: в массиве изначально 8 нулей
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    // array[i] = new Random().Next(0, 2)
    array[i] = rand.Next(2);
    // Console.Write(array[i] + " ");
}

Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");
*/
