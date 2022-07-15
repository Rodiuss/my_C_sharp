Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a != number)
{
    if (a % 2 == 0)
    {
        Console.Write(a + " ");
    }
    a++;
}
