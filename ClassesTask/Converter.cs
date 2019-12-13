
using System;

public class Converter
{
    double usd;
    double eur;
    double rub;



    public Converter()
    {
    }

    public Converter(double usd, double eur, double rub)
    {
        this.usd = usd;
        this.eur = eur;
        this.rub = rub;

    }

    public void Converting()
    {
        Console.WriteLine("Input 1 if chooce uan, 2 for usd, 3 for eur, 4 for rub ");
        int inputValue = int.Parse(Console.ReadLine());

        double UAN_BY = 23.5;
        double UAN_SELL = 23.9;
        double USD_BY = 23.5;
        double USD_SELL = 23.9;
        double EUR_BY = 26.1;
        double EUR_SELL = 26.6;
        double RUB_BY = 0.365;
        double RUB_SELL = 0.375;
        double inputUAN;
        double inputUSD;
        double inputEUR;
        double inputRUB;



        switch (inputValue)
        {
            case 1:
                Console.WriteLine("Input summ ( UAN ): ");
                inputUAN = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Input summ: " + inputUAN + " UAN");
                Console.WriteLine("Currency " + "   By   " + "   Sell   ");
                Console.WriteLine("USD:     " + inputUAN / USD_BY + "     " + inputUAN / USD_SELL);
                Console.WriteLine("RUB:     " + inputUAN / RUB_BY + "     " + inputUAN / RUB_SELL);
                Console.WriteLine("EUR:     " + inputUAN / EUR_BY + "     " + inputUAN / EUR_SELL);
                break;
            case 2:
                Console.WriteLine("Input summ ( USD ): ");
                inputUSD = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Input summ: " + inputUSD + " EUR");
                Console.WriteLine("Currency " + " By " + " Sell ");
                Console.WriteLine("EUR: " + inputUSD / EUR_BY + " " + inputUSD / EUR_SELL);
                Console.WriteLine("RUB: " + inputUSD * 36.5 + " " + inputUSD * 37.5);
                Console.WriteLine("UAN " + inputUSD * UAN_BY + " " + inputUSD * UAN_SELL);
                break;
            case 3:
                Console.WriteLine("Input summ ( EUR ): ");
                inputEUR = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Input summ: " + inputEUR + " UAD");
                Console.WriteLine("Currency " + " By " + " Sell ");
                Console.WriteLine("USD: " + inputEUR / EUR_BY + " " + inputEUR / EUR_SELL);
                Console.WriteLine("RUB: " + inputEUR / RUB_BY + " " + inputEUR / RUB_SELL);
                Console.WriteLine("UAN " + inputEUR / UAN_BY + " " + inputEUR / UAN_SELL);
                break;
            case 4:
                Console.WriteLine("Input summ ( RUB ): ");
                inputRUB = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Input summ: " + inputRUB + " UAD");
                Console.WriteLine("Currency " + " By " + " Sell ");
                Console.WriteLine("USD: " + inputRUB / EUR_BY + " " + inputRUB / EUR_SELL);
                Console.WriteLine("RUB: " + inputRUB / RUB_BY + " " + inputRUB / RUB_SELL);
                Console.WriteLine("UAN " + inputRUB / UAN_BY + " " + inputRUB / UAN_SELL);
                break;
            default:
                Console.WriteLine("Value is not valid");
                break;
        }



    }

}