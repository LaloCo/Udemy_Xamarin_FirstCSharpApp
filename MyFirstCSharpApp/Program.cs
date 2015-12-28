using System;
using System.Threading.Tasks;

namespace MyFirstCSharpApp
{
	class MainClass
	{
		static Calculator calculator;
		public static void Main (string[] args)
		{
			calculator = new Calculator ();
			Start ();
		}

		public static async void Start()
		{
			Console.WriteLine("Write 2 numbers");
			float number1 = float.Parse(Console.ReadLine ());
			float number2 = float.Parse(Console.ReadLine ());

			Console.WriteLine ("Select an option\n1.-Add\n2.-Substract\n3.-Multiply\n4.-Divide\n5.-Exit");
			int option = int.Parse (Console.ReadLine ());

			EvaluateOption (option, number1, number2);

			var something = ConnectToInternet ();

			// do something else
			// do a lot of things

			var value = await something;

			//use the value
			Console.WriteLine(value);
		}

		public static void EvaluateOption(int option, float n1, float n2)
		{
			/*if (option == 1) {
				Console.WriteLine ("Result of the addition: " + AddTwoNumbers (n1, n2));
			} else if (option == 2) {
				Console.WriteLine ("Result of the substraction: " + SubstractTwoNumbers (n1, n2));
			} else if (option == 3) {
				Console.WriteLine ("Result of the multiplication: " + MultiplyTwoNumbers (n1, n2));
			} else if (option == 4) {
				Console.WriteLine ("Result of the division: " + DivideTwoNumbers (n1, n2));
			} else if (option == 5) {
				return;
			}
			else {
				Console.WriteLine ("Invalid option");
			}*/

			switch (option)
			{
			case 1:
				Console.WriteLine ("Result of the addition: " + calculator.AddTwoNumbers (n1, n2));
				break;
			case 2:
				Console.WriteLine ("Result of the substraction: " + calculator.SubstractTwoNumbers (n1, n2));
				break;
			case 3:
				Console.WriteLine ("Result of the multiplication: " + calculator.MultiplyTwoNumbers (n1, n2));
				break;
			case 4: 
				Console.WriteLine ("Result of the division: " + calculator.DivideTwoNumbers (n1, n2));
				break;
			case 5:
				return;
			default:
				Console.WriteLine ("Invalid option");
				break;
			}

			Start ();
		}

		public static async Task<String> ConnectToInternet()
		{
			// Connect to the internet
			// Download Something

			return "Something";
		}
	}
}
