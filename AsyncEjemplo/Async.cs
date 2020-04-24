using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncEjemplo
{
	public partial class Async : Form
	{
		public Async()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = !(pictureBox1.Visible);
		}

		private async void button1_ClickAsync(object sender, EventArgs e)
		{
			progressBar1.Style = ProgressBarStyle.Marquee;
			progressBar1.Refresh();

			await Tarea();
			
			progressBar1.Style = ProgressBarStyle.Blocks;
		}

		private Task Tarea()
		{
			return Task.Delay(5000);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f = new Form1();
			f.Show();
		}
	}
}
