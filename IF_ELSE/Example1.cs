using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ControlStatemets.IF_ELSE
{
	internal class Example1
	{
		public void Main()
		{
			// Assume the user's association with Teach2Give
			bool isTeach2GiveMember = true;

			// Check eligibility for a discount
			if (isTeach2GiveMember)
			{
				Console.WriteLine("Congratulations! You qualify for a special discount as a Teach2Give member.");
			}
			else
			{
				Console.WriteLine("Thank you for your interest. Unfortunately, you do not qualify for the Teach2Give discount.");
			}

		}
	}
}
