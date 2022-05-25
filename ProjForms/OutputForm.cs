using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProjForms
{
	static class OutputForm
	{
		static void Main()
		{
			int firstNumber = Int32.Parse(Interaction.InputBox("Enter the first number", "Sum and Difference"));
			int secondNumber = Int32.Parse(Interaction.InputBox("Enter the second number", "Sum and Difference"));
			int sum = firstNumber + secondNumber;
			int difference = firstNumber - secondNumber;
			MessageBox.Show($@"The sum of numbers : {sum}. The difference of numbers : {difference}");
		}
	}
}	