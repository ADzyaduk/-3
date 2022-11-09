int[] SingleArray(int[,] BiArray)
{
    int[] result = new int[BiArray.GetLength(0) * BiArray.GetLength(1)]; // кол-во эл-тов в массиве=кол-ву всех эл-отв
    int k = 0;
    for (int i = 0; i < BiArray.GetLength(0); i++)
    {
        for (int j = 0; j < BiArray.GetLength(1); j++)
        {
            result[k++] = BiArray[i, j];
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void CountFindNumberInArray(int[] inarray)
{
    int count = 1;
    int numberZero = inarray[0];
    for (int i = 1; i < inarray.Length; i++)
    {
        if (inarray[i] == numberZero)
            count++;
        else
        {
            Console.WriteLine($"число {numberZero} встречается {count} раз");
            numberZero = inarray[i];
            count = 1;
        }
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

Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);

int [] array1D = SingleArray(userArray);
SortArray(array1D);
CountFindNumberInArray(array1D);
