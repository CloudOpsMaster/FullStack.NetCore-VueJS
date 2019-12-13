using System;
using static Printer;
using static Pupil;
using static ClassRoom;
using static Vehicle;
using static DocumentWorker;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 ( Printer.)
            /*
             Printer printer1 = new Printer("Text");
             Display display = new  Display("Text2");
             display.Print("1");
            */

            // Task 2 ( ClassRoom )
            /* 
            Pupil vasiliy = new Pupil("Bob");
            Pupil dmitriy = new BadPupil("Bill");
                 
            var fClassRoom = new ClassRoom(vasiliy);
            var sClassRoom = new ClassRoom(vasiliy, dmitriy);
           */

            // Task 3 (Vehicle)
            /* 
            Vehicle car = new Vehicle();
            car.YearOfLaunch = 2000;
            car.Price = 2000;
            car.Speed = 250;

            Vehicle plane = new Vehicle();

            Plane Boing747 = new Plane();
            Boing747.CoordinateX = 1000;
            Boing747.CoordinateY = 3456;
            Boing747.Speed = 800;
            Boing747.Price = 300000;
            Boing747.YearOfLaunch = 30;

            Car Reno = new Car();
            Reno.CoordinateX = 1000;
            Reno.CoordinateY = 3456;
            Reno.Speed = 800;
            Reno.Price = 300000;
            Reno.YearOfLaunch = 30;

            Ship Titanic = new Ship();
            Titanic.CoordinateX = 1000;
            Titanic.CoordinateY = 3456;
            Titanic.Speed = 800;
            Titanic.Price = 300000;
            Titanic.YearOfLaunch = 30;
            */


            //Task 4  (DocumentWorker)
            /* 
            DocumentWorker documentWorker = new DocumentWorker();
            ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
            ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
            string key =  Console.ReadLine();
            switch(key)
            {
                case "pro" : proDocumentWorker = new ProDocumentWorker() ;
                break;
                case "exp": expertDocumentWorker = new ExpertDocumentWorker();
                break;
                default: documentWorker = new DocumentWorker();;
                break;
            }
            */
            Console.ReadKey();

        }
    }
}
