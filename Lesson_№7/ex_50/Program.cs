int[,] create_list()
{

    int[,] list = new int[3, 3];
    int length = list.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            list[i, j] = new Random().Next(0, 11);
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
    return list;
}

int[,] list = create_list();

void choise()
{
    Console.Write("Как вы хотите искать что-то? По индексу (введите ноль) или по элементу (введите 1)?\nInput: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.Write("Хорошо, какой элемент будем искать?\nInput: ");
        int number = Convert.ToInt32(Console.ReadLine());
        find_index(list, number);
    }
    else if (choice == 0)
    {
        Console.Write("Хорошо, в каком месте ищем элемент?\nСтрока: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Столбец: ");
        int x = Convert.ToInt32(Console.ReadLine());
        find_number(list, x, y);
    }
}


void find_index(int[,] list, int number)
{
    int length = list.GetLength(0);
    int x = -1;
    int y = -1;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if (list[i, j] == number)
            {
                y = i;
                x = j;
            }
        }
    }
    if (x != -1) Console.WriteLine($"Элемент '{number}' находится на {y} строке и {x} столбце (если отсчитывать от нуля)");
    else Console.WriteLine($"Элемент '{number}' отсутствует");
}

void find_number(int[,] list, int x, int y)
{
    try
    {
        Console.WriteLine($"На {y} строке и {x} столбце на ходится элемент '{list[y, x]}'");
    }
    catch
    {
        Console.WriteLine($"Элемент на {y} строке и {x} столбце отсутсвует");
    }
}
choise();