int size = 15;
int[] FillArray(int intsize)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void PrintResult(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) number++;
        
    }
    Console.WriteLine();
    Console.Write($"Количество четных чисел {number}");
    Console.WriteLine();
}
PrintResult(FillArray(size));
