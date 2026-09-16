using Tyuiu.SadykovSV.Sprint2.Task7.V12.Lib;
Console.Title = "Спринт #2 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к проекту итоговых решений по спринту                  *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#,                                               *");
Console.WriteLine("* которая запрашивает исходные данные (вещественные значения)             *");
Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y                      *");
Console.WriteLine("* в заштрихованной области.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите координату x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);
if (res)
{
    Console.WriteLine($"Точка с кординатами ({x};{y}) находится в заштрихованной области!");
}
else
{
    Console.WriteLine($"Точка с кординатами ({x};{y}) не находится в заштрихованной области!");
}
Console.ReadKey();