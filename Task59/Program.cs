/*      Задача 59: Задайте двумерный массив из целых чисел.
        Напишите программу, которая удалит строку и столбец, на
        пересечении которых расположен наименьший элемент
        массива.

*/

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
            array[i, j] = rnd.Next(1, 100);
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

int[] FindMin(int[,] collection)
{
    int[] min = new int[2];

    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            if (collection[i, j] < collection[min[0], min[1]])
            {
                min[0] = i;
                min[1] = j;
            }
        }
    }
    System.Console.WriteLine(min[0]);
    System.Console.WriteLine(min[1]);
    return min;
}

int[,] CreateArray(int[,] collection, int[] min)
{
    int[,] array2 = new int[collection.GetLength(0) - 1, collection.GetLength(1) - 1];
    int xShift = 0;
    int yShift = 0;

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        if (i == min[0]) xShift = 1;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (j == min[1]) yShift = 1;
            array2[i, j] = collection[i + xShift, j + yShift];
        }
        yShift = 0;
    }

    return array2;
}

int[,] array = FillArray();
PrintArray(array);
int[,] array2 = CreateArray(array, FindMin(array));
PrintArray(array2);