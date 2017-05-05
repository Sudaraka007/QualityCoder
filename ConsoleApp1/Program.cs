using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            double[] numbers = new double[tokens.Length - 2];

            Calculator Calc = new Calculator();

            if (tokens[0].ToLower().Equals("calculate"))
            {
                for (int i = 0; i < tokens.Length - 2; i++)
                {
                    numbers[i] = float.Parse(tokens[i + 2]);
                }
                if (tokens[1].ToLower().Equals("min"))
                {
                    //Console.WriteLine("The Min is "+ CalculateMin(numbers));
                    Console.WriteLine("The Min is " + Calc.CalculateMin(numbers));

                }
                else if (tokens[1].ToLower().Equals("max"))
                {
                    //Console.WriteLine("The Max is "+ CalculateMax(numbers));
                    Console.WriteLine("The Min is " + Calc.CalculateMax(numbers));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
        }
    }
}
