// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Sq(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arry[i, j] = arry[i, j] * arry[i, j];
            }
        }
    }
    return arry;
}

Console.WriteLine("Введите размер m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }
}
PrintArr(arr);

int[,] newArr = Sq(arr);
Console.WriteLine();
PrintArr(newArr);

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

string input;
int sizeX;
int sizeY;
while (true)
{
    Console.Write("Input array size X: ");
    input = Console.ReadLine();
    if (input != null)
    {
        sizeX = Convert.ToInt32(input);
        if (sizeX > 0) break;
    }
}
while (true)
{
    Console.Write("Input array size Y: ");
    input = Console.ReadLine();
    if (input != null)
    {
        sizeY = Convert.ToInt32(input);
        if (sizeY > 0) break;
    }
}
int[,] numbers = CreateRandomizedArray(sizeX, sizeY);
int[,] CreateRandomizedArray(int sizeX, int sizeY)
{
    int[,] ret = new int[sizeX, sizeY];
    for (int forX = 0; forX < ret.GetLength(0); forX++)
    {
        for (int forY = 0; forY < ret.GetLength(1); forY++)
        {
            ret[forX, forY] = new Random().Next(0, 10);
        }
    }
    return ret;
}
/*
for (int forX = 0; forX < numbers.GetLength(0); forX++)
{
if (forX > 0) Console.WriteLine("");
for (int forY = 0; forY < numbers.GetLength(1); forY++)
{
if (forX % 2 == 0 && forY % 2 == 0)
{
numbers[forX, forY] *= numbers[forX, forY];
Console.Write("[" + numbers[forX, forY] + "]\t");
}
else Console.Write(numbers[forX, forY] + "\t");
}
}
*/
int totalDiag = 0;
for (int forX = 0; forX < numbers.GetLength(0); forX++)
{
    if (forX > 0) Console.WriteLine("");
    for (int forY = 0; forY < numbers.GetLength(1); forY++)
    {
        if (forX == forY)
        {
            totalDiag += numbers[forX, forY];
            Console.Write("[" + numbers[forX, forY] + "]\t");
        }
        else Console.Write(numbers[forX, forY] + "\t");
    }
}
Console.WriteLine("");
Console.Write("Total Diagonal: " + totalDiag);

// второй вариант

int[,] Generate2dArray(int x, int y)
{
    Random Any = new Random();
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[j, i] = Any.Next(0, 10);
        }
    }
    return array;
}
int FindMasterNumbersSum(int[,] array)
{
    int sum = 0;
    int length = array.GetLength(0);
    if (array.GetLength(0) > array.GetLength(1))
    {
        length = array.GetLength(1);
    }
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
}
void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[j, i]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = Generate2dArray(5, 5);
Write2dArray(array);
Console.WriteLine(FindMasterNumbersSum(array));

// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

double[,] Generate2dArray(int x, int y)
{
    Random Any = new Random();
    double[,] array = new double[x, y];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[j, i] = Any.Next(0, 10);
        }
    }
    return array;
}
void Write2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[j, i]}\t");
        }
        Console.WriteLine();
    }
}
double[] ConvertTo1d(double[,] array1)
{
    double[] array2 = new double[array1.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            sum += array1[j, i];
        }
        array2[i] = sum / array1.GetLength(1);
        sum = 0;
    }
    return array2;
}
void Write1dArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
double[,] array = Generate2dArray(5, 4);
Write2dArray(array);
Write1dArray(ConvertTo1d(array));

// второй вариант

int[,] Generate2arr = new int[3, 4];
int[,] Randomarr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
void Printarr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
double[] num = new double[3];
int[,] num2 = Randomarr(Generate2arr);
Printarr(num2);
double count;
for (int i = 0; i < num2.GetLength(0); i++)
{
    count = 0;
    for (int j = 0; j < num2.GetLength(1); j++)
    {
        count += num2[i, j];
    }
    num[i] = count / num2.GetLength(1);
}
foreach (var item in num)
{
    Console.Write($"{item}\t");
}