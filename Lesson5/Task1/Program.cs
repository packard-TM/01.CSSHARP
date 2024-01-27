// Вычислить факториал от натурального числа N

Console.Clear();
int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"STOP: {n}");
        return 1;
    }
    int x = n;
    Console.WriteLine(n);
    n = n * Fact(n - 1);
    Console.WriteLine($"Возврат: n = {x}, Fact = {n}");
    return n;    
}
Console.Write(Fact(9));