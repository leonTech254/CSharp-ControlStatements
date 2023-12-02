using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ControlStatemets.SWITCH
{
	internal class Example_Swirch1
	{

		public void main()
		{
			string userRole = "volunteer";

			// Use a switch statement to provide a personalized message based on the user's role
			switch (userRole)
			{
				case "employee":
					Console.WriteLine("Welcome valued employee! Thank you for your dedicated service to Teach2Give.");
					break;

				case "volunteer":
					Console.WriteLine("Hello volunteer! Your contributions make a significant impact on our initiatives.");
					break;

				case "donor":
					Console.WriteLine("Thank you for your generosity! Your donations play a crucial role in supporting Teach2Give's mission.");
					break;

				default:
					Console.WriteLine("Welcome! We appreciate your interest in Teach2Give.");
					break;
			}
		}
	}
}
