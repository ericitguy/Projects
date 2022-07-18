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
            double solution;


            Console.WriteLine("Please enter the first number");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            input2 = Convert.ToInt32(Console.ReadLine());

            solution = input1 + input2;

            Console.WriteLine(solution);
            
		}
	}
}