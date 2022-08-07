Console.Write("Введите значения: ");
string? numbers = Console.ReadLine();

int count = 0; // Счётчик чисел

for (int i = 0; i < numbers?.Length; i++) // Получаем кол-во чисел
{
    if (numbers[i] == ',') count++;
}

string[] list = new string[count + 1];
int list_index = 0;

string result = String.Empty; // Переменная, в которую записывается промежуточный результат

for (int i = 0; i < numbers?.Length + 1; i++)
{
    try // Это костыль, нужный для записи последнего числа
    {
        if (numbers![i] != ',' && numbers[i] != ' ') result += Convert.ToString(numbers[i]);
        else if (numbers[i] == ',')
        {
            list[list_index] = result;
            Console.Write($"{result}; ");
            result = String.Empty;
            list_index++;
        }
        else continue;
    }
    catch (IndexOutOfRangeException)
    {
        list[list_index] = result;
        Console.Write($"{result}");
    }
}

