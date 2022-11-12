void ChangeFirstLastRows(int[,] userArray)
{
int temp;
int n = userArray.GetLength(1);
for (int i = 0; i < userArray.GetLength(0); i++)
{
temp = userArray[0, i];
userArray[0, i] = userArray[n - 1, i];
userArray[n - 1, i] = temp;
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
