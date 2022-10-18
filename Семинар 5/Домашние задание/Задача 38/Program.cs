// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 1000) / 10.0;
    }
    return res;
}

double MaxElement(double[] array)
{
    double m = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > m)
            m = array[i];
    }
    return m;
}

double MinElement(double[] array)
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double[] array = GetArray(5, 1, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Максимальное = {MaxElement(array)}");
Console.WriteLine($"Минимальное = {MinElement(array)}");
Console.WriteLine();
Console.WriteLine($"Разность минимально и максимального = {MaxElement(array) - MinElement(array)}");