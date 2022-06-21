// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

void CalcPositiveElemets(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element % 2 == 0) count += 1;
    }
    System.Console.WriteLine($"В заданном массиве количество четных чисел = {count}.");
}

int[] array = InitArray(10, 100, 999);
PrintArray(array);
CalcPositiveElemets(array);
