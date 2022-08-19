double[,] create_list()
{
    Console.Write("Последовательно введите размер строк и столбцов:\nСтрок: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] list = new double[m, n];
    int length_y = list.GetLength(0);
    int length_x = list.GetLength(1);
    for (int i = 0; i < length_y; i++)
    {
        for (int j = 0; j < length_x; j++)
        {
            double number = new Random().NextDouble();
            int sign = new Random().Next(0, 2);
            if (sign == 0) sign = -1;
            else sign = 1;
            list[i, j] = Math.Round(number * 100 * sign, 2);
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
    return list;
}

double[,] list = create_list();
