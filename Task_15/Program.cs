// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5) Console.WriteLine("Рабочий");
else if (day >=6 && day <=7) Console.WriteLine("Ура, выходной!");
else Console.WriteLine("В неделе 7 дней");
