using System;
class Program
{
    static double F1(double x)
    {
        return Math.Pow(2.3, x) - 3 * Math.Pow(x,2);
    }
    static double F2(double x)
    {
        return Math.Pow(x,3) - 0.1 * Math.Pow(x,2) + 0.4 * x + 1.2;
    }
    static void Separate(Func<double, double> f, double a, double b, double h)
    {
        double x = a;
        double fPrev = f(x);
        while (x + h <= b)
        {
            double xNext = x + h;
            double fNext = f(xNext);
            if (fPrev * fNext <= 0)
            {
                Console.WriteLine($"Корень на отрезке [{x:F2}; {xNext:F2}]");
            }
            x = xNext;
            fPrev = fNext;
        }
    }
    static void Main()
    {
        Console.WriteLine("Уравнение 1: (2.3)^x - 3x^2 = 0");
        Separate(F1, -2, 7, 0.1);
        Console.WriteLine();
        Console.WriteLine("Уравнение 2: x^3 - 0.1x^2 + 0.4x + 1.2 = 0");
        Separate(F2, -2, 2, 0.1);
    }
}