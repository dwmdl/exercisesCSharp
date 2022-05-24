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
			// переменная принимающая возраст пользователя
			string age = Interaction.InputBox("How old are you?", "Your age");
			// помещаем в переменную текст, а также имя и возраст пользователя 
			string txt = "Very Pleasant " + firstName + " Your age: " + age;
			// выводим на экран все данные и указываем название окна вторым аргументом
			MessageBox.Show(txt, @"The acquaintance took place");

		}
	}
}