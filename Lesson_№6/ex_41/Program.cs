int[] create_list() // Функция принимает числа и создаёт на их основе массив
{
    Console.Write("Введите числа: ");
    string? numbers = Console.ReadLine();

    int count = 0; // Счётчик чисел

    for (int i = 0; i < numbers?.Length; i++) // Получаем кол-во чисел
    {
        if (numbers[i] == ',') count++;
    }
    int[] list = new int[count + 1];
    int list_index = 0;

    string result = String.Empty; // Переменная, в которую записывается промежуточный результат

    for (int i = 0; i < numbers?.Length + 1; i++)
    {
        try // Это костыль, нужный для записи последнего числа
        {
            if (numbers![i] != ',' && numbers[i] != ' ') result += Convert.ToString(numbers[i]);
            else if (numbers[i] == ',')
            {
                list[list_index] = Convert.ToInt32(result);
                Console.Write($"{result}; ");
                result = String.Empty;
                list_index++;
            }
            else continue;
        }
        catch (IndexOutOfRangeException)
        {
            list[list_index] = Convert.ToInt32(result);
            Console.Write($"{result}");
        }
    }
    return list;
}

int[] list_with_num = create_list();
int count = 0;

foreach (int unit in list_with_num)
{
    if (unit > 0) count++; 
}

Console.Write($" --> {count} (кол-во положительных чисел)");
