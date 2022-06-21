// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int a = Prompt("Введите число A: ");
int b = Prompt("Введите число B: ");

int result = 1;
int index = 1;


while (index <= b)
{
    result = result * a;
    index++;
}

System.Console.WriteLine($"Число {a} в степени {b} равно: {result}.");
