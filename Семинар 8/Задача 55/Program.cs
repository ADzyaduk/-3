int[,] ChangeRowsToColumns(int[,] userArray)
{

    if (userArray.GetLength(0) == userArray.GetLength(1))
    {
        int[,] resultArray = new int[userArray.GetLength(0), userArray.GetLength(1)];
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            for (int j = 0; j < userArray.GetLength(1); j++)
            {
                resultArray[i, j] = userArray[j, i];
            }
        }
        return resultArray;
    }
    else
    {
        Console.WriteLine("Массив перевернуть невозможно");
        return userArray;
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
