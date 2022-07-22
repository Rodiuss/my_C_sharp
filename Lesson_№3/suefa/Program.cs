Console.Clear();
Console.Write("Добро пожаловать в игру 'камень, ножницы, бумага!'\nВведите кол-во раундов, либо введите 0, если хотите перейти в бесконечный режим:\n> ");
int range = Convert.ToInt32(Console.ReadLine()); // Кол-во раундов 
int en_count = 0; // Счётчики обед enemy/player
int pl_count = 0;
Random run = new Random();
if (range == 0) range = Int32.MaxValue;
Thread.Sleep(800);
Console.WriteLine("Игра начинается!");
Thread.Sleep(800);
Console.Clear();
for (int i = 0; i < range; i++) // Начинаем игру
{
    int en_character = run.Next(0, 4); // Выбор компьютера
    Console.Write("Выберете бойца, введя его номер:\n1. камень\n2. ножницы\n3. бумага\n> ");
    int character = Convert.ToInt32(Console.ReadLine()); // Выбор игрока
    Thread.Sleep(800);
    if (character != 1 && character != 2 && character != 3) // Что-бы не крашилось по середине 
    {
        Console.WriteLine("Введите номер бойца корректно!");
        i--;
        Thread.Sleep(800);
        Console.Clear();
        continue;
    }
    if (en_character == 1) // Если компьютер выбрал камень
    {
        Console.Write("Соперник выбрал камень - ");
        if (character == 2) 
        {
            Console.WriteLine("вы проиграли");
            en_count++;
        }
        else if (character == 3)
        {
            Console.Write("вы выйграли");
            pl_count++;
        }
        else Console.Write("Ничья");
    }
    else if (en_character == 2) // Если компьютер ножницы
    {
        Console.Write("Соперник выбрал ножницы - ");
        if (character == 3)
        {
            Console.Write("вы проиграли");
            en_count++;
        }
        else if (character == 1)
        { 
            Console.Write("вы выйграли");
            pl_count++;
        }
        else Console.Write("ничья");
    }
    else //Если компьютер выбрал бумагу
    {
        Console.Write("Соперник выбрал бумагу - ");
        if (character == 1)
        {
            Console.Write("вы проиграли");
            en_count++;
        }
        else if (character == 2)
        {
            Console.Write("вы выйграли");
            pl_count++;
        }
        else Console.Write("ничья");
    }
    Thread.Sleep(600);
    Console.WriteLine($"\n\nТекущий счёт - {pl_count} : {en_count}\n"); // Выводим промежуточный результат
    Thread.Sleep(800);
    Console.WriteLine("Нажмите Enter для продолжения");
    string? num = Convert.ToString(Console.ReadLine());
    Console.Clear();
}
Thread.Sleep(800);
Console.WriteLine($"Итоги - {pl_count} : {en_count}");
Thread.Sleep(800);
Console.Write("Победитель - ");
if (pl_count > en_count) Console.Write("игрок");
else if (pl_count < en_count) Console.Write("компьютер");
else Console.Write("остался не выбранным");
