// // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в
// // массиве. Программа должна выдать ответ: Да/Нет.

// // Примеры

// // [1 3 4 19 3], 8 => Нет
// // [-4 3 4 1], 3 => Да

// Console.WriteLine("Введите размерность массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] mas = new int[n]; //[1,2,3,4,5]
// // Console.WriteLine(mas);

// //while
// int ind = 0;
// while (ind < mas.Length)
// {
//     Console.Write($"{mas[ind]}\t");
//     ind++;
// }
// Console.WriteLine();

// //for
// for (int i = 0; i < mas.Length; i++)
// {
//     Console.Write($"{mas[i]}\t");
// }
// Console.WriteLine();

// //foreach
// foreach (var item in mas)
// {
//     Console.Write($"{item}\t");
// }
// Console.WriteLine();

// //функция
// void Print_mas(int[] col)
// {
//     foreach (var item in col)
//     {
//         Console.Write($"{item}\t");
//     }
//     Console.WriteLine();
// }
// Print_mas(mas);

// int[] Random_mas(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(1, 10); //[0,10)
//     }
//     return col;
// }
// int[] new_mas = Random_mas(mas);
// Print_mas(new_mas);

// Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// foreach (var item in new_mas)
// {
//     if (item == num)
//     {
//         count++;
//         break;
//     }
// }

// if (count != 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// Console.Write("Введите число для проверки: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// // int[] mas = new int[n]; //[1,2,3,4,5]
// int[] nums = { 1, 30, 56, 11, 24, 35, 87, 9, 8, 7, 10, 1365 };
// bool isNumPresent = false;

// foreach (var item in nums)
// {
//     Console.Write($"{item}\t");
// }
// Console.WriteLine();

// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] == num1)
//     {
//         isNumPresent = true;
//         break;
//     }
// }

// if (isNumPresent)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в
// массиве. Программа должна выдать ответ: Да/Нет.

// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] aa = new int[n];
// int[] randarr(int[] c)
// {
//     for (int i1 = 0; i1 < c.Length; i1++)
//     {
//         c[i1] = new Random().Next(1, c.Length);
//     }
//     return c;
// }
// int[] ba = randarr(aa);
// Console.WriteLine($"Ваш абсолютно рандомный массив: ");
// for (int i2 = 0; i2 < ba.Length; i2++)
// {
//     Console.Write($"{ba[i2]} ");
// }
// Console.WriteLine();
// bool b = true;
// for (int i = 0; i < ba.Length; i++)
// {
//     if (a == aa[i])
//     {
//         Console.WriteLine($"Ваше число '{a}' присутствует в массиве.");
//         b = false;
//         break;
//     }
// }
// if (b == true)
// {
//     Console.WriteLine($"Вашего числа '{a}' нет в массиве.");
// }

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

int[] arr = { -10, -9, -8, -7, 7, 8, 9, 10 };


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] <= 0)
    {
        arr[i] = arr[i] * -1;
        Console.WriteLine(arr[i]);
    }
    else
    {
        arr[i] = arr[i] * -1;
        Console.WriteLine(arr[i]);

    }
}

// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новый массив.

int n = new Random().Next(5, 10);
int[] aa = new int[n];
int[] randomarray(int[] c)
{
    for (int i = 0; i < c.Length; i++)
    {
        c[i] = new Random().Next(1, 10);
    }
    return c;
}
aa = randomarray(aa);
for (int i = 0; i < aa.Length; i++)
{
    Console.Write($"{aa[i]} ");
}
Console.WriteLine();
int a = 0;
int b = aa.Length - 1;
int[] ba = new int[aa.Length / 2];
for (int i = 0; i < aa.Length / 2; i++)
{
    a = aa[i] * aa[b - i];
    ba[i] = a;
}
for (int i = 0; i < ba.Length; i++)
{
    Console.Write($"{ba[i]} ");
}
if (aa.Length % 2 == 1) Console.WriteLine($"(элемент {aa[aa.Length/2]} не имеет пары)");

// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.

int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[3];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num % 10;
    num = num / 10;
    Console.Write($"{arr[i]} ");
}