// Задача 3*: Задача 1: Заполните спирально квадратный массив по возрастанию, с заданным размером:


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateSquareArray(int size)
{
    return new int[size, size];
}

void FillSquareArraySpiral(int[,] arr)
{
    int value = 1;
    int size = arr.GetLength(0);

    for (int j = 0; j < size; j++) // заполнение периметра массива
    {
        arr[0, j] = value;
        value++;
    }
    for (int i = 1; i < size; i++)
    {
        arr[i, size - 1] = value;
        value++;
    }
    for (int j = size - 2; j >= 0; j--)
    {
        arr[size - 1, j] = value;
        value++;
    }
    for (int i = size - 2; i > 0; i--)
    {
        arr[i, 0] = value;
        value++;
    }

    int x = 1;
    int y = 0;
    while (value < size * size) // заполнение элементов внутри периметра
    {
        while (arr[x, y + 1] == 0)
        {
            arr[x, y + 1] = value;
            value++;
            y++;
        }
        while (arr[x + 1, y] == 0)
        {
            arr[x + 1, y] = value;
            value++;
            x++;
        }
        while (arr[x, y - 1] == 0)
        {
            arr[x, y - 1] = value;
            value++;
            y--;
        }
        while (arr[x - 1, y] == 0)
        {
            arr[x - 1, y] = value;
            value++;
            x--;
        }
    }

    if (arr[size / 2, size / 2] == 0) // в случае если значение ширины массива нечетное, последняя ячейка остается пустой
    {
        arr[size / 2, size / 2] = size * size;
    } 
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


int RowXColumnNumber = Prompt("Введите ширину квадратного массива: ");
int[,] squareArray = GenerateSquareArray(RowXColumnNumber);
FillSquareArraySpiral(squareArray);

PrintArray(squareArray);
