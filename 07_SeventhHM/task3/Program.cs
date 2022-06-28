// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GanerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double CalculationColumnAverage (int[,] arr, int j)
{
    double result = 0;
    int i = 0;
    while (i < arr.GetLength(0))
    {
        result += arr[i, j];
        i++;
    }
    return result / i;
}

int row = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int min = 0;
int max = 10;
int[,] array = GanerateArray(row, column, min, max);
PrintArray(array);

double average = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    average = CalculationColumnAverage(array, j);
    System.Console.WriteLine($"Средее арифметическое в столбце {j + 1} равно {average:f2}");
}
