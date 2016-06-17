using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int subtract(int a, int b)
        {
            if (a < b)
                return 0;
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public double divide(int a, int b)
        {
            return a / b;
        }

        public double expo(int a, int b)
        {
            return a ^ b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            var result = calc.add(75896, 45674);
            Console.WriteLine(result); 
        }
    }
}
