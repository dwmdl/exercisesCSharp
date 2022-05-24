using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProjForms
{
	static class InputForms
	{
		static void Main()
		{
			// переменная принимающая имя пользователя
			string firstName = Interaction.InputBox("What is your first name? ", "Your First Name");
			// переменная принимающая фамилию пользователя
			string lastName = Interaction.InputBox("What is your last name?", "Your Last Name");
			// помещаем в переменную текст, а также имя и фамилию пользователя 
			string txt = "Very Pleasant " + firstName + lastName + "!";
			// выводим на экран все данные и указываем название окна вторым аргументом
			MessageBox.Show(txt, @"The acquaintance took place");

		}
	}
}