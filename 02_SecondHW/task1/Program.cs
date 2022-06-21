//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}


int number = Prompt("Введите трехзначное число: ");

int result = number / 10 % 10;
System.Console.WriteLine("Вторая цифра числа: " + result);
