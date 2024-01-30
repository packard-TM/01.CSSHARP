// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Clear();
string LenMN(int start, int stop)
{
    if (start == stop) return Convert.ToString(start);
    return start + " " + LenMN(start + 1, stop);
}
Console.WriteLine("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(LenMN(M, N));

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

Console.Clear();
int m = 2;
int n = 3;
int FunkAkk = Akk(m, n);
int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}
Console.Write($"Функция Аккермана = {FunkAkk} ");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

Console.Clear();
void PrintArray(int[] myArray, int i = 0)
{
    if (i < myArray.Length)
    {
        PrintArray(myArray, i + 1);
        Console.Write(myArray[i] + " ");
    }
}
int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
PrintArray(myArray);