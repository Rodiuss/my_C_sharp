//Программа выводит в консоль спираль из цифр
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0,  y = 0; // А-ля координаты
int max = 1; // Переменная для остановки записи вовремя
int n = 1; // Переменная, которую будем вносить в массив
string [,] numbers = new string [number, number]; // Объявляем массив со строками

while (true) // Цикл
{
    for (int c = 0; c < number - max; c++) // Двигаемся вправо
    {
        numbers[y, x] += n;
        n++;
        x++;
    }
    for (int c = 0; c < number - max; c++) // Двигаемся вниз
    {
        numbers[y, x] += n;
        n++;
        y++;
    }
    for (int c = 0; c < number - max; c++) // Двигаемя влево
    {
        numbers[y, x] += n;
        n++;
        x--;
    }
    for (int c = 0; c < number - max; c++) // Двигаемя вверх
    {
        numbers[y, x] += n;
        n++;
        y--;
    }
    max += 2;
    x++;
    y++;
    if (max > number) break;
    if (max == number) // Это костыль. Без него программа не может выводить квадрат нечётного числа
    {
        numbers[y, x] += n;
        break;
    }
}

for (int i = 0; i < numbers.GetLength(0); i++) // Начинаем выводить массив
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (numbers[i, j].Length == 1) Console.Write($" {numbers[i, j]} "); // Что-бы было красиво добавляем пробелы
        else Console.Write($"{numbers[i, j]} ");
    }
    Console.WriteLine();
}
