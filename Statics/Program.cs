using System;
using System.Collections.Generic;
using static Calculator;
using static Sort;

namespace Statics
{

    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Calculator.Operations();

            //Task 2, 3
            //Sort.SortArray();

            // Task 4 
         /*   void Substring(int beginIndex, int endIndex)
            {
                string str = "My test string";
              
                List<char> newStr = new List<char>();
                string temp = "";
                for (int i = beginIndex; i < beginIndex + endIndex; i++)
                {
                    Console.WriteLine(str[i]);
                 
                   temp += str[i];
                }
                Console.WriteLine(temp);
            };

            Substring(2, 5);
           */
            /*
               void IndexOf(string Str)
               {
                   Str = "IndexOf";
                   char input = 'd';
                   for (int i = 0; i < Str.Length; i++ )
                   {
                       if (input == Str[i])
                       {
                         Console.WriteLine(i);
                       }
                     
                   }
               }

               IndexOf("IndexOf");
             */
               
               void Replace(string oldString, string newString)
               {
                   if (oldString != newString)
                   {
                       oldString = newString;
                       Console.WriteLine(newString);
                   } else  {
                        Console.WriteLine(oldString);
                   }
                  
               }

               Replace("abra kadabra", "it is new abra kadabra");
              
        }
    }
}
