// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


long Prompt(string message)
{
    System.Console.Write(message);
    return long.Parse(Console.ReadLine());
}

long CalcAckermanFunction(long m, long n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return CalcAckermanFunction(m - 1, 1);
    return CalcAckermanFunction(m - 1, CalcAckermanFunction(m, n - 1));
}

long numberM = Prompt("Введите m: ");
long numberN = Prompt("Введите n: ");

System.Console.WriteLine(CalcAckermanFunction(numberM, numberN));
