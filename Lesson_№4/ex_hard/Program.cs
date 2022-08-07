void deff ()
{
    Console.Write("Введите сообщение: ");
    string? message = Convert.ToString(Console.ReadLine());

    int index = 0;

    string result = String.Empty;
    while (index < message?.Length)
    {
        char unit = message[index];
        if (unit == ' ')
        {
            result = $"{result} ";
            index++;
            continue;
        }
        int count = 0;

        try
        {
            while (Convert.ToChar(message[index]) == unit)
            {
                count++;
                index++;
            }
        }

        catch (IndexOutOfRangeException)
        {
            result = $"{result}{unit}{count}";
            break;
        }

        result = $"{result}{unit}{count}";
    }

    Console.WriteLine(result);
}

deff();
