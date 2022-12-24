using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    internal class Calculate:IMethods
    {
     
        int Num1 { get; set; }
        int Num2 { get ; set; }  
        int Num3 { get; set; }
        string Symbol { get; set; }
        
        public void Sum(int num1,int num2)
        {
            Num3=num1+num2;
            Console.WriteLine(Num3);
            
        }
        public void Subtract(int num1,int num2)
        {
            Num3=num1-num2;
            Console.WriteLine(Num3);
            
        }
        public void Multiply(int num1,int num2)
        {
            Num3=num1*num2;
            Console.WriteLine(Num3);   
        }
        public void Divide(int num1,int num2)
        {
            Num3 = num1 / num2;
            Console.WriteLine(Num3);
        }
        public Calculate() 
        {
            Console.WriteLine("Enter the first number:");
            int Num1 = int.Parse(Console.ReadLine());
            if(Num1 == 0)
            {
                Console.WriteLine("Please write a greater or smaller number than 0:");
                Console.ReadLine();
            }
            Console.WriteLine("Enter the symbol:");
            string Symbol = (Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int Num2 = int.Parse(Console.ReadLine());
            

            while (Num1 != 0)
            {

                if (Symbol == "+")
            {
                Sum(Num1,Num2);
                break;
            }
            else if (Symbol == "-")
            {
                Subtract(Num1, Num2);
                break;
            }
            else if (Symbol == "*")
            {
                Multiply(Num1, Num2);
                break;
            }
            else if (Symbol == "/")
            {
                Divide(Num1,Num2);
                break;

            }
            else
            {
                Console.WriteLine("Please write a correct symbol:");
                Symbol=Console.ReadLine();
            }
                
            }




        }   
    }
}
