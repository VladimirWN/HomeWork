// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int n = Prompt("Введите число: ");
int result = 0;

while (n > 0)
{
    result += n % 10;
    n /= 10;
}

System.Console.WriteLine($"Сумма цифр в введенном числе равна: {result}.");
