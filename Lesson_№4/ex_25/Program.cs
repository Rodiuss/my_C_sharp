Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < b; i++) result = result * a;

Console.WriteLine($"Результат возведения в степень: {result}");
