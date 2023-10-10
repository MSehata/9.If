using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an operator. (+, -, / or *) ");
            string op = Console.ReadLine();
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                if (op == "+")
                {
                    double sum = num1 + num2;
                    Console.WriteLine("Your sum is :" + sum);
                }
                else if (op == "-")
                {
                    double diff = num1 - num2;
                    Console.WriteLine("Your Difference is: " + diff);
                }
                else if (op == "*")
                {
                    double product = num1 * num2;
                    Console.WriteLine("Your product is: " + product);
                }
                else if (op == "/")
                {
                    double division = num1 / num2;
                    Console.WriteLine("Your division is: " + division);
                }
                else
                    Console.WriteLine("Enter the right operator!");

            }

            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
