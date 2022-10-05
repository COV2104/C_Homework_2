// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num3 =0;
if (num >= 100)
{
    while (num >= 100)
    {
        num3 = num %10;
        num = num /10;
    }
    Console.WriteLine ($"Третья цифра в числе = {num3}");
}


else Console.WriteLine("Третьей цифры в числе нет ");