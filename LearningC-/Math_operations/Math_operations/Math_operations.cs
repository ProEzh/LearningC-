using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Math_operations ob = new Math_operations();
            double add_result = ob.addition(2, 3);
            double sub_result = ob.subtraction(2, 3);
            double mult_result = ob.multiplication(2, 3);
            double div_result = ob.division(2, 3);
            Console.WriteLine(add_result);
            Console.WriteLine(sub_result);
            Console.WriteLine(mult_result);
            Console.WriteLine(div_result);
        }
    }
    class Math_operations 
    {
        public double addition(double a, double b) 
        {
            return a + b;
        }
        public double subtraction(double a, double b)
        {
            return a - b;
        }
        public double multiplication(double a, double b)
        {
            return a * b;
        }
        public double division(double a, double b)
        {
            return a / b;
        }

    }
}
