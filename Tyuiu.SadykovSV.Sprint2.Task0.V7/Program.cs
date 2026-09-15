using Tyuiu.SadykovSV.Sprint2.Task0.V7.Lib;
Console.Title = "Спринт #2 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений(==, !=, <, >, <=, >=)          *");
Console.WriteLine("* и арифметических выражений,которая вернет логическую последовательность:*");
Console.WriteLine("* (True, False, True, True, True, False)                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("* x=103 y= 475                                                            *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int x = 103;
int y = 475;
bool[] results = ds.GetCompareOperations(x, y);
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(results[i]);
}
Console.ReadKey();  