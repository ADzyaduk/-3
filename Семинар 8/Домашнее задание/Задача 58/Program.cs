// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    var matrixResult = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (var i = 0; i < firstMatrix.GetLength(1); i++)
    {
        for (var j = 0; j < secondMatrix.GetLength(0); j++)
        {
            matrixResult[i, j] = 0;

            for (var k = 0; k < firstMatrix.GetLength(1); k++)
            {
                matrixResult[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return matrixResult;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] firstMatrix = GetArray(row, columns, 1, 10);
int[,] secondMatrix = GetArray(row, columns, 1, 10);
int[,] matrixResult = MatrixMultiplication(firstMatrix, secondMatrix);

System.Console.WriteLine("Массив 1: ");
PrintArray(firstMatrix);
System.Console.WriteLine("Массив 2: ");
PrintArray(secondMatrix);
System.Console.WriteLine("Результат: ");
PrintArray(matrixResult);
