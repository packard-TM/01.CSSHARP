// Назовём число «интересным» если его сумма цифр чётная
// Создать двумерный массив, состоящий из целых чисел. 
// Вывести на экран «интересные» элементы массива


Console.Clear();

int[,] CreateMatrix(int rowCount, int columsCount) // создание массива
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(100, 1000);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix) // вывод массива экран 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix); // вывод массива экран 
Console.WriteLine();

foreach (var e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.Write($"{e}\t");
    }
}
bool IsInteresting(int value) // проверка на четность
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}
int GetSumOfDigits(int value) // вычисление суммы чисел числа
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}