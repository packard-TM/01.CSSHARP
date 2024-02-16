// сортировка выбором

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
// }

// int[] sortVibor(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int indexMin = i;
//         for (int j = i; j < array.Length; j++)
//         {
//             if (array[j] < array[indexMin])
//                 indexMin = j;
//         }
//         if (array[indexMin] == array[i])
//             continue;

//         int temp = array[i];
//         array[i] = array[indexMin];
//         array[indexMin] = temp;
//     }
//     return array;
// }

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Конечный массив: [{string.Join(", ", sortVibor(array))}]");

// второй вариант с sorting и Infrastructure

using static Sorting;
using static Infrastructure;

10.Creat eArray()
.Show()
.SortSelection()
.Show();