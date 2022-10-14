// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);

int sum(int number)
{
    int count = Convert.ToString(number).Length;
    int a = 0;
    int result = 0;

for (int i = 0; i < count; i++)
    {
    a = number - number % 10;
    result = result + (number - a);
    number = number / 10;
    }
return result;
}

int sumNumber = sum(number);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");