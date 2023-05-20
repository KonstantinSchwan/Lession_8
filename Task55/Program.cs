/*      Задача 55: Задайте двумерный массив. Напишите программу,
        которая заменяет строки на столбцы. В случае, если это
        невозможно, программа должна вывести сообщение для
        пользователя.               */

int[,] FillArray()
{   
    System.Console.WriteLine("Введите, пожалуйста, количество строк в двумерном массиве: ");
    int numberRow = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите, пожалуйста, количество столбцов в двумерном массиве: ");
    int numberColumn = Int32.Parse(Console.ReadLine());
    int[,] array = new int[numberRow, numberColumn];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] collection)
{
    System.Console.WriteLine();
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            System.Console.Write($"{collection[i, j]}   ");
        }
        System.Console.WriteLine("\n");
    }
}

int[,] ChangeValue(int[,] collection)
{
    int lenghtRow = collection.GetLength(0);
    int temp = 0;

    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = i; j < collection.GetLength(1); j++)
        {
            // if (i > j) continue;
            (collection[i, j], collection[j, i]) = (collection[j, i], collection[i, j]);
        }
    }
    return collection;
}

int[,] array = FillArray();
PrintArray(array);

if (array.GetLength(0) != array.GetLength(1))
{
    // return 0;
    throw new ArgumentException("Всё плохо");
}

int[,] newArray = ChangeValue(array);
PrintArray(newArray);