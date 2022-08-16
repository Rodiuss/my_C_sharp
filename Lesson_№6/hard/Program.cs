int[,] create_list(int count)
{
    int[,] list = new int[count, count];

    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            list[i, j] = new Random().Next(-10, 11);
            if (list[i, j] >= 0 && list[i, j] != 10) Console.Write($"  {list[i, j]} ");
            else if (list[i, j] == 10) Console.Write($" {list[i, j]} ");
            else if (list[i, j] < 0 && list[i, j] != -10) Console.Write($" {list[i, j]} ");
            else Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
    return list;
}


void create_result(int[,] first_list)
{
    int count = first_list.GetLength(0);
    int[,] list = new int[count,count];
    int x1 = 0;
    int x2 = 0;
    int y1 = 0;
    int y2 = 0;
    
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            if (i != count - 1 && i != 0)
            {
                y1 = i - 1;
                y2 = i + 1;
            }
            if (i == 0)
            {
                y1 = count - 1;
                y2 = i + 1;
            }
            if (i == count - 1)
            {
                y1 = i - 1;
                y2 = 0;
            }

            if (j != count - 1 && j != 0)
            {
                x1 = j - 1;
                x2 = j + 1;
            }
            if (j == 0)
            {
                x1 = count - 1;
                x2 = j + 1;
            }
            if (j == count - 1)
            {
                x1 = j - 1;
                x2 = 0;
            }

            list[i, j] = first_list[i, x1] + first_list[i, x2] + first_list[y1, j] + first_list[y2, j];

            if (list[i, j] <= -10) Console.Write($" {list[i, j]}");
            else if (list[i, j] >= 10 || (list[i, j] < 0 && list[i, j] > -10)) Console.Write($"  {list[i, j]}");
            else if (list[i, j] >= 0 && list[i, j] < 10) Console.Write($"   {list[i, j]}");
            else Console.Write($"{list[i, j]}");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размерность матрицы: ");
int count = Convert.ToInt32(Console.ReadLine());

int[,] first_list = create_list(count);

Console.WriteLine("--------------------------------------------");

create_result(first_list);
