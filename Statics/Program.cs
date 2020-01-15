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
            void Substring(int beginIndex, int endIndex)
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

            /*
               string IndexOf(string Str)
               {
                   return Str;
               }
               string Replace(string Str1, string Str2)
               {
                   return Str1;
               }
              */
        }
    }
}
