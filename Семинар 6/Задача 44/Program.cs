// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fib (int N)
{
int[] array= new int [N];
array[0]=0;
array[1]= 1;
for (int i=2; i<N; i++)
{
array[i]=array[i-1] +array[i-2];
}
return array;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] array = Fib(num);
Console.WriteLine(string.Join(" ", array));