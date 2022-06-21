// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76


double[] InitArray(int len, int min, int max)
{
    double[] arr = new double[len];
    double n = 0;
    for (int i = 0; i < len; i++)
    {
        n = new Random().NextDouble();
        arr[i] = n + (new Random().Next(min, max+1)); //Это работает, но разве здесь я не прибавляю к double число в int?
    }
    return arr;
}

void PrintArray(double[] arr)
{
    foreach (var element in arr)
    {
        System.Console.Write($"{element:F3}; ");
    }
    System.Console.WriteLine();
}

double DiffMaxAndMin (double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double result = 0.0;
    foreach (var element in arr)
    {
        if (max < element) max = element;
        else if (min > element) min = element;
    }
    result = max - min;
    return result;
}


double[] varArray = InitArray(6, 0, 9);
PrintArray(varArray);

double result = DiffMaxAndMin(varArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {result:F3}");
