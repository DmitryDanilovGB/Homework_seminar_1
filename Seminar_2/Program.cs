/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


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