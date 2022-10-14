// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
int Getmult(int a, int b)
{
    int mult = 1;
    for (int i = 1; i <= b; i ++) 
    {
        mult *= a;
    }
    return mult;
}
Console.Clear();
Console.Write ("Введите A: ");
int a = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите B: ");
int b = int.Parse (Console.ReadLine ()!);
int res = Getmult(a,b);
Console.WriteLine($"Число {a} в степени {b} равно {(res)}"); 