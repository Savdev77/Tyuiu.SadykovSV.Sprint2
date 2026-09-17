using Tyuiu.SadykovSV.Sprint2.Task2.V27.Lib;

Console.Title = "Спринт #2 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
Console.WriteLine("* в заштрихованной области.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите координату X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
bool result = ds.CheckDotInShadedArea(x, y);
if (result)
{
    Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области.");
}
else
{
    Console.WriteLine($"Точка с координатами ({x}, {y}) не находится в заштрихованной области.");
}
