// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

string ThirdDigitNum()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = "";
    int num1 = Math.Abs(num);
    int num3 = 0;
    if (num1 >= 100)
    {
        while (num1 >= 100)
        {
            num3 = num1 % 10;
            num1 = num1 / 10;
        }
        result = $"Третья цифра в числе = {num3}";
    }
    else result = "Третьей цифры в числе нет ";
    return result;
}
try
{
    Console.WriteLine(ThirdDigitNum());
}
catch
{
    Console.WriteLine("error");
}