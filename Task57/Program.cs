// Задача 57 Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] array = ReadArray(4, 4);
PrintArray(array);
var dict = GetNumberDictionary(array);
PrintDictionary(dict);


int[,] ReadArray(int length1, int length2)
{
    int[,] array = new int[length1, length2];

    for (int i = 0; i < length1; i++)
        for (int j = 0; j < length2; j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}


Dictionary<int, int> GetNumberDictionary(int[,] array)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (dict.ContainsKey(array[i, j]))
                dict[array[i, j]]++;
            else dict.Add(array[i, j], 1);
    }

    return dict;
}

void PrintDictionary(Dictionary<int, int> dict)
{
    foreach (var item in dict.OrderBy(x => x.Key))
    {
        Console.WriteLine($"{item.Key} --- {item.Value}");
    }
}