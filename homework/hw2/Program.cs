// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно и 7 и 23");
}
else 
{
    Console.WriteLine("Число не кратно какому либо из чисел");
}



// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
//  и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int X = new Random().Next(-100, 100);
int Y = new Random().Next(-100, 100);

Console.WriteLine($"Введены координаты X: {X}");
Console.WriteLine($"Введены координаты Y: {Y}");

if (X == 0 || Y == 0)
{
    Console.WriteLine("Точка находится на одной из осей, условие не приемлимо");
}
else
{
if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой плоскости");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во второй плоскости");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третьей плоскости");
}
else
{
    Console.WriteLine("Точка находится в четвертой плоскости");
}
}


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10, 100);
int num1 = num / 10;
int num2 = num % 10;

Console.WriteLine($"Выпало число {num}");

if (num1 > num2)
{
    Console.WriteLine($"Наибольшая в нем цифра {num1}");
}
else 
{
    Console.WriteLine($"Наибольшая в нем цифра {num2}");
}



// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


Console.WriteLine("Введите число: ");

string n = Console.ReadLine();
int size = n.Length;
for (int i = 0; i < size-1; i++)
{
    Console.Write(n[i]);
    Console.Write(",");
 
}
Console.WriteLine(n[size-1]);

// вариант с рандомом

int numbers = new Random().Next(1000, 1000000000);
Console.WriteLine($"Введено число: {numbers}");
string row = Convert.ToString(numbers);
for (int i = 0; i < row.Length-1; i++)
{
    Console.Write(row[i]);
    Console.Write(",");
 
}
Console.Write(row[row.Length-1]);