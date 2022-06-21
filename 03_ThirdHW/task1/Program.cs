// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Усложнено - любое число, не только пятизначное. 

int[] Array(int num, string param)
{
    int[] array = new int[param.Length];
    int index = array.Length - 1;

    while (num > 0)
    {
        array[index] = num % 10;
        num = num / 10;
        index--;
    }
    return array;
}

void palindromeTest(int[] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length / 2)
    {
        if (array[i] == array[array.Length -1 - i]) count++;
        i++;
    }
    if (count == array.Length / 2) System.Console.WriteLine("Число является палиндромом.");
    else System.Console.WriteLine("Число не является палиндромом.");
}

System.Console.Write("Введите число: ");
string param = Console.ReadLine();
int number = int.Parse(param);

int[] array = Array(number, param);

palindromeTest(array);
