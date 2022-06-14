// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("Введите номер дня недели: ");

if (number < 1 || number > 7)
{
    System.Console.WriteLine("Такого дня недели нет.");
    Environment.Exit(0);
}
if (number == 6 || number == 7) System.Console.WriteLine("Выходной.");
else System.Console.WriteLine("Не выходной.");
