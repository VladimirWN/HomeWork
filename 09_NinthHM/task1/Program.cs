// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintEvenNumbersBetweenMN(int n, int m)
{
    if (n < m) return;
    PrintEvenNumbersBetweenMN(n - 1, m);
    if (n % 2 == 0) System.Console.Write(n + ", ");
}


int numberM = Prompt("Введите число M: ");
int numberN = Prompt("Введите число N: ");

PrintEvenNumbersBetweenMN(numberN, numberM);
