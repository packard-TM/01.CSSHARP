// Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// Указание Конструктор строки вида string(char []) не использовать

string CharOfString(char[] arr)
{
    string st = "";
    foreach (var item in arr)
    {
        st += item;
    }
    return st;
}
char[] chars = new char[] { 'a', 'b', 'c', 'd' };
Console.WriteLine(CharOfString(chars));

// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// Указание Метод строки ToCharArray() не использовать.

char[] StringOfChar(string str)
{
    char[] mas = new char[str.Length];

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = str[i];
        // Console.WriteLine($"{str[i]} -> {mas[i]}");
    }
    return mas;
}
void PrintMas(char[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
string st = Console.ReadLine()!;
PrintMas(StringOfChar(st));

// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных (aoyuei).

void Count(string str)
{
    string vowes = "ayouei";
    int count = 0;
    foreach (var vo in vowes)
    {
        foreach (var s in str)
        {
            if (vo == s) count++;
        }
    }
    Console.WriteLine(count);
}
String st = Console.ReadLine()!;
Count(st);

// второй вариант

void Count(string str)
{
    string vowes = "aeiouy";
    int counter = 0;
    foreach (var Letter in str)
    {
        if (vowes.Contains(Letter))
        {
            counter++;
        }
    }
    Console.WriteLine(counter);
}
string st = Console.ReadLine()!;
Count(st);