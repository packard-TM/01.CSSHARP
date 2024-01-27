Console.Clear();

void OpenMatreshka(int size)
{
    Console.WriteLine($"Открыта матрешка размера {size}...");
    if (size == 1)
    {
        Console.WriteLine("Открыта самая маленькая матрешка!");
        return;
    }
    OpenMatreshka(size-1);
}
OpenMatreshka(5);

Console.WriteLine();

void OpenMatreshka1(int size)
{
    if (size == 1)
    {
        Console.WriteLine("Самая Маленькая матрешка!");
        return;
    }
    OpenMatreshka1(size-1);
    Console.WriteLine($"Открыта матрешка размера {size}...");
}
OpenMatreshka1(5);

Console.WriteLine();

void OpenMatreshka2(int size)
{
    if (size == 1)
    {
        Console.WriteLine("Самая Маленькая матрешка!");
        return;
    }
    Console.WriteLine($"Открыта матрешка размера {size}...");
    OpenMatreshka2(size-1);
}
OpenMatreshka2(5);