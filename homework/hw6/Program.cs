// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] mas = new char[,]{
    {'f', 'q', 't', 'y',},
    {'e', 'm', 'd', 'j'},
    {'x', 'c', 'u', 's'}
};
string str = "";
foreach (var item in mas)
{
    str += item;
}
Console.Write(str);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.WriteLine("Введите строку в разных регистрах: ");
string str = Console.ReadLine()!;
Console.WriteLine();
Console.WriteLine(str.ToLower());

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("Введите строку: ");
string str = Console.ReadLine()!;
int x = str.Length / 2;
int counter = 0;
for (int i = 0; i < str.Length / 2; i++)
    if (str[i] == str[str.Length - i - 1])
        counter++;
if (counter == x)
    Console.WriteLine($"{str} => ДА");
else
{
    Console.WriteLine($"{str} => НЕТ");
}

// Задача 4: Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Введите строку: ");
string str = Console.ReadLine()!;
string[] mas = str.Split(" ");
string temp;
for (int i = 0; i < mas.Length / 2; i++)
{
    temp = mas[i];
    mas[i] = mas[mas.Length - i - 1];
    mas[mas.Length - i - 1] = temp;
}
// Console.WriteLine(item);
foreach (var item in mas)
{
    Console.Write($"{item} ");
}