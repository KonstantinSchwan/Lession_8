/*      Задача 53: Задайте двумерный массив. Напишите программу,
        которая поменяет местами первую и последнюю строку массива.     */

int[,] FillArray()
{   
    System.Console.WriteLine("Введите, пожалуйста, количество строк в двумерном массиве: ");
    int numberRow = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите, пожалуйста, количество столбцов в двумерном массиве: ");
    int numberColumn = Int32.Parse(Console.ReadLine());
    int[,] array = new int[numberRow, numberColumn];
    Random rnd = new Random();

    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
            System.Console.Write($"{array[i, j]}   ");
        }
        System.Console.WriteLine("\n");
    }
    return array;
}

int[,] ChangeFirstAndLastRow(int[,] collection)
{
    int lenghtRow = collection.GetLength(0);

    for (int j = 0; j < collection.GetLength(1); j++)
    {
        (collection[0, j], collection[lenghtRow - 1, j]) = (collection[lenghtRow - 1, j], collection[0, j]);
    }
    return collection;
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

int[,] array = FillArray();
PrintArray(array);
PrintArray(ChangeFirstAndLastRow(array));