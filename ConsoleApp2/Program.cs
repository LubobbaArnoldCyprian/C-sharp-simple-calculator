using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");


            // ask the user what he wants to do

            Console.WriteLine("Choose your operation"); 
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("enter your choice");

            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine(" You have chosen Addition");
                Console.WriteLine("enter input 1: ");
                Int64 a = Int64.Parse(Console.ReadLine());
                Console.WriteLine("enter input 2: ");
                Int64 b = Int64.Parse(Console.ReadLine());

                Int64 sum = a + b;

                Console.WriteLine("The sum of {0} and {1} is {2}", a, b, sum);
            }
            else if (x == 2)
            {

                Console.WriteLine(" You have chosen subtraction");
                Console.WriteLine("enter input 1: ");
                Int64 a = Int64.Parse(Console.ReadLine());
                Console.WriteLine("enter input 2: ");
                Int64 b = Int64.Parse(Console.ReadLine());

                Int64 subtraction = a - b;

                Console.WriteLine("The result of {0} - {1} is {2}", a, b, subtraction);

            }

            else if ( x == 3)
            {

                Console.WriteLine(" You have chosen Multiplication");
                Console.WriteLine("enter input 1: ");
                Int64 a = Int64.Parse(Console.ReadLine());
                Console.WriteLine("enter input 2: ");
                Int64 b = Int64.Parse(Console.ReadLine());

                Int64 Multiplication = a * b;

                Console.WriteLine("The result of {0} * {1} is {2}", a, b, Multiplication);
            }

            else if ( x == 4)
            {
                Console.WriteLine(" You have chosen division");
                Console.WriteLine("enter input 1: ");
                Int64 a = Int64.Parse(Console.ReadLine());
                Console.WriteLine("enter input 2: ");
                Int64 b = Int64.Parse(Console.ReadLine());

                Int64 Division = a / b;

                Console.WriteLine("The result of {0} / {1} is {2}", a, b, Division);
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }





        }

    }
}
