Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int count = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;

for (int i = 1; i <= count; i++) result = result + Math.Pow(i, 2) + ", " ;

Console.WriteLine("Квадраты числа " + number + ": " + result);
