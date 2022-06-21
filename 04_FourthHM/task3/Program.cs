// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1


int[] NewArray()
{
    int[] array = new int[8];

    for(int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] array = NewArray();
PrintArray(array);
