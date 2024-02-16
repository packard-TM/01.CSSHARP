﻿// пузырьковая сортировка

int n = 20;
int max = 100;
int[] array = new int[n];

bool Check(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }

    return true;
}

for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(max);
Console.WriteLine($"[{String.Join(", ", array)}]");
System.Console.WriteLine(Check(array));

for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (array[i] > array[i + 1])
        {
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }
    }
}
Console.WriteLine($"[{String.Join(", ", array)}]");
System.Console.WriteLine(Check(array));