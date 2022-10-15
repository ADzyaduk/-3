// See https://aka.ms/new-console-template for more information
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ChangeArray(int[] array)
{    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

Console.Clear();
int[] array = GetArray(6, -10, 10);
Console.WriteLine(String.Join(", ", array));
ChangeArray(array);
Console.WriteLine(String.Join(", ", array));