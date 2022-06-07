// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число: ");
string firstNumber = Console.ReadLine();
int firstInt = int.Parse(firstNumber);

System.Console.WriteLine("Введите второе число: ");
string secondNumber = Console.ReadLine();
int secondInt = int.Parse(secondNumber);

if (firstInt > secondInt)
{
    System.Console.WriteLine("max = " + firstInt);
    System.Console.WriteLine("min = " + secondInt);
}
else
{
    System.Console.WriteLine("max = " + secondInt);
    System.Console.WriteLine("min = " + firstInt); 
}
