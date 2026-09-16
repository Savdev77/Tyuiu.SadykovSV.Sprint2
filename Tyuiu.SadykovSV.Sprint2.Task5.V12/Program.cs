using Tyuiu.SadykovSV.Sprint2.Task5.V12.Lib;
Console.Title = "Спринт #2 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
Console.WriteLine("* По заданным g, n и m определить дату предыдущего дня.                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
if ((n < 1) || (n > 31))
{
    Console.WriteLine("Ошибка: число n должно быть в диапазоне от 1 до 31.");
    return;
}
Console.WriteLine("Введите номер месяца m:");
int m = int.Parse(Console.ReadLine());
if ((m < 1) || (m > 12))
{
    Console.WriteLine("Ошибка: номер месяца m должен быть в диапазоне от 1 до 12.");
    return;
}
Console.WriteLine("Введите год g:");
int g = int.Parse(Console.ReadLine());
if (g < 1)
{
    Console.WriteLine("Ошибка: год g должен быть положительным числом.");
    return;
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds =new DataService();
string result = ds.FindDateOfPreviousDay(g, m, n);

Console.WriteLine($"Предыдущая дата: {result}");
Console.ReadKey();
