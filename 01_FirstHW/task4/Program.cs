//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите число: ");
string Number = Console.ReadLine();
int numInt = int.Parse(Number);

int index = 2;

if (index > numInt) System.Console.WriteLine("Таких чисел нет");
else
{
    while (index < numInt)
    {
        System.Console.Write(index);
        index += 2;
        if (index < numInt) System.Console.Write(", ");
        else if (index == numInt) System.Console.Write($", {index}");
    }

}