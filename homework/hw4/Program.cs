// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int NumberElementsCount(int n)
{
    double number = Convert.ToDouble(n);
    int count = 0;
    while (number >= 1)
    {
        count++;
        number /= 10;
    }
    return count;
}
bool TestForEvenNumberElementSum(int number)
{
    int NumLen = NumberElementsCount(number);
    int sum = 0;
    bool result = false;
    int element = number;
    for (int i = 1; i <= NumLen; i++)
    {
        element %= 10;
        sum += element;
        element = number / Convert.ToInt32(Math.Pow(10, i));
    }
    if (sum % 2 == 0)
    {
        result = true;
    }
    return result;
}
bool cycle = true;
Console.Write("Введите любое целое число (если хотите сдаться, то введите q): ");
string number = Console.ReadLine();
int count = 1;
string quit = "q";
string[] wrong = { "Не угадал", "Неа", "Может тебе попробывать ещё раз?", "Ты почти смог", "Ещё чуть-чуть!", "Давай ещё разок", "А теперь повтори" };
while (cycle)
{
    if (number == quit)
    {
        if (count >= 1)
        {
            Console.WriteLine($"Сдаёшься? Ну ладно, ты хотя бы пытался, кол-во попыток: {count}");
        }
        else
        {
            Console.WriteLine($"Серьёзно? Раз хотя бы попытался!");
        }
        cycle = false;
        break;
    }
    if (cycle & TestForEvenNumberElementSum(Convert.ToInt32(number)))
    {
        Console.WriteLine($"Ок, ты победил. Попытки: {count}");
        cycle = false;
        break;
    }
    else
    {
        Console.WriteLine(wrong[new Random().Next(0, wrong.Length - 1)]);
        number = Console.ReadLine();
    }
    count++;
}

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[size];
int counter = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(100, 1000);
    Console.Write($"{mas[i]}\t");
}
Console.WriteLine();
foreach (var e in mas)
{
    if (e % 2 == 0)
    {
        counter++;
    }
}
Console.WriteLine($"Введен массив из {size} чисел, из них {counter} четные.");

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[size];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(0, 10);
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();
int temp;
for (int j = 0; j < mas.Length / 2; j++)
{
    temp = mas[mas.Length - j - 1];
    mas[mas.Length - j - 1] = mas[j];
    mas[j] = temp;
}
foreach (var e in mas)
{
    Console.Write($"{e} ");
}
