// Task54
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
int[,] arr54 = createAndShowArray(5, 5);
int changeElement = 0;
{
    for (int i = 0; i < arr54.GetLength(0); i++)
    {
        for (int m = 0; m < arr54.GetLength(1); m++)
        {
            for (int j = 1; j < arr54.GetLength(1); j++)
            {
                if (arr54[i, j - 1] < arr54[i, j])
                {
                    changeElement = arr54[i, j - 1];
                    arr54[i, j - 1] = arr54[i, j];
                    arr54[i, j] = changeElement;
                }
            }
        }
    }
}
Console.WriteLine();
showArray(arr54);