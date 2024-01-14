using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FizzBuzzConsoleApp
{
    delegate void FizzBuzzOutput(string output);

    class Program
    {
        static void DisplayFizzBuzz(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] agrs)
        {
            Run(DisplayFizzBuzz, 1, 100);
            Console.ReadKey();
        }

        public static void Run(FizzBuzzOutput output, int start, int increment)
        {
            for (var i = start; i < start + increment; i++)
            {
                var mod6 = i % 6 == 0;
                var mod4 = i % 4 == 0;

                else if (mod4 && mod6)
                    output("FizzBuzz");
                else if (mod6)
                    output("Buzz");
                else if (mod4)
                    output("Fizz");
                    output(i.ToString());


            }
        }
    }
}