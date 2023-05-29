//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//string stringNumber = "123Привет"; //Строчка - массив символов

//Console.WriteLine(stringNumber[2]);

//"123" - подходит, строка состоит только из цифр
//"123Привет" - не подходит

/*
var stringNumber = "123"; //var - ключевое слово, которое автоматически определяет тип данных
//var res = 100 / 458748 * 10;
//var res = 100 / 458748 * 10.5;

int number; //если строчка состоит только из чисел,
//то в переменную попадает наше число
//TryParse (строчка, out переменная) -- out переменная - сохраняем число

bool isNumber = int.TryParse(stringNumber, out number);
//isNumber = true - строка состоит только из чисел ("2"), number = числу из строчки
//isNumber = false - в строке присутствуют еще и символы, number = 0
if (isNumber && stringNumber.Length >= 3) //isNumber == true
{
    Console.WriteLine("Перевод произошел успешно, в строчке есть ТОЛЬКО цифры");
    Console.WriteLine(number);
    Console.WriteLine("Третья цифра числа: " + stringNumber[2]);
}
else
{
    Console.WriteLine("Ошибка! В строчке присутствуют и другие символы");
    Console.WriteLine(number);
}
*/

//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X не равно 0 и Y не равно 0 и выдает номер четверти плоскости,
//в которой находится эта точка.
/*
Console.Write("Введите координаты по осм oX: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты по осм oY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("I четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}
else
{
    Console.WriteLine("Вы попали в координатную ось.");
}
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
//A (3, 6); B(2, 1) -> 5.09
//A (7, -5); B(1, -1) -> 7.2
//AB = √(x2 - x1)^2 + (y2 - y1)^2
//4 координаты: A(x1, y1); B(x2,y2)
/*
Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
//Math.Sqrt(число) => Math.Sqrt(25) = 5
//(x2 - x1) * (y2 - y1) => Math.Pow(x2 - x1, 2) => Math.Pow(число, степень)
//Math.Pow(5, 3) => 5 * 5 * 5 = 125
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между точками A:({x1},{y1}) и B:({x2},{y2}) равно: {Math.Round(d, 1)}"); //Интерполяция
//$"Текст {переменная} что-то еще {пременная}"
//System.Console.WriteLine(Math.Round(1.23, 1)); //=> 1,2
//System.Console.WriteLine(Math.Round(1.23)); //=> 1
*/
/*
//Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
//5 -> 1, 4, 9 , 16, 25
//2 -> 1, 4

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

//int i = 1; //Точка старта, от этого числа начинаем работать
//(точка входа)
for(int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 2) + "\t"); //i * i
    //\t = Tab(1    2    3), "\t" - литерал, который ставит 4 пробела между цифрами
}
*/
