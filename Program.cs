// Task56
Console.Clear();
int[,] createAndShowArray(int raw, int column)
{
    int[,] array = new int[raw, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
void showArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] arr56 = createAndShowArray(5, 5);
int rowWithMinSum = 0;
int sum = 0;
int sumMin = 999;
for (int i = 0; i < arr56.GetLength(0); i++)
{
    for (int j = 0; j < arr56.GetLength(1); j++)
    {
        sum += arr56[i,j];
        if (j == arr56.GetLength(1) - 1)
            if (sum < sumMin)
            {
                sumMin = sum;
                rowWithMinSum = i + 1;
            }
    }
    sum = 0;
}

Console.WriteLine($"Строка {rowWithMinSum}, сумма элементов: {sumMin}");