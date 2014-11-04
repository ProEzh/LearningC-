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
            double resultOfAddition = Math.addition(2, 3);
            Console.WriteLine(resultOfAddition);

            double resultOfSubstraction = Math.subtraction(2, 3);
            Console.WriteLine(resultOfSubstraction);

            double resultOfMultiplication = Math.multiplication(2, 3);
            Console.WriteLine(resultOfMultiplication);

            double resultOfDivision = Math.division(2, 3);
            Console.WriteLine(resultOfDivision);
        }
    }
    static class Math
    {
        static public double addition(double a, double b) 
        {
            return a + b;
        }
		static public double subtraction(double a, double b)
        {
            return a - b;
        }
		static public double multiplication(double a, double b)
        {
            return a * b;
        }
		static public double division(double a, double b)
        {
            return a / b;
        }

    }
}
