Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second)
{
    Console.WriteLine("Максимальное число: " + first);
    Console.WriteLine("Минимальное число: " + second);
}
if (second > first)
{
    Console.WriteLine("Максимальное число: " + second);
    Console.WriteLine("Минимальное число: " + first);
}
if (second == first)
{
    Console.WriteLine("Числа равны");
}
