// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int num = new Random().Next(100, 1000);

// int num1 = num / 100;
// int num2 = num % 10;

// Console.WriteLine(num);
// Console.WriteLine(num1 + "" + num2);

// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

//вводим число
// using System.Runtime.ExceptionServices;

// int input = int.Parse(Console.ReadLine());
// //Получаем третью цифру
// int ThirdNumber=input%10;
// //Получаем вторую цифру
// //Число- XYZ = X*100+Y*10+Z. Y=(XYZ-X*100-Z)/10
// int SecondNumber=(input-(input/100 * 100)- input%10)/10;

// //Возводим в степень
// Console.WriteLine("Третье число: "+ThirdNumber+" ,второе число: "+SecondNumber );
// // Вот пока не изучил- как перевести int в Double? 
// Console.WriteLine("Результат возведения в степень: "+ SecondNumber + "^ "+ThirdNumber+ " " +Math.Pow( SecondNumber,ThirdNumber ));
// //Третье число в степени равной второму.

// Второй вариант:

// int n = new Random().Next(100, 1000);
// int a = n % 100;
// a = a / 10;
// int b = n % 10;
// double c = Math.Pow(a, b);
// Console.WriteLine($"{n} => {a}^{b} => {c}");

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = a % b;
// if (a % b == 0){
//     Console.WriteLine("Да");
// }
// else{
//     Console.WriteLine($"Нет, {c}");
// }

// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры нет.

// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

// Console.WriteLine("Введите число");
// string num = Console.ReadLine();
// int num_len = num.Length;
//Console.WriteLine(num_len);

// if (num_len < 3)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     string num1 = Convert.ToString(num[2]);
//     Console.WriteLine($"Третья с начала {num1}");
//     string num2 = Convert.ToString(num[num_len - 3]);
//     Console.WriteLine($"Третья с конца {num2}");
// }

// второй вариант 

// Console.WriteLine("Введите число: ");
// string num =Console.ReadLine();
// int num_len = num.Length;
// int n = Convert.ToInt32(num);
// int b;
// int a = n / 100;
// if (a < 1){
//     Console.WriteLine("Третьей цифры нет.");
// }
// else{
//     a = a % 10;
//     Console.WriteLine($"{n} => {a}");
//     b = n / Convert.ToInt32(Math.Pow(10,(num_len - 3)));
//     b = b % 10;
//     Console.WriteLine($"{n} => {b}");
// }

// Третий вариант

// string s = Console.ReadLine();
// if (s.Length < 3) 
// {
//     Console.WriteLine("No third number.");
//     return;
// }
// int i = Convert.ToInt32(s);
// int thirdFirst = i / (int)Math.Pow(10, s.Length - 3);
// thirdFirst = thirdFirst - thirdFirst / 10 * 10;
// int thirdLast = i / 100;
// thirdLast = thirdLast - thirdLast / 10 * 10;
// Console.WriteLine("For number " + i + " first third number is " + thirdFirst + " last third is " + thirdLast);

int a = 4;
int b = 6;
if (a % 2 == 0 && b % 2 == 0)
{
    Console.WriteLine("Числа четные");
}
else 
{
    Console.WriteLine("Числа НЕ четные");
}