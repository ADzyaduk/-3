

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");
        }
    }
}

Console.Clear();
Console.WriteLine("Введите массив через пробел: ");
string input = Console.ReadLine();
int[] ArrayResult = GetArrayFromString(input);
PrintArray(ArrayResult);
