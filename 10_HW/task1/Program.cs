// Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintMonoSequence(int n)
{
    if (n == 0) return;
    PrintMonoSequence(n - 1);
    for (int i = 1; i <= n; i++)
    {
        System.Console.Write(n + ", ");
    }
}

int number = Prompt("Введите число N: ");
PrintMonoSequence(number);
