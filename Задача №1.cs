void OutputArray(int[,] SrcArray)
{
    for (int i = 0; i < SrcArray.GetLength(0); i++)
    {
        for (int j = 0; j < SrcArray.GetLength(1); j++)
        {
            Console.Write(SrcArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void asasdasd()
{
    // Заполняем массив рандомными числами
    Random rand = new Random();

    int[,] MegaArray = new int[12, 10];

    for (int i = 0; i < MegaArray.GetLength(0); i++)
    {
        for (int j = 0; j < MegaArray.GetLength(1); j++)
        {
            MegaArray[i, j] = rand.Next(0, 10);
        }
    }

    // Выводим массив в виде таблицы
    Console.WriteLine("Исходный массив в виде таблицы: ");
    OutputArray(MegaArray);

    int XCoordMax = 0;
    int YCoordMax = 0;


    // Происходит магия по поиску седловых точек, перебор массива и сравнение с минимальным и максимальным
    for (int i = 0; i < 12; i++)
    {
        int max = MegaArray[i, 0];
        for (int j = 0; j < MegaArray.GetLength(1); j++)
        {
            if (MegaArray[i, j] > max)
            {
                max = MegaArray[i, j];
                YCoordMax = j;
                XCoordMax = i;
            }

        }

        int min = MegaArray[i, YCoordMax];
        for (int q = 0; q < 12; q++)
        {
            if (MegaArray[q, YCoordMax] < min)
            {
                min = MegaArray[q, YCoordMax];
            }
        }

        if (min == max)
        {
            Console.WriteLine($"Седловая точка: {min} ({YCoordMax}, {XCoordMax})");
        } else
        {
            Console.WriteLine("Такие точки отсутсвуют");
        }
    }
}