T[] Concat<T>(params T[][] arrays)
{
    var result = new T[arrays.Sum(a => a.Length)];
    int offset = 0;
    foreach (T[] array in arrays)
    {
        array.CopyTo(result, offset);
        offset += array.Length;
    }
    return result;
}

int[] quickSort(int[] array)
{
    if (array.Length < 2)
    {
        return array;
    }
    else
    {
        int pivot = array[0];
        int count = 0;
        foreach (int element in array)
        {
            if (element < pivot)
                count++;
        }
        int[] less = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < pivot)
            {
                less[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array)
        {
            if (element > pivot)
            {
                count++;
            }
        }
        int[] greater = new int[count];
        j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > pivot)
            {
                greater[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array)
        {
            if (element == pivot)
            {
                count++;
            }
        }
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++)
        {
            pivotArray[i] = pivot;
        }
        int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
        return result;
    }
}


Console.Clear();
int[] array = { 7, 4, 1, 3, 2, 5, 8, 6, 7, 7, 7 };
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array))}]");