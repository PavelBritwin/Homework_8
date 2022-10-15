// Task58
Console.Clear();

int[,] matrix1 = new int[2, 2] { { new Random().Next(1, 10), new Random().Next(1, 10) }, { new Random().Next(1, 10), new Random().Next(1, 10) } };
int[,] matrix2 = new int[2, 2] { { new Random().Next(1, 10), new Random().Next(1, 10) }, { new Random().Next(1, 10), new Random().Next(1, 10) } };
int[,] matrix3 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
int[,] matrix4 = new int[2, 2] { { 5, 6 }, { 7, 8 } };

void printMatrix(int[,] m)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"{m[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] productMaxtix(int[,] m1, int[,] m2)
{
    return new int[2, 2]
        {
            {(m1[0,0] * m2[0,0] + m1[0,1] * m2[1,0]), (m1[0,0] * m2[0,1] + m1[0,1] * m2[1,1])},
            {(m1[1,0] * m2[0,0] + m1[1,1] * m2[1,0]),(m1[1,0] * m2[0,1] + m1[1,1] * m2[1,1])}
       };
}


printMatrix(matrix1);
printMatrix(matrix2);
printMatrix(productMaxtix(matrix1, matrix2));
//printMatrix(productMaxtix(matrix3, matrix4));