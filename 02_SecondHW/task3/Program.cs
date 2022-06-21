// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

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


System.Console.Write("Введите число: ");
string param = Console.ReadLine();
int number = int.Parse(param);


int[] array = Array(number, param);

if (array.Length < 3) System.Console.WriteLine("Третьей цифры нет.");
else System.Console.WriteLine("Третья цифра: " + array[2]);
