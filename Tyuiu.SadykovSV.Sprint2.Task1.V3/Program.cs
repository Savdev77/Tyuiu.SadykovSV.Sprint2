using Tyuiu.SadykovSV.Sprint2.Task1.V3.Lib;

int a = 185;
int b = 316;
int c = 134;
int d = 134;

Console.Title = "Спринт #2 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^), а также арифметических      *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
Console.WriteLine("* (True, False, False, False, False, False)                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine($"* a = {a}                                                                *");
Console.WriteLine($"* b = {b}                                                                *");
Console.WriteLine($"* c = {c}                                                                *");
Console.WriteLine($"* d = {d}                                                                 *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
bool[] result = ds.GetLogicOperations(a, b, c, d);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}