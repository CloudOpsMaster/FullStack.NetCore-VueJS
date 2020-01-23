using System;
using System.Linq;
using static Notebook;
using static Traine;
using static PrintColor;
using static Accauntant;

namespace Structure
{

    /* Task 3
    class MyClass
    {
        public string change;
    }
 
    struct MyStruct
    {
        public string change;
        public void StruktTaker()
        {
            change = "Значение изменилось";
        }
    }

    */
    class Program
    {
        static void Main(string[] args)
        {
            #region   // 1 Notebook  
            /*
                Notebook Note = new Notebook();
                Console.WriteLine(Note.model);
                Console.WriteLine(Note.manufacturer); 
                Console.WriteLine(Note.price);

            */
            #endregion
            #region  Task 2 Traine ------------------------------------------------------------
            /*
            public void SomeTraine()
            {

                Traine[] mainTraine = new Traine[];

                for (int i = 0; i < mainTraine.Count(); i++)
                {
                    Console.WriteLine("Input destination:  ");
                    mainTraine[i].destination = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Input number of traine: ");
                    mainTraine[i].numberTrain = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input date: ");
                    mainTraine[i].departureTime = Convert.ToDateTime(Console.ReadLine());

                }
                string str; bool If = true; int count = 0;
                while (If)
                {
                    Console.WriteLine("Input destination");
                    str = Console.ReadLine();

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (char.IsDigit(str[i]) && (Convert.ToInt32(str[i]) <= 6 || Convert.ToInt32(str[i]) >= 0)) count++;
                    }

                    if (count == str.Length)
                    {
                        foreach (Traine c in mainTraine)
                        {
                            if (str == c.destination.ToString()) Console.WriteLine(c.ToString());
                        }
                        If = false;
                    }
                    else Console.WriteLine("Please, return input");
                }

                Console.ReadLine();

            }
                  */
            #endregion


            #region Task 3 --------------------------------------
            /*

            void ClassTaker(MyClass myClass)
            {
                myClass.change = "Value has changed";
            }

            void StruktTaker(MyStruct myStruct)
            {
                myStruct.change = "Value has changed";
            }

            MyClass mainClass = new MyClass();
            MyStruct mainStruct = new MyStruct();

            mainClass.change = "The value has not changed";
            mainStruct.change = "The value has not changed";

            ClassTaker(mainClass);
            mainStruct.StruktTaker();

            Console.WriteLine(mainClass.change);
            Console.WriteLine(mainStruct.change);
            Console.ReadKey();
            */

            #endregion---------------------------------------

            #region  Task 5 Print color ----------------------------------------
            /*
            PrintColor newColor = PrintColor();
            newColor.Print();
            */
            #endregion

          
            #region Task 6 Accauntant
             /*
            Accauntant accauntant = new Accauntant();

            if (accauntant.AskForBonus(Post.Manager, 50))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
              */
            #endregion
          
        }
    }
}

