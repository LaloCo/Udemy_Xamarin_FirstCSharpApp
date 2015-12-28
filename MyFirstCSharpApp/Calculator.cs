using System;

namespace MyFirstCSharpApp
{
	public class Calculator
	{
		public Calculator ()
		{
			
		}

		public float AddTwoNumbers(float n1, float n2)
		{
			float result = n1 + n2;

			return result;
		}

		public float SubstractTwoNumbers(float n1, float n2)
		{
			float result = n1 - n2;

			return result;
		}

		public float MultiplyTwoNumbers(float n1, float n2)
		{
			float result = n1 * n2;

			return result;
		}

		public float DivideTwoNumbers(float n1, float n2)
		{
			float result = n1 / n2;

			return result;
		}
	}
}

