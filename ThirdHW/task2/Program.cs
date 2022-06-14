// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("Введите x первой точки: ");
int y1 = Prompt("Введите y первой точки: ");
int z1 = Prompt("Введите z первой точки: ");

int x2 = Prompt("Введите x второй точки: ");
int y2 = Prompt("Введите y второй точки: ");
int z2 = Prompt("Введите z второй точки: ");

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
System.Console.WriteLine($"Расстояние между заданными точками равно: {result:F2}");
