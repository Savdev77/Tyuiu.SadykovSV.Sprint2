using Tyuiu.SadykovSV.Sprint2.Task4.V13.Lib;
Console.Title = "Спринт #2 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
Console.WriteLine("* с использованием тернарного оператора,                                  *");
Console.WriteLine("* где пользователь вводит значение переменных x,y с клавиатуры.           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

double result = ds.Calculate(x, y);
Console.WriteLine($"Для x = {x}, y = {y}, значение функции z = {result}");

Console.ReadKey();