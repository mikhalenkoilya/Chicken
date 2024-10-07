bool isAlive = true;
int chickenEggs = 0;
int playerEggs = 0;
int hungryChicken = 2;
int overeating = 10;
int nestValue = 4;

while (isAlive)
{
    Console.WriteLine($"Количество яиц у курицы: {chickenEggs} Количетсво яиц у игрока: {playerEggs}");
    Console.WriteLine($"Текущая шкала сытость курицы {hungryChicken}/{overeating}");
    Console.WriteLine($"Чтобы курица снесла яйцо шкала сытости не должена быть ниже {nestValue}");
    Menu();

    if (hungryChicken > 0 && hungryChicken <= overeating)
    {
        if (hungryChicken < nestValue)
        {
            Console.WriteLine("Курица не наелась чтобы снести яйцо\n");
        }
        else
        {
            Console.WriteLine("Курица достаточно сыта чтобы снести яйцо\n");
            chickenEggs++;
        }
    }
    else
    {
        isAlive = false;
        Console.Write("Ваша курица умерла ");
        if (hungryChicken > overeating)
        {
            Console.WriteLine("от переедания");
        }
        else
        {
            Console.WriteLine("от голода");
        }
    }
    hungryChicken--;
}

void Menu()
{
    Console.WriteLine("Выберите действие\n1)покормить курицу \n2)Взять яйцо \n3)Пропустить ход");
    string? userChoice = Console.ReadLine();
    Console.WriteLine("");
    switch (userChoice)
    {
        case "1":
            Feed();
            break;

        case "2":
            TakeEgg();
            break;

        case "3":
            SkipTurn();
            break;

        default:
            Console.WriteLine("Введите 1-3");
            break;
    }
}
void Feed()
{
    try
    {
        Console.WriteLine("Количество зерен: ");
        int grainNumber = int.Parse(Console.ReadLine());
        if (grainNumber >= 3 && grainNumber <= 5)
        {
            hungryChicken += grainNumber;
        }
        else
        {
            Console.WriteLine("Введите число от 3 до 5");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Неправильный ввод данных");
    }
}
void TakeEgg()
{   if (chickenEggs > 0)
    {
        playerEggs++;
        chickenEggs--;
    }
    else
    {
        Console.WriteLine("Курица не снесла яйцо");
    }
    
}

void SkipTurn()
{
}