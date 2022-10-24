﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] result = new int[m, n];

for (int i = 0; i < m; i++)
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().Next(minValue, maxValue+1);
}

return result;
}

