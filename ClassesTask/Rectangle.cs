using System;


class Rectangle
{
    double side1;
    double side2;

    public Rectangle()
    {

    }

    public Rectangle(double _side1, double _side2)
    {
        side1 = _side1;
        side2 = _side2;
    }

    double Area
    {
        get
        {
            return Area;
        }
    }
    double Perimeter
    {
        get
        {
            return Perimeter;
        }
    }

    public void AreaCalcilator(double side1, double side2)
    {
        double result = side1 * side2;
        // Console.WriteLine(result);
    }

    public void PerimeterCalculator(double side1, double side2)
    {
        double result = (side1 + side2) * 2;
        //Console.WriteLine(result);
    }

    public void Result()
    {
        Console.WriteLine("This program count area and perimeter of rectangle.");
        Console.WriteLine("");
        Console.WriteLine("Input value side 1");
        double inputSide1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input value side 2");
        double inputSide2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area ");
        AreaCalcilator(inputSide1, inputSide2);

        Console.WriteLine("Perimeter ");
        PerimeterCalculator(inputSide1, inputSide2);
    }

}