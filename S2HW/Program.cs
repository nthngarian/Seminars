//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
int Prompt(string msg)
{
System.Console.Write("Введите трехзначное число: ");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите трехзначное число: ");
if (number >=100 && number <1000)
{
int mid = (number % 100 - number % 10) / 10;
System.Console.WriteLine("Второй цифрой числа " + number + " является цифра " + mid);
}
else
System.Console.WriteLine("Число " + number + " не является трехзначным");
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
int Prompt(string msg)
{
System.Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число: ");
int fnumber(int number)
{
while (number > 1000)
{
number /= 10;
}
return number % 10;
}
bool check(int number)
{
if (number < 100)
return false;
else return true;
}
if (check(number) != true)
System.Console.WriteLine("Третьей цифры у числа " + number + " нет");
else
System.Console.WriteLine("Третьей цифрой числа " + number + " является " + fnumber(number));
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
/*
int Prompt(string msg)
{
System.Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число: ");
string ss = ("Цифра " + number + " не является днем недели");
string check(int number)
{
if (number >= 6 && number < 8) ss = ("Цифра " + number + " является выходным днем недели");
if (number >= 1 && number < 6) ss = ("Цифра " + number + " является будним днем недели");
return ss;
}
System.Console.WriteLine(check(number));
*/