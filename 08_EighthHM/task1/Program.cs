// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

int[,] SortElemntsInRows(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int left = 0;
        int right = arr.GetLength(1) - 1;
        while (left <= right)
        {
            for (int j = left; j < right; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    temp = arr[i, j + 1];
                    arr[i, j + 1] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
            right--;
            for (int j = right; j > left; j--)
            {
                if (arr[i, j] > arr[i, j - 1])
                {
                    temp = arr[i, j - 1];
                    arr[i, j - 1] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
            left++;
        }
    }
    return arr;
}


int row = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int min = 0;
int max = 10;
int[,] array = GanerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();

int[,] sortedArray = SortElemntsInRows(array);
PrintArray(sortedArray);
