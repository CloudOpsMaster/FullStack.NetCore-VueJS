using System;
public static class Calculator
{
    public static double x {get; set;}
    public static double y {get; set;}
    public static char operators {get; set;}

    public static  double addition(double x, double y) => x + y;
    public static  double subtraction(double x, double y) => x - y;
    public static  double multiplication(double x, double y) => x * y;
    public static  double division(double x, double y) => x / y;

    public static void Operations()
    {
        Console.WriteLine(" It is calculator :) ");
        Console.WriteLine( " + , - , * , / " ) ;
        Console.WriteLine( "" );
        Console.WriteLine( "" );
        Console.WriteLine( "Input value " ) ;
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine( "Input operator " ) ;
        operators = Convert.ToChar(Console.ReadLine());
        Console.WriteLine( "Input value " ) ;
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine( "" );
       
        switch(operators)
        {
           case '+':  Console.WriteLine(addition(x, y));
           break;
           case '-': subtraction(x, y);
           break;
           case '*': multiplication(x, y);
           break;
           case '/': division(x, y);
           break;
        }
    }
}