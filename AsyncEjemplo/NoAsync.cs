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
	public partial class NoAsync : Form
	{
		public NoAsync()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{ 
			progressBar1.Style = ProgressBarStyle.Marquee;
			progressBar1.Refresh();

			Thread.Sleep(5000);
			progressBar1.Style = ProgressBarStyle.Blocks;
		}

		private void Imagen_Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = !(pictureBox1.Visible);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f = new Form1();
			f.Show();
		}
	}
}
