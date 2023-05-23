/*
int FirstNumber = 0;
int SecondNumber = 0;
Console.WriteLine("Get first numbers");
FirstNumber = int.Parse(Console.ReadLine()); //  int.Parse()
Console.WriteLine("Get second numbers");
SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber)
{
    Console.WriteLine("Greater number: " + FirstNumber);
    Console.WriteLine("Smaller number: " + SecondNumber);
}
else
{
    Console.WriteLine("Greater number: " + SecondNumber);
    Console.WriteLine("Smaller number: " + FirstNumber);
}
*/

/*
int FirstNumber = 0;
int SecondNumber = 0;
int ThirdNumber = 0;
Console.WriteLine("Get first numbers");
FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Get second numbers");
SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Get third numbers");
ThirdNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
{
    Console.WriteLine("Greater number is first: " + FirstNumber);
}
    else if (SecondNumber > ThirdNumber)
    {
        Console.WriteLine("Greater number  is second: " + SecondNumber);
    }
else
{
    Console.WriteLine("Greater number  is third: " + ThirdNumber);
}
*/

/*
int Number = 0;
Console.WriteLine("Get number");
Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd ");
}
*/

/*
int Number = 0;
int X = 1;
Console.WriteLine("Get number");
Number = Convert.ToInt32(Console.ReadLine());
while (X < Number)
{
    if(X % 2 == 0)
    {
        Console.WriteLine(X);
    }
X++;
}
*/

/*
int Number = 0;
Console.WriteLine("Get number");
Number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < Number; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
void GenNumbers(int[] arr)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }
}

int[] arr = new int[10]; // { 0,0,0,0,0,0....}

GenNumbers(arr); // { 15,15,64,16,83....}

for (int i = 0; i < arr.Length; i++) // 0 = 15
{
    int left = arr[i] / 10; // 15 / 10 = 1
    int right = arr[i] % 10; // 15 % 10 = 5
    if (left > right)
    {
        Console.WriteLine($"Наибольшая цифра числа {arr[i]} = " + left);
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра числа {arr[i]} = " + right);
    }
}
*/

//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
/*
Random rnd = new Random();
int rndNum = rnd.Next(100, 1000); // array 100-999
Console.WriteLine(rndNum);
int a = rndNum / 100; // 180 / 10 -> 18
int c = rndNum % 10; // 180 % 19 -> 0
int res = 10 * a + c;
Console.Write(res);
*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
/*
int a = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
int b = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
if (b % a == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine(b % a);
}
*/

/*
Console.WriteLine("enter number ");
int a = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
Console.WriteLine("enter number ");
int b = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
if(Math.Pow(a,2) == b || Math.Pow(b, 2) == a) // && = и || = или
{
    // ...
}
*/