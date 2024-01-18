// Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}
int[] Random_mas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(2, 20);
    }
    return col;
}
bool simple(int num)
{
    for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(num)); i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}
int Count(int[] col)
{
    int count = 0;
    foreach (var item in col)
    {
        if (simple(item)) count++;
    }
    return count;
}
int[] mas = Random_mas(new int[10]);
Print_mas(mas);
Console.WriteLine(Count(mas));

// второй вариант

int[] GenerateArray(int min, int max)
{
    Random Any = new Random();
    int[] array = new int[Any.Next(min, max)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Any.Next(1, 100);
    }
    return array;
}
int FindSimpleNumbers(int[] array)
{
    int a = 1;
    int count = 0;
    int SimpleCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        while (a <= array[i])
        {
            if (array[i] % a == 0)
            {
                count++;
            }
            if (a == array[i])
            {
                if (count <= 2)
                {
                    SimpleCount++;
                }
            }
            a++;
        }
        a = 1;
        count = 0;
    }
    return SimpleCount;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] array = GenerateArray(5, 10);
PrintArray(array);
Console.WriteLine(FindSimpleNumbers(array));

// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и при этом делятся нацело на 7.

int n = Convert.ToInt32(Console.ReadLine());
int[] GenerateArray(int n)
{
    int[] array = new int[n];
    for(int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
bool EndWithOne(int n)
{
    if(n % 10 == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool DelitsaNa7(int n)
{
    if(n % 7 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine();
}
int TrueOnFalse(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(EndWithOne(array[i]) && DelitsaNa7(array[i]))
        {
            count++;
        }       
    }
    return count;
}
int[] array = GenerateArray(n);
int a = TrueOnFalse(array);
PrintArray(array);
Console.WriteLine(a);

// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

int[] arr = new int[9];
int[] SumNums(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}
int[] RandomArr = SumNums(arr);

int AllNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result = arr[i] + result * 10;
    }
    return result;
}
int nums = AllNumbers(RandomArr);
foreach (var e in RandomArr)
{
    Console.Write($"{e} ");

}
Console.WriteLine();
Console.WriteLine(nums); 

// второй вариант

int[] GenerateArray(int n)
{
    Random Any = new Random();
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Any.Next(1, 10);
    }
    return array;
}
int CreateNumber(int[] array)
{
    string number = Convert.ToString(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            string a = Convert.ToString(array[i]);
            number = number + a;
        }
    }
    Console.WriteLine();
    int b = Convert.ToInt32(number);
    return b;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
bool w = true;
Console.Write("Пожалуйста введите число от 1 до 8: ");
int n = Convert.ToInt32(Console.ReadLine());
while (w)
{
    if (n <= 8 && n >= 1)
    {
        w = false;

    }
    else
    {
        Console.WriteLine("Не нарушайте условие!");
        n = Convert.ToInt32(Console.ReadLine());
    }
}
int[] array = GenerateArray(n);
PrintArray(array);
Console.WriteLine(CreateNumber(array));