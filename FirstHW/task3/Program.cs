//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите число: ");
string Number = Console.ReadLine();
int numInt = int.Parse(Number);

if (numInt % 2 == 0) System.Console.WriteLine("Число четное.");
else System.Console.WriteLine("Число нечетное.");
