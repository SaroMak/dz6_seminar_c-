// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindeX(double k1, double k2, double b1, double b2)
{
    double x = 0;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double x, double k1, double b1 )
{
    double y = 0;
    y = k1 * x + b1;
   
    return y;
}
System.Console.WriteLine("введите k1");

double k1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("введите k2");

double k2 = double.Parse(Console.ReadLine());

System.Console.WriteLine("введите b1");

double b1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("введите b2");

double b2 = double.Parse(Console.ReadLine());

double x = FindeX(k1, k2, b1, b2);

double y = FindY(x, k1, b1);

System.Console.WriteLine($"( кординатыи пересечения  {x} , {y} ) ");