// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

Console.Write ("Введите A: ");
int a = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите B: ");
int b = int.Parse (Console.ReadLine ()!);
int mult = a;

for (int i = 1; i < b; i ++) 
    mult = mult*a;
    Console.WriteLine($"Число {a} в степени {b} равно {multy}");