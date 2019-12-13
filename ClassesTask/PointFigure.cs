using System;

class Point
{
    public int A
    {
        get
        {
            return A;
        }
    }
    public int B
    {
        get
        {
            return B;
        }
    }
    public string Title
    {
        get
        {
            return Title;
        }
    }
    public Point() : this("", 0, 0) { }
    public Point(string Title, int A, int B)
    {
        Console.WriteLine("Enter a letter of Point:");
        Title = Console.ReadLine();
        Console.WriteLine("Enter X:");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y:");
        B = int.Parse(Console.ReadLine());

    }


}


public class Figure
{
    string Title;
    Point[] points;
    Figure(int A, int B, int C) { }
    Figure(int A, int B, int C, int D) { }
    Figure(int A, int B, int C, int D, int I) { }
    double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(A.A - B.A, 2) + Math.Pow(A.B - B.B, 2));
    }

    void PerimeterCalculator(int a, int n)
    {
        double perimeter = 0;
        perimeter += this.LengthSide(points[0], points[points.Length]);
        Console.WriteLine(perimeter);
    }

}