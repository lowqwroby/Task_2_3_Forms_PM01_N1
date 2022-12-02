using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3_Forms_PM01_N1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int A = int.Parse(textBox1.Text);
				int B = int.Parse(textBox2.Text);

				int X = int.Parse(textBox3.Text);
				int Y = int.Parse(textBox4.Text);

				int i = A;

				for(int j = A; j < B; j++)
				{
					if (Math.Abs(j) % 10 == X || Math.Abs(j) % 10 == Y)
					{
						textBox5.Text += string.Format("{0} ", j);
					}
				}

				while(i < B)
				{
					if (Math.Abs(i) % 10 == X || Math.Abs(i) % 10 == Y)
					{
						textBox6.Text += string.Format("{0} ", i);
					}
					i++;
				}

				i = A;
				do
				{
					if (Math.Abs(i) % 10 == X || Math.Abs(i) % 10 == Y)
					{
						textBox7.Text += string.Format("{0} ", i);
					}
					i++;
				} while (i < B);
			}
			catch
			{
				textBox5.Text = string.Format("Некорректный ввод данных");
			}
		}
	}
}
