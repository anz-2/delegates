using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
	delegate double Calculate(double num1, double num2);

	public class Calculator
	{
		public static double Sxvaoba(double number1, double number2)
		{
			return number1 - number2;
		}

		public static double Divide(double number1, double number2)
		{
			
			return number1 / number2;
		}
		public static double Multiply(double number1, double number2)
		{
			Func<double, double, double> multiply = delegate (double x, double y)
			{
				return x * y;
			};

			return multiply(number1, number2);
		}
	}
}
