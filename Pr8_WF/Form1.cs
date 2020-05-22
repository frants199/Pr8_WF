using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pr8_WF
{
	public partial class Pr8 : Form
	{
		public Pr8()
		{
			InitializeComponent();
		}
		
		private void execute_button_Click(object sender, EventArgs e)
		{
			try
			{
				Regex r = new Regex(@"[0-255].[0-255].[0-255].[0-255]");
				string text = text_box.Text;
				if (text == "") result_box.Text = "Пустая строка";
				int number = 1;
				number = Convert.ToInt32(numbers_box.Text);
				char[] splitters = { ';', ',', ' ' };
				string[] splitText = text.Split(splitters);
				foreach (string str in splitText)
				{
					if (r.IsMatch(str))
					{
						string[] temp = str.Split('.');
						if (temp[3][0].ToString() == number.ToString())
						{
							text = text.Replace(str, "");
						}
					}
					else
					{
						result_box.Text = "Нет подходящих адресов";
					}
				}
				result_box.Text = text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
