// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int sum(int value)
{
    int result = 0;
    while (value > 0)
    {
        result += value % 10;
        value = value / 10;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);
int myValue = sum(number);
Console.WriteLine($"Сумма цифр в числе: {myValue}");