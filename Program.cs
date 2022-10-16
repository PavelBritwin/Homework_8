// Task60
Console.Clear();

int[,,] createAndShowArray(int raw, int column, int depth)
{
    int indexElement = 0;
    int[,,] array = new int[raw, column, depth];
    int[] knownElements = new int[raw * column * depth]; // Массив известных чисел
    // Заполняем массив известных чисел 0
    int m = 0;
    while (m < raw * column * depth)
    {
        knownElements[m] = 0;
        m++;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[j, k, i] = new Random().Next(10, 40);
                indexElement = 0;
                // Сравниваем новый элемент с элементами массива известных чисел. Если необходимо: генерируем новое число и записываем его в массив известных чисел
                while (indexElement < knownElements.Length)
                {
                    if (knownElements[indexElement] == array[j, k, i])
                    {
                        //Console.WriteLine($"!!!{array[j, k, i]}({j},{k},{i}) ");
                        array[j, k, i] = new Random().Next(10, 40);
                        indexElement = 0;
                    }
                    if (knownElements[indexElement] == 0)
                    {
                        knownElements[indexElement] = array[j, k, i];
                        break;
                    }
                    indexElement++;
                }
                indexElement = 0;
                Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
    return array;
}

createAndShowArray(3, 3, 3);