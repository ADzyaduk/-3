// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N.

string PrintNat(int x, int n)
{
    if (x == n)
    {
        return x.ToString();
    }
    return x + " " + PrintNat(x + 1, n);

}

Console.Clear();
System.Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Ввведите N: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.Write(PrintNat(x, n));
