using System;

namespace Delegates
{
    class Program
    {
    #region Task 1 - Arithmetic mea

     delegate int arithmeticMean(int a, int b, int c);
     
     #endregion
    
    #region Task 2 -- Lambda arithmetic operators
    public delegate int arithmeticOperators(int a, int b);
   
    #endregion


    #region Task 3 -- 

     public delegate int Number();
     public delegate int MediumCalc(Number[] arrayX);

    public static int Randomizer()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
           
        }
     

    #endregion
        static void Main(string[] args)
        {
     
        #region --Arithmetic mean
        /*
        arithmeticMean _arithmeticMean = delegate(int a, int b, int c)
        {
            return (a + b + c ) / 3;
        };
        _arithmeticMean(3, 5, 5);    
        */
       #endregion

       #region -- Task 2 Lambdas operators
        /*
         Console.WriteLine("Choose Input operator, such as --> +,-,*,/");
            string a = Console.ReadLine();            
            Console.WriteLine("Input firs value -->");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second value -->");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+": arithmeticOperators _arithmeticOperatorsAdd = (a, b) =>  a + b; 
                    int Add = _arithmeticOperatorsAdd(x, y);
                    Console.WriteLine("Answer is:{0}",Add);
                    break;
                case "-": arithmeticOperators _arithmeticOperatorsSub = (a, b) =>  a - b;
                    int Sub = _arithmeticOperatorsSub(x, y);
                    Console.WriteLine("Answer is:{0}", Sub);
                    break;
                case "*": arithmeticOperators _arithmeticOperatorsMul = (a, b) =>  a * b;
                    int Mul = _arithmeticOperatorsMul(x, y);
                    Console.WriteLine("Answer is:{0}", Mul);
                    break;
                case "/": arithmeticOperators _arithmeticOperatorsDiv = (a, b) => b == 0 ? 0 : a / b;
                    int Div = _arithmeticOperatorsDiv(x, y);
                    Console.WriteLine("Answer is:{0}", Div);
                    break;
                default: Console.WriteLine("Choose from the proposed:");
                    break;                
            }
 
             */
       #endregion

       #region Task 3 -----------------------------
        
        Number[] Arr = new Number[5];
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Randomizer;
                Console.Write(" " + Arr[i] + " ");
            }
            Console.WriteLine();
                
            MediumCalc mediumCalc = delegate (Number[] arrayX)
            {
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sum += arrayX[i]();
                }
                return ((sum) / (arrayX.Length));
            };

            
       #endregion

        Console.Read();


           
        }
    }
}
