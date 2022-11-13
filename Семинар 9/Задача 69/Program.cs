
int PoW(int x, int y)
{
    if (y == 0)
    {
        return 1;
    }
    else if (y == 1)
    {
        return x;
    }
    return x * PoW(x, y - 1);
}
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень В: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(PoW(a, b));
