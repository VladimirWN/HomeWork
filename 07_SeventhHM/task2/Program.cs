// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет


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

string SearchElement(int[,] arr, int i, int j)
{
    if (i <= arr.GetLength(0) && j <= arr.GetLength(1)) return arr[i - 1, j - 1].ToString();
    else return "Такого элемента в массиве нет";
}


int row = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int min = 0;
int max = 10;
int[,] array = GanerateArray(row, column, min, max);
PrintArray(array);

int rowNumber = Prompt("Введите номер строки: ");
int columnNumber = Prompt("Введите номер столбца: ");
string result = SearchElement(array, rowNumber, columnNumber);
System.Console.WriteLine($"Искомый элемент: {result}");
