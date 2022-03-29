int size = new Random().Next(1, 11);
Console.WriteLine($"Количетсов элементов массива: {size}");
int[] FillSourceArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}
void PrintDiffMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    int difference = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное: {arr.Min()}");
    Console.WriteLine($"Максимальное: {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значением: {difference}");
}

PrintDiffMinMax(FillSourceArray(size));
