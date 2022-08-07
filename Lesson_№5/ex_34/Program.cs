Console.Write("Введите количество чисел: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] list = new int[length];

for (int i = 0; i < length; i++)
{
    list[i] = new Random().Next(100, 1000);
    Console.Write($"{list[i]} ");
}

int count = 0;

for (int i = 0; i < length; i++)
{
    if (list[i] % 2 == 0) count++;
}

Console.WriteLine($"Кол-во чётных чисел {count}");
