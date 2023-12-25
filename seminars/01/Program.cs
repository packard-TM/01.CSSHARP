// Задание 1. Совместная работа
// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
// a = 25,  b = 5     => да
// a = 2,   b = 10    => нет
// a = 9,   b = -3    => да
// a = -3,  b = 9     => нет

// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());

// if (number1 == number2 * number2)
//     {
//         Console.WriteLine($"Число {number1} является квадратом числа {number2}");
//     }
// else
//     {
//         Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
//     }

// Задание 2. Совместная работа
// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number < 0 )
//     {
//         number = number * -1;
//     }
// int counter = - number;
// while (counter <= number)
//     {
//         Console.Write($"{counter} ");
//         counter++;
//     }

// Задание 3*. Обсуждение решений
// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

int intput = (int.Parse(Console.ReadLine()));
// int decimalLeftover = intput%100;
// int firstNumber = intput - decimalLeftover;
int firstNumber = intput/100;
int lastnumber = intput%10;
int result = firstNumber + lastnumber;
Console.WriteLine(result);

// Console.WriteLine(intput/100);

Console.Write("Введите трехзначное число: ");
string n = Console.ReadLine();
int num1 = Convert.ToInt32(Convert.ToString(n[0]));
int num2 = Convert.ToInt32(Convert.ToString(n[2]));
Console.WriteLine(num1 + num2);