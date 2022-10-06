// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5

string SecondDigitNum()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = "";
    int num1 = Math.Abs(num);
    int num3 = 0;
    if (num1 >= 10)
    {
        while (num1 >= 10)
        {
            num3 = num1 % 10;
            num1 = num1 / 10;
        }
        result = $"Вторая цифра в числе = {num3}";
    }
    else result = "Второй цифры в числе нет ";
    return result;
}
try
{
    Console.WriteLine(SecondDigitNum());
}
catch
{
    Console.WriteLine("error: Необходимо вводить цифры");
}
