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