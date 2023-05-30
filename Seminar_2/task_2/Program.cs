var strnum = "1234";

int num;

bool isnumber = int.TryParse(strnum, out num);

if (isnumber && strnum.Length >= 3 )
{
    Console.WriteLine("Третьяя цифра числа: " + strnum[2]);
}

else
{
    Console.WriteLine("Ошибка! Строка должна состоять только из цифр!");
}