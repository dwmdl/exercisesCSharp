using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProjForms
{
	static class UsingIfDemo
	{
		static void Main()
		{
			// переменная для определения типа пиктограммы
			MessageBoxIcon icon;
			string msg, title;
			// переменные для определения текста сообщения, заголовка окна и имени пользователя
			string name = Interaction.InputBox("What is your name?", "Getting Acquainted");

			// условный оператор : проверка введенного пользователем текста
			if (name == "") // если текст не введен
			{
				// пиктограмма ошибки
				icon = MessageBoxIcon.Error;
				msg = "It's a pity that we didn't get to know each other";
				title = "The acquaintance did not take place";
			}
			else // если текст введен
			{
				// информационная пиктограмма
				icon = MessageBoxIcon.Information;
				msg = $"Nice to meet you, {name}!";
				title = "The acquaintance took place";
			}

			MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
		}
	}
}