Console.Write("Введите кол-во чисел: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] list = new double[length];
double min = 999;
double max = 1;

for (int i = 0; i < length; i++)
{
    list[i] = Math.Round(new Random().NextDouble() * 1000, 2);
    Console.Write($"{list[i]} ");
    if (min > list[i]) min = list[i];
    if (max < list[i]) max = list[i];
}

Console.WriteLine($"\nРазность между min ({min}) и max ({max}): {max - min}");

