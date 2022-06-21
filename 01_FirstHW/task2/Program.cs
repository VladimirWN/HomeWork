//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Введите первое число: ");
string firstNumber = Console.ReadLine();
int firstInt = int.Parse(firstNumber);

System.Console.Write("Введите второе число: ");
string secondNumber = Console.ReadLine();
int secondInt = int.Parse(secondNumber);

System.Console.Write("Введите третье число: ");
string thirdNumber = Console.ReadLine();
int thirdInt = int.Parse(thirdNumber);

int max = firstInt;

if (secondInt > max) max = secondInt;
if (thirdInt > max) max = thirdInt;

System.Console.WriteLine($"max = {max}");
