using System;


class Printer
{
    public string Value { get; set; }
    public Printer(string value)
    {
        Value = value;
    }


    public void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(value);
        Console.ResetColor();
    }
}

class Display : Printer
{
    string _value {get; set;}
    public Display(string value) :base(value)
    {
       _value = value;
    }
}

