// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] PromptM(string message, int amount)
{
    System.Console.WriteLine(message);
    int[] arr = new int[amount];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите число {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int CountPositiveElements(int[] arr)
{
    int result = 0;
    foreach (int element in arr)
    {
        if (element > 0) result++;
    }
    return result;
}


int myAmount = 5;
int[] array = PromptM($"Введите {myAmount} чисел.", myAmount);

int result = CountPositiveElements(array);
System.Console.WriteLine($"Больше 0 введено: {result}.");
