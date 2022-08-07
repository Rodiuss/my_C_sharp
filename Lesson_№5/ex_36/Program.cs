Console.Write("Введите кол-во чисел: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] list = new int[length];

int summ = 0;

/* Если нам не нужны элементы на нечётных позициях,
то зачем нам их создавать? */

for (int i = 1; i < length; i += 2)
{
    list[i] = new Random().Next(1, 1000);
    summ += list[i];
}

for (int i = 0; i < length; i++) Console.Write($"{list[i]} ");

Console.WriteLine($"\n{summ}");
