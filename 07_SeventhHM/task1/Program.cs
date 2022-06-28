// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] GanerateArray(int row, int column, int min, int max)
{
    var array = new double[row, column];
    var rnd = new Random();
    var rndDouble = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max) + rndDouble.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]:f3}\t");
        }
        System.Console.WriteLine();
    }
}


int row = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int min = Prompt("Введите минимальное значение элементов: ");
int max = Prompt("Введите максимальное значениеи элементов: ");
double[,] array = GanerateArray(row, column, min, max);
PrintArray(array);
