using System;
using static Address;
using static Rectangle;
using static Book;
using static Employee;
using static Invoice;

using static User;
using static Converter;

namespace HWNetCore3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task № 1 ( class Address )________________________________________________________________________________
            /* Address DneprAddress = new Address(1, "Ukraine", "Dnepr", "Shevchenko", 1 , 43);
            Console.WriteLine(DneprAddress.Index + " country: " +  DneprAddress.Country + " city: " + DneprAddress.City +  
             " street: " + DneprAddress.Street + " house: " + DneprAddress.House );
            Console.ReadKey();
             */

            // Task № 2 ( Rectangle )____________________________________________________________________________________
            /* Rectangle rectangle = new Rectangle();
            rectangle.Result();
            Console.ReadKey();
            */

            //Task 3 ( Book )
            /* Book.Author BA_1 = new Book.Author();
             Book.Title BT_1 = new Book.Title();
             Book.Content BC_1 = new Book.Content();
             BA_1.Show("Tom Ch");
             BT_1.Show("Child Book");
             BC_1.Show("Interesting Book");
             */

            // Task 4 ( Figure ) 
            // Figure someFigure = new Figure("Figure");
            // Console.WriteLine(someFigure.CalculatePerimeter());

            // Task 5 ( User )
            // User user = new User("Vasia89", "Vasia", "Petrov", 43, DateTime.Today.ToShortDateString());


            // Task 6  ( Converter )
            /* Converter converter = new Converter();
             converter.Converting();
             */

            //Task 7
            // Employee employee = new Employee("Vasia", "Krot");
            // employee.Experience();

            // Task 8 
            // Invoice invoice = new Invoice(5, "IT Integrator", "Microsoft");



            Console.ReadKey();
        }

    }
}
