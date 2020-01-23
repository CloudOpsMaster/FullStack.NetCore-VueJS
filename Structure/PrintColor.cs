using System;


public class PrintColor
{
    public enum Color { Red, Green, Blue }
    public void Print()
    {

        Color color = (Color)(new Random()).Next(0, 3);

        switch (color)
        {
            case Color.Red:
                Console.WriteLine("The color is red");
                break;
            case Color.Green:
                Console.WriteLine("The color is green");
                break;
            case Color.Blue:
                Console.WriteLine("The color is blue");
                break;
            default:
                Console.WriteLine("The color is unknown.");
                break;
        }

    }


}