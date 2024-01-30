// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumNum(int num)
{
    if (num == 0) return 0;
    int res = num % 10 + SumNum(num / 10);
    return res;
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(n));

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

string Len(int start, int stop)
{
    if (start == stop) return Convert.ToString(start);
    return start + " " + Len(start + 1, stop);
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Len(1, n));

// второй способ

void Len2(int num)
{
    if (num == 0) return;
    Len2(num - 1); // счет чисел по порядку
    Console.Write($"{num} ");
    // Len2(num - 1); // счет чисел по убыванию
}

Console.WriteLine("Введите число: ");
int f = int.Parse(Console.ReadLine()!);
Len2(f);

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от X до Y.

string LenXY(int start, int stop)
{
    if (start == stop) return Convert.ToString(start);
    return start + " " + LenXY(start + 1, stop);
}
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine(LenXY(x, y));

// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.

void String(string s)
{
    if (s.Length == 0) return;
    string vovels = "eyuioaEYUIOA";
    if(vovels.Contains(s[0]) == false) Console.Write($"{s[0] }");
    String(s[1..]);
}
string st = Console.ReadLine()!;
String(st);