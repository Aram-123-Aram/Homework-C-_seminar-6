/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Ax = 0;
double Ay = 0;

Console.WriteLine("Please, Enter the parametres: ");
Console.Write("                                 b1= ");
double.TryParse(Console.ReadLine()!, out double b1);
Console.Write("                                 k1= ");
double.TryParse(Console.ReadLine()!, out double k1);
Console.Write("                                 b2= ");
double.TryParse(Console.ReadLine()!, out double b2);
Console.Write("                                 k2= ");
double.TryParse(Console.ReadLine()!, out double k2);

// Когда две прямые линии пересекают,их координаты Х и У одинаковые,
//имея это в виду,получаем -> k1*x+b1 = k2*x+b2, x = (b2-b1)/(k1-k2), y = k1*(b2-b1)/(k1-k2)+b1

Ax = (b2-b1)/(k1-k2);
Ay = k1*(b2-b1)/(k1-k2)+b1;

Console.Write($" -> ({Ax}; {Ay})  ---Точка пересечения двух прямых следующая: A(Ax, Ay)= ({Ax}; {Ay})");