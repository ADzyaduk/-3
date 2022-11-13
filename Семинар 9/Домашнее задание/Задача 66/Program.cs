// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

void PrintSumm(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        Console.Write($"{sum} ");
        return;
    }
    PrintSumm(m, n - 1, sum);
}

Console.Clear();
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
PrintSumm(m, n, 0);
