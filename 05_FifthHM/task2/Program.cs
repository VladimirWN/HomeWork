// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0


int[] InitArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int element in arr)
    {
        System.Console.Write(element + "; ");
    }
    System.Console.WriteLine();
}

int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}


int[] array = InitArray(6, -50, 50);
PrintArray(array);

int result = SumOddPositions(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");
