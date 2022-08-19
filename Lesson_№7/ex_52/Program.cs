void create_list()
{
    int[,] list = new int[4, 4];
    int length_0 = list.GetLength(0);
    int length_1 = list.GetLength(1);
    double temp = 0;

    for (int i = 0; i < length_0; i++)
    {
        for (int j = 0; j < length_1; j++)
        {
            list[i, j] = new Random().Next(0, 11);
            temp += list[i, j];
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine($"--> {temp / length_0}");
        temp = 0;
    }
}

create_list();
