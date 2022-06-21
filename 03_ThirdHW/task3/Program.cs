// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

void Result(int N)
{
    if (N < 1) System.Console.WriteLine("Введено неверное число.");
    else
    {
        int index = 1;
        while (index < N)
        {
            System.Console.Write(Math.Pow(index, 3) + ", ");
            index++;
        }
        System.Console.Write(Math.Pow(index, 3) + ".");
    }
}


int number = Prompt("Введите число N: ");

Result(number);
