Console.WriteLine("Даны уровнения:\ny = k1 * x + b1;\ny = k2 * x + b2;");
Thread.Sleep(800);
Console.Write("Введите значения:\nk1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

k1 = k1 - k2;
b1 = -(b1 - b2);

double x = Math.Round(b1 / k1, 2);
double y = Math.Round(k2 * x + b2, 2);

Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
