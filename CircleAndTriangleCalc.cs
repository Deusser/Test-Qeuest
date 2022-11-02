using System;
class CircleAndTriangleCalc {
    public double Circle(double R)
    {
        return Math.PI * Math.Pow(R, 2);
    }

    public double Triangle(double a, double b, double c)
    {
        double p = a + b + c,
        halfP = p / 2,
        s = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
        return s;
        if (a * a + b * b == c * c)
        Console.WriteLine("Этот треугольник прямоугольный");
        else
        Console.WriteLine("Этот треугольник не прямоугольный")
    }
}
