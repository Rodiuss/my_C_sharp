Console.Write("Последовательно введите x, y, и z координаты первой точки:\nx: ");
double a_x = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double a_y = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double a_z = Convert.ToDouble(Console.ReadLine());
Console.Write("Теперь введите координаты второй точки:\nx: ");
double b_x = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double b_y = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double b_z = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow((Math.Pow((a_x - b_x), 2) + Math.Pow((a_y - b_y), 2) + Math.Pow((a_z - b_z), 2)), 0.5);

Console.WriteLine("Расстояние между точками: " + Math.Round(result, 2));
