
using System;

public class Invoice
{
    int account;
    string customer, provider;

    public Invoice(int _account, string _customer, string _provider)
    {
        account = _account;
        customer = _customer;
        provider = _provider;
    }

    public enum article { CellPhone = 100, PC = 500 };
    private int quantity;

    public void toPay()
    {
        Console.WriteLine("Enter quantity: ");
        quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose article ( 1 - CellPhone, 2 - PC ): ");

        int Article = Convert.ToInt32(Console.ReadLine());
        switch (Article)
        {
            case 1:
                Console.WriteLine(account * 100 + (account / 100) + " with tax");
                Console.WriteLine(account * 100 + "no tax");
                break;
            case 2:
                Console.WriteLine(account * 300 + (account / 300) + " with tax");
                Console.WriteLine(account * 300 + " no tax");
                break;
        }
    }

}