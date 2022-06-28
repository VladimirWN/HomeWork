// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

(double, double) SearchIntersection(double b1, double k1, double b2, double k2)
{
    double xResult = 0.0;
    double yResult = 0.0;
    xResult = (b2 - b1) / (k1 - k2);
    yResult = k1 * xResult + b1;
    return (xResult, yResult);
}


double b1 = Prompt("Введите b1: ");
double k1 = Prompt("Введите k1: ");
double b2 = Prompt("Введите b2: ");
double k2 = Prompt("Введите k2: ");

if (k1 == k2) System.Console.WriteLine("Прямые параллельны.");
else
{
    (double x, double y) = SearchIntersection(b1, k1, b2, k2);
    System.Console.WriteLine($"Точка пересечения [{x}, {y}].");
}
