// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int CalcSumBetweenMN(int n, int m)
{
    if (n < m) return 0;
    return n += CalcSumBetweenMN(n - 1, m);
}


int numberM = Prompt("Введите число M: ");
int numberN = Prompt("Введите число N: ");

int result = CalcSumBetweenMN(numberN, numberM);
System.Console.WriteLine($"Сумма элементов между M и N равна: {result}");
