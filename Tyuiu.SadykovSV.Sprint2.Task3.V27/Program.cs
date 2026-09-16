using Tyuiu.SadykovSV.Sprint2.Task3.V27.Lib;
Console.Title = "Спринт #2 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if-else                                       *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
Console.WriteLine("* с использованием вложенных оператор if-else,                            *");
Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.Calculate(x);

Console.WriteLine($"Для x = {x}, значение функции y = {result}");

Console.ReadKey();