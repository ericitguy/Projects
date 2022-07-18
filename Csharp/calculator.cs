using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			  //Declaration of variables
            double input1;
            double input2;
            string op;
            double solution =0.0;


            Console.WriteLine("Please enter the first number");
            input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the Operator");
            op = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            input2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            { solution = input1 + input2; }
            else if (op == "-")
            {
                solution = input1 - input2;

            }
            else if (op == "*")
            {
                solution = input1 * input2;

            }
            else if (op == "/")
            {
                solution = input1 / input2;
            }
            else if (op == "%")
            {
                solution = input1 % input2;
            }

            else
            {

                Console.WriteLine("You entered wrong operator");
            }

            Console.Write("The Solution is: ");
            Console.Write(Convert.ToString(solution));

            Console.ReadLine();
            
		}
	}
}
