Console.WriteLine("Введите цифру: ");
int num = int.Parse(Console.ReadLine());
while (num <=7)
{

    if(num == 6 || num == 7)
    {
    Console.WriteLine("да");
    }

    else 
    {
    Console.WriteLine("нет");
    }
}

Console.WriteLine("Ошибка! Введите число от 1 до 7(количество дней недели)");